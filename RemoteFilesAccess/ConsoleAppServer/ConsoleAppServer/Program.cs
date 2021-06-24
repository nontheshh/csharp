using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ConsoleAppServer
{
    class Program
    {
        // директория при старте программы
        //const string initialPath = "... :\\ ...";
        const string initialPath = "D:\\";

        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 9999);
            Listen(listener);
            Console.ReadLine();
            listener.Stop();
        }

        static void SendFile(string name, byte[] file, NetworkStream stream)
        {
            var codeFileNameByte = BitConverter.GetBytes((int)CommandCodes.FileNameSending);
            var codeSendFilebyte = BitConverter.GetBytes((int)CommandCodes.FileSending);
            var fileNameByte = Encoding.UTF8.GetBytes(name);
            var fileNameLengthByte = BitConverter.GetBytes(fileNameByte.Length);
            var fileLengthByte = BitConverter.GetBytes(file.Length);

            stream.Write(codeFileNameByte, 0, codeFileNameByte.Length);
            stream.Write(fileNameLengthByte, 0, fileLengthByte.Length);
            stream.Write(fileNameByte, 0, fileNameByte.Length);
            stream.Write(codeSendFilebyte, 0, codeSendFilebyte.Length);
            stream.Write(fileLengthByte, 0, fileLengthByte.Length);
            stream.Write(file, 0, file.Length);
        }

        static void SendMessage(string message, CommandCodes code, NetworkStream stream)
        {
            var messagebyte = Encoding.UTF8.GetBytes(message);
            var lengthbyte = BitConverter.GetBytes(messagebyte.Length);
            var codebyte = BitConverter.GetBytes((int)code);

            stream.Write(codebyte, 0, codebyte.Length);
            stream.Write(lengthbyte, 0, lengthbyte.Length);
            stream.Write(messagebyte, 0, messagebyte.Length);
        }

        static void ReceiveMessage(TcpClient client, Item selectedItem, FolderContent content)
        {
            var stream = client.GetStream();
            string fname = string.Empty;

            string message = "";
            while (true)
            {
                byte[] codebyte = new byte[sizeof(int)];
                byte[] sizebyte = new byte[sizeof(int)];

                stream.Read(codebyte, 0, codebyte.Length);
                int command = BitConverter.ToInt32(codebyte, 0);

                stream.Read(sizebyte, 0, sizebyte.Length);
                int messageSize = BitConverter.ToInt32(sizebyte, 0);

                CommandCodes code = (CommandCodes)command;

                byte[] bytes = new byte[messageSize];

                int position = 0;
                while (position < messageSize)
                {
                    position += stream.Read(bytes, position, messageSize - position);
                }
                message = Encoding.UTF8.GetString(bytes);

                switch (code)
                {
                    case CommandCodes.FileSending:
                        // отправляет файл
                        fname = message;
                        selectedItem.fullName = fname.Substring(0, fname.LastIndexOf('\\'));
                        SendFile(fname, File.ReadAllBytes(message), stream);
                        break;

                    case CommandCodes.End:
                        return;

                    //case CommandCodes.TxtFile:
                    //    // при открытии txt файла клиентом, отсылает содержимое
                    //    selectedItem.fullName = message;
                    //    fname = selectedItem.fullName;
                    //    string extention = fname.Substring(fname.LastIndexOf('.')).ToLower();
                    //    if (extention == ".txt")
                    //        SendMessage(File.ReadAllText(fname), CommandCodes.TxtFile, stream);
                    //    break;

                    case CommandCodes.Directory:
                        // при открытии папки клиентом, записывает содержимое этой папки
                        selectedItem.fullName = message;
                        content.directories = Directory.GetDirectories(selectedItem.fullName);
                        content.files = Directory.GetFiles(selectedItem.fullName);
                        break;

                    case CommandCodes.Back:
                        // переход клинта в предыдущую папку
                        fname = selectedItem.fullName;
                        selectedItem.fullName = fname.Substring(0, fname.LastIndexOf('\\') + 1);
                        content.directories = Directory.GetDirectories(selectedItem.fullName);
                        content.files = Directory.GetFiles(selectedItem.fullName);
                        break;
                }
            }
        }

        static void SendAllPaths(TcpClient client, FolderContent content)
        {
            var stream = client.GetStream();

            foreach (var el in content.directories)
            {
                SendMessage(el, CommandCodes.Directory, stream);
            }
            foreach (var el in content.files)
            {
                SendMessage(el, CommandCodes.File, stream);
            }

            SendMessage("end", CommandCodes.End, stream);
            stream.Flush();
        }

        static void ClientService(object tcpclient)
        {
            TcpClient client = tcpclient as TcpClient;
            var stream = client.GetStream();
            var item = new Item(initialPath);
            FolderContent folderContent = new FolderContent(
                Directory.GetDirectories(item.fullName), Directory.GetFiles(item.fullName));

            try
            {
                while (true)
                {
                    SendAllPaths(client, folderContent);
                    ReceiveMessage(client, item, folderContent);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Dispose();
            }
        }

        static void Listen(object listener)
        {
            TcpListener server = listener as TcpListener;
            server.Start();
            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    ThreadPool.QueueUserWorkItem(ClientService, client);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        enum CommandCodes { TxtFile, End, File, Directory, Back, FileSending, FileNameSending };
    }
}
