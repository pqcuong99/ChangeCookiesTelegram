using ChangeCookieTelegram.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCookieTelegram.view
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPathFolderProfile_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPathFolderProfile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Hiển thị hộp thoại cho phép chọn thư mục
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn thư mục được chọn
                string selectedFolderPath = folderBrowserDialog.SelectedPath;

                // Hiển thị đường dẫn thư mục (hoặc xử lý tùy theo yêu cầu)
                txtPathFolderProfile.Text = selectedFolderPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pathFileCookie = txtFileCookie.Text.Trim();
            string pathFolderProfile = txtPathFolderProfile.Text.Trim();
            if(pathFileCookie != string.Empty && pathFolderProfile != string.Empty)
            {
                string workingDirectory = Environment.CurrentDirectory;
                string type = cb30Minute.Checked == true ? "30" : "120";
                string content = pathFileCookie + "|" + pathFolderProfile + "|" + type;
                FileHelperController.WriteToFile(workingDirectory + "\\data_save.txt", content);
                Form1 form1 = new Form1(content);
                form1.Show();
                this.Hide();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string[] content = FileHelperController.ReadAllLines(workingDirectory + "\\data_save.txt");
            
            if(content.Length > 0)
            {
                var contentSave = content[0].Split('|');
                txtFileCookie.Text = contentSave[0].Trim();
                txtPathFolderProfile.Text = contentSave[1].Trim();
                if (Int32.Parse(contentSave[2]) == 30)
                {
                    cb30Minute.Checked = true;
                    cb120Minute.Checked = false;
                }
                else
                {
                    cb30Minute.Checked = false;
                    cb120Minute.Checked = true;
                }
            }
            else
            {
                cb30Minute.Checked = true;
                cb120Minute.Checked = false;
            }
        }

        private void btnFileCookie_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Chỉ cho phép chọn file .txt
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            // Hiển thị hộp thoại và kiểm tra xem người dùng có chọn file không
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của file được chọn
                string selectedFilePath = openFileDialog.FileName;

                // Hiển thị đường dẫn file (hoặc xử lý tùy theo yêu cầu)
                txtFileCookie.Text = selectedFilePath;
            }
        }

        private void txtFileCookie_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đảm bảo khi đóng Settings thì ứng dụng sẽ kết thúc
            Application.Exit();
        }

        private void cb30Minute_CheckedChanged(object sender, EventArgs e)
        {
            if (cb30Minute.Checked)
            {
                cb120Minute.Checked = false;
            }
        }

        private void cb120Minute_CheckedChanged(object sender, EventArgs e)
        {
            if (cb120Minute.Checked)
            {
                cb30Minute.Checked = false;
            }
        }
    }
}
