using ChangeCookieTelegram.controller;
using ChangeCookieTelegram.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ChangeCookieTelegram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtPathFolder.Text = FileHelperController.SelectTextFile();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrayCookies = FileHelperController.ReadAllLines(txtPathFolder.Text.Trim());
                bool isCheck = await IsCheckScheduleStatus();

                if (arrayCookies.Length > 10 && isCheck == true)
                {

                }
            }
            catch(Exception ex)
            {

            }

        }
        public async Task<bool> IsCheckScheduleStatus()
        {
            try
            {
                ApiController api = new ApiController();
                var data = await api.GetSchedule();
                var convertSchedule = JsonConvert.DeserializeObject<ScheduleModel>(data);

                int id = 0;

                foreach (var item in convertSchedule.schedules) { 
                    if(item.status == 2)
                    {
                        id = item.id;
                        continue;
                    }
                }
                var responseWorkLog = await api.GetWorkLogSchedule(id);
                var convertWorklogs = JsonConvert.DeserializeObject<WorkLogSchedule>(responseWorkLog);

                bool isCheck = true;
                foreach (var item in convertWorklogs.data.content)
                {
                    if(item.status == 2)
                    {
                        isCheck = false;
                        continue;
                    }
                }
                return isCheck;
            }catch(Exception ex)
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pathLocal  = Directory.GetCurrentDirectory();
            string[] token = FileHelperController.ReadAllLines(pathLocal + "\\token.txt");
            string[] idFile = FileHelperController.ReadAllLines(pathLocal + "\\id.txt");
            ApiController.author = token[0];
            ApiController.idFile = idFile[0];
        }
        public void LogMessage(string msg, string type = "default")
        {
            Invoke(new MethodInvoker(() =>
            {
                Color color;
                switch (type.ToLower())
                {
                    case "success":
                        color = Color.Green;
                        break;
                    case "error":
                        color = Color.Red;
                        break;
                    default:
                        color = Color.Black;
                        break;
                }

                // Thêm thời gian hiện tại vào thông điệp
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                string messageWithTimestamp = $"[ {timestamp} ]  {msg+"\n"}";

                rtcLog.SelectionStart = rtcLog.TextLength;
                rtcLog.SelectionLength = 0;

                rtcLog.SelectionColor = color;
                rtcLog.AppendText(messageWithTimestamp + Environment.NewLine);
                rtcLog.SelectionColor = rtcLog.ForeColor;
            }));
        }


    }
}
