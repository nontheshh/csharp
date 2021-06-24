using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;

namespace ConsoleAppClient
{
    class Program
    {
        static Item selectedItem = null;
        static TcpClient client = null;

        static void Main(string[] args)
        {
            List<Item> list = new List<Item>();
            ItemType type = ItemType.Nothing;

            using (client = new TcpClient())
            {
                Connect();
                // client.Connect("127.0.0.1", 9999);   
                NetworkStream stream = client.GetStream();
                string message = "";

                string filename = string.Empty;

                while (true)
                {
                    byte[] sizebyte = new byte[sizeof(int)];
                    byte[] commandbyte = new byte[sizeof(int)];

                    stream.Read(commandbyte, 0, commandbyte.Length);
                    int command = BitConverter.ToInt32(commandbyte, 0);
                    CommandCodes code = (CommandCodes)command;

                    stream.Read(sizebyte, 0, sizebyte.Length);
                    int messageSize = BitConverter.ToInt32(sizebyte, 0);

                    byte[] bytes = new byte[messageSize];

                    int position = 0;
                    while (position < messageSize)
                    {
                        position += stream.Read(bytes, position, messageSize - position);
                    }

                    if (code != CommandCodes.FileSending)
                        message = Encoding.UTF8.GetString(bytes);

                    switch (code)
                    {
                        case CommandCodes.FileNameSending:
                            filename = message.Substring(message.LastIndexOf('\\') + 1);
                            break;

                        case CommandCodes.FileSending:
                            // создает файл и записует туда присланные байты
                            FileStream file = File.Create(filename);
                            file.Write(bytes, 0, bytes.Length);
                            file.Close();
                            break;

                        case CommandCodes.TxtFile:
                            // todo: вывод txt файла
                            // сейчас txt файла, как и все остальные, копируются в директорию с exe
                            //Console.WriteLine(message);
                            continue;

                        case CommandCodes.End:
                            ShowFiles(list);
                            Answer();
                            continue;

                        case CommandCodes.File:
                            // добавляет присланное имя файла в список с файлами
                            type = ItemType.File;
                            list.Add(new Item(message, type));
                            continue;

                        case CommandCodes.Directory:
                            // добавляет присланное имя папки в список с папками
                            type = ItemType.Directory;
                            list.Add(new Item(message, type));
                            continue;
                    }
                }
            }
        }

        static void Connect()
        {
            string ip = string.Empty;
            int port = 0;
            while (true)
            {
                try
                {
                    ColorfulPrint("enter the following:", ConsoleColor.Blue);
                    ColorfulPrint("\tip", ConsoleColor.DarkGray);
                    ip = Console.ReadLine();
                    while (true)
                    {
                        try
                        {
                            ColorfulPrint("\tport", ConsoleColor.DarkGray);
                            port = Int32.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.Clear();
                            ColorfulPrint("incorrect port format\n", ConsoleColor.DarkGray);
                            continue;
                        }
                        break;
                    }
                    client.Connect(ip, port);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("error\n");
                    Console.WriteLine(ex.Message);
                    continue;
                }
                Console.Clear();
                Console.WriteLine("Connected");
                break;
            }
        }

        private static void Answer()
        {
            if (client == null) Quit();
            var stream = client.GetStream();
            string type = string.Empty;
            string fname = selectedItem.fullName;

            switch (selectedItem.type)
            {
                case ItemType.Something:
                    SendMessage(fname, CommandCodes.FileSending, stream);
                    break;

                case ItemType.Directory:
                    SendMessage(fname, CommandCodes.Directory, stream);
                    break;

                case ItemType.File:
                    SendMessage(fname, CommandCodes.File, stream);
                    break;

                case ItemType.Nothing:
                    SendMessage(fname, CommandCodes.Back, stream);
                    break;

                case ItemType.TxtFile:
                    SendMessage(fname, CommandCodes.TxtFile, stream);
                    break;
            }


            SendMessage("end", CommandCodes.End, stream);
            stream.Flush();
        }

        static void SendMessage(string message, CommandCodes code, NetworkStream stream)
        {
            var buf = Encoding.UTF8.GetBytes(message);
            var siz = BitConverter.GetBytes(buf.Length);
            var cod = BitConverter.GetBytes((int)code);

            stream.Write(cod, 0, cod.Length);
            stream.Write(siz, 0, siz.Length);
            stream.Write(buf, 0, buf.Length);
        }

        private static void ShowFiles(List<Item> items)
        {
            ConsoleKeyInfo ch;
            int curItem = 0;
            int i = 0;

            while (true)
            {
                ColorfulPrint("\t\tDirectories:", ConsoleColor.DarkGray);
                for (; i < items.Count; i++)
                {
                    if (i == curItem) Console.ForegroundColor = ConsoleColor.Blue;

                    if (items[i].type == ItemType.Directory) Console.WriteLine($"\t{items[i].name}");
                    else break;

                    Console.ResetColor();
                }

                ColorfulPrint("\n\t\tFiles:", ConsoleColor.DarkGray);
                for (; i < items.Count; i++)
                {
                    if (i == curItem) Console.ForegroundColor = ConsoleColor.Blue;

                    if (items[i].type == ItemType.File) Console.WriteLine($"\t{items[i].name}");
                    else break;

                    Console.ResetColor();
                }

                ColorfulPrint("\n\tPress: \n'q' to quit;\n 'b' to back; \narrows to navigate; \n'enter' to open directory or copy file", ConsoleColor.Green);
                ch = Console.ReadKey();
                if ((ch.Key == ConsoleKey.DownArrow || ch.Key == ConsoleKey.S) && curItem < items.Count - 1) curItem++;
                if ((ch.Key == ConsoleKey.UpArrow || ch.Key == ConsoleKey.W) && curItem > 0) curItem--;
                if (ch.Key == ConsoleKey.Enter || ch.Key == ConsoleKey.E || ch.Key == ConsoleKey.F) break;
                if (ch.Key == ConsoleKey.Q) Quit();
                if (ch.Key == ConsoleKey.B)
                {
                    selectedItem = new Item("back", ItemType.Nothing);
                    Console.Clear();
                    items.Clear();
                    return;
                }
                Console.Clear();
                i = 0;
            }
            selectedItem = items[curItem];
            if (File.Exists(selectedItem.fullName))
            {
                FileInfo file = new FileInfo(selectedItem.fullName);
                if (file.Extension.ToLower() == "txt")
                    selectedItem = new Item(selectedItem.fullName, ItemType.TxtFile);
                else
                    selectedItem = new Item(selectedItem.fullName, ItemType.Something);
            }
            Console.Clear();
            items.Clear();
        }

        private static void Quit()
        {
            client.Dispose();
            Console.WriteLine();
            Environment.Exit(0);
        }

        static void ColorfulPrint(string txt, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(txt);
            Console.ResetColor();
        }
    }

    enum CommandCodes { TxtFile, End, File, Directory, Back, FileSending, FileNameSending };
}