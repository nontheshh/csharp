using System;
using System.IO;
using System.Windows.Forms;

namespace FileDateTimeEditor
{
    public partial class FileDateTimeEditorForm : Form
    {
        enum DateType { Creation, LastAcces, LastWrite };

        private FileInfo file = null;

        public FileDateTimeEditorForm()
        {
            InitializeComponent();
            cboxDateTypes.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (file == null)
            {
                MessageBox.Show("Please select file");
                return;
            }

            string newDateTimeString = GetDateTime();
            try
            {
                SetFileDateTime(DateTime.Parse(newDateTimeString));
            }
            catch
            {
                MessageBox.Show("Error! Cannot parse date. Date must be dd.mm.yy hh:mm:ss");
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxDateTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxDateTypes.SelectedIndex == -1 || file == null) return;

            SetDateTimeText();
        }

        private void buttonGetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.Cancel) return;

            file = new FileInfo(ofd.FileName);
            labelFileName.Text = file.Name;
            SetDateTimeText();
        }


        private void SetDateTimeText()
        {
            switch ((DateType)cboxDateTypes.SelectedIndex)
            {
                case DateType.Creation:
                    labelFileDate.Text = file.CreationTime.ToString();
                    break;
                case DateType.LastAcces:
                    labelFileDate.Text = file.LastAccessTime.ToString();
                    break;
                case DateType.LastWrite:
                    labelFileDate.Text = file.LastWriteTime.ToString();
                    break;
            }
        }

        private void SetFileDateTime(DateTime datetime)
        {
            switch ((DateType)cboxDateTypes.SelectedIndex)
            {
                case DateType.Creation:
                    file.CreationTime = datetime;
                    break;
                case DateType.LastAcces:
                    file.LastAccessTime = datetime;
                    break;
                case DateType.LastWrite:
                    file.LastWriteTime = datetime;
                    break;
            }
            labelFileDate.Text = datetime.ToString();
        }

        private string GetDateTime()
        {
            string time = String.Empty;
            string date = String.Empty;

            switch ((DateType)cboxDateTypes.SelectedIndex)
            {
                case DateType.Creation:
                    if (string.IsNullOrEmpty(textBox1.Text))
                        date = file.CreationTime.ToShortDateString();
                    else date = textBox1.Text;

                    if (string.IsNullOrEmpty(textBox2.Text))
                        time = file.CreationTime.ToShortTimeString();
                    else time = textBox2.Text;

                    break;

                case DateType.LastAcces:
                    if (string.IsNullOrEmpty(textBox1.Text))
                        date = file.LastAccessTime.ToShortDateString();
                    else date = textBox1.Text;

                    if (string.IsNullOrEmpty(textBox2.Text))
                        time = file.LastAccessTime.ToShortTimeString();
                    else time = textBox2.Text;

                    break;

                case DateType.LastWrite:
                    if (string.IsNullOrEmpty(textBox1.Text))
                        date = file.LastWriteTime.ToShortDateString();
                    else date = textBox1.Text;

                    if (string.IsNullOrEmpty(textBox2.Text))
                        time = file.LastWriteTime.ToShortTimeString();
                    else time = textBox2.Text;

                    break;
            }
            return $"{date} {time}";
        }
    }
}