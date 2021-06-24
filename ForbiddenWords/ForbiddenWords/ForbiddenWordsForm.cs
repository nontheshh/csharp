using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace ForbiddenWords
{
    public partial class ForbiddenWordsForm : Form
    {
        string pathForRes = String.Empty;
        string pathChangedFiles;
        string pathOriginalFiles;
        bool isDone = false;
        bool isStopped = false;
        Thread thread;
        Dictionary<string, int> dictionary;
        StreamWriter streamWriterRes;

        public ForbiddenWordsForm()
        {
            InitializeComponent();
        }

        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void buttonRemoveWord_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (pathForRes == String.Empty)
            {
                MessageBox.Show("The path is not set");
                return;
            }
            dictionary = new Dictionary<string, int>();
            foreach (string el in listBox1.Items)
                dictionary.Add(el, 0);

            thread = new Thread(getCountAnotherThread);
            thread.IsBackground = true;
            thread.Start();
        }

        void getCountAnotherThread()
        {
            PathList pathList = new PathList();

            Wait();
            GetPathOfTxtFiles(pathList);
        }

        async void Wait()
        {
            string[] dots = { "wait", "wait.", "wait..", "wait..." };

            await Task.Run(async () =>
            {
                while (!isDone)
                    for (int i = 0; i < 4; i++)
                    {
                        if (!isStopped)
                        {
                            if (isDone) return;
                            Invoke(new Action(() => { label1.Text = dots[i]; }));
                            await Task.Delay(400);
                        }
                    }
            });
        }

        // находим все txt файлы
        public void GetPathOfTxtFiles(object pathList)
        {
            var drives = DriveInfo.GetDrives();

            foreach (var el in drives)
                Get(el.Name, pathList as PathList);
            isDone = true;

            Invoke(new Action(() => label1.Text = (pathList as PathList).paths.Count.ToString()));
            CheckFiles(pathList as PathList);
        }

        static private void Get(string path, PathList pathList)
        {
            try
            {
                var directories = new DirectoryInfo(path).GetDirectories();

                foreach (DirectoryInfo dir in directories)
                {
                    try
                    {
                        foreach (FileInfo txtFile in dir.GetFiles().Where((el) => el.Extension.ToLower() == ".txt"))
                        {
                            pathList.paths.Add(txtFile.FullName);
                        }
                        Get(dir.FullName, pathList);
                    }
                    catch { }
                }
            }
            catch { }
        }

        // проверяем все txt файлы на наличие запрещенных слов, 
        //и если есть, вырезаем и сохраняем в новый файл изменненый текст
        // лучше, наверное, разделить на несколько методов
        bool CheckText(string txt, string path)
        {
            bool isChanged = false;
            Dictionary<string, int> tmpDictionary = new Dictionary<string, int>();
            string replaceWith = "*******";
            txt = txt.ToLower();

            foreach (var el in dictionary)
                tmpDictionary.Add(el.Key, 0);

            for (int i = 0; i < tmpDictionary.Count; i++)
            {
                string wordToReplace = tmpDictionary.ElementAt(i).Key.ToLower();
                int res = -2;
                int ind = 0;

                while ((res = txt.IndexOf(wordToReplace, ind)) != -1)
                {
                    if (res == 0)
                    {
                    // если найдено запрещенное слово и предыдущий и следующий символ не буква - заменям
                        if (!char.IsLetter(txt[res + wordToReplace.Length]))
                        {
                            txt = txt.Remove(res, res + wordToReplace.Length);
                            txt = replaceWith + txt;
                            tmpDictionary[tmpDictionary.ElementAt(i).Key]++;
                            isChanged = true;
                        }
                    }
                    // если конец текста, проверяем только слева
                    else if (res + wordToReplace.Length == txt.Length)
                    {
                        if (!char.IsLetter(txt[res - 1]))
                        {
                            txt = txt.Remove(res, wordToReplace.Length);
                            txt = txt + replaceWith;
                            tmpDictionary[tmpDictionary.ElementAt(i).Key]++;
                            isChanged = true;
                        }
                    }
                    // проверяем с двух сторон
                    else if (!char.IsLetter(txt[res - 1]) && !char.IsLetter(txt[res + wordToReplace.Length]))
                    {
                        txt = txt.Remove(res, wordToReplace.Length);
                        txt = txt.Insert(res, replaceWith);
                        tmpDictionary[tmpDictionary.ElementAt(i).Key]++;
                        isChanged = true;
                    }
                    ind = res + 1;
                }
            }
            
            // если встретились запрещенные слова - текст с вырезанными слова записывается в файл
            if (isChanged)
            {
                streamWriterRes.WriteLine(path);
                foreach (var el in tmpDictionary)
                {
                    dictionary[el.Key] += el.Value;
                    streamWriterRes.WriteLine(el);
                }
                streamWriterRes.WriteLine("\n=====================");

                string name = "CHANGED " + path.Substring(path.LastIndexOf('\\') + 1);

                File.WriteAllText(pathChangedFiles + name, txt);
            }

            return isChanged;
        }

        // проверяем все txt файлы на наличие запрещенных слов
        void CheckFiles(PathList pathList)
        {
            int i = 1;
            Invoke(new Action(() => { progressBar1.Maximum = pathList.paths.Count; progressBar1.Minimum = 0; progressBar1.Value = 0; }));
            try
            {
                Directory.CreateDirectory(pathChangedFiles);
                Directory.CreateDirectory(pathOriginalFiles);

                streamWriterRes = new StreamWriter(pathForRes + "\\FinalResult.txt");
                foreach (var el in pathList.paths)
                {
                    try
                    {
                        using (var fReader = new StreamReader(el, Encoding.Default))
                        {
                            if (CheckText(fReader.ReadToEnd(), el))
                            {
                                string name = el.Substring(el.LastIndexOf("\\"));
                                File.Copy(el, $"{pathOriginalFiles}\\{name}", true);
                            }
                            Invoke(new Action(() => progressBar1.Value++));
                            Invoke(new Action(() => label2.Text = i++.ToString()));
                        }
                    }
                    catch { }
                }
            }
            catch { }
            finally { streamWriterRes.Dispose(); }
            Invoke(new Action(() => { progressBar1.Value = progressBar1.Maximum; label1.Text = "Finished"; label2.Text = "0"; }));
            // show();
        }

        void show()
        {
            foreach (var el in dictionary)
                Invoke(new Action(() => listBox1.Items.Add(el)));
        }

        void button1_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Suspend();
                isStopped = true;
            }
            catch { }
        }

        void button2_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Resume();
                isStopped = false;
            }
            catch { }
        }

        void buttonSetPathResult_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.Cancel) return;
            pathForRes = fbd.SelectedPath + "\\";

            pathChangedFiles = pathForRes + "Changed Files\\";
            pathOriginalFiles = pathForRes + "Original Files\\";
        }
    }

    class PathList
    {
        public List<string> paths { get; private set; }
        public PathList() => paths = new List<string>();

        public void addPath(string path)
        {
            paths.Add(path);
        }
    }
}
