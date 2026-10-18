using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;

                FileInfo fileInfo = new FileInfo(filePath);

                txtFileName.Text = fileInfo.Name;
                txtURL.Text = fileInfo.FullName;
                txtSize.Text = fileInfo.Length.ToString() + " bytes";

                using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
                {
                    string content = sr.ReadToEnd();
                    rtbContent.Text = content;

                    string charOnlyContent = content.Replace("\r", "").Replace("\n", "");
                    txtCharCount.Text = charOnlyContent.Length.ToString();

                    string[] lines = content.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    txtLineCount.Text = lines.Length.ToString();

                    char[] separators = { ' ', '\r', '\n', '\t' };
                    string[] words = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    txtWordCount.Text = words.Length.ToString();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}