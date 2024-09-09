﻿using ChangeCookieTelegram.controller;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ChangeCookieTelegram
{
    public partial class Form1 : Form
    {
        System.Threading.Timer timer;
        TimeSpan remainingTime = TimeSpan.FromMinutes(10);
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
                StartChange();
            }
            catch(Exception ex)
            {

            }

        }
        public void StartChange()
        {
            LogMessage("-------------- StartChange ----------");
            btnStart.Text = "Running ....";
            Thread thread = new Thread(() =>
            {
                timer = new System.Threading.Timer(TimerCallback, null, TimeSpan.Zero, TimeSpan.FromMinutes(10)); // Gọi lại sau mỗi 2 giờ
                while (true) // Vòng lặp vô hạn để liên tục cập nhật thời gian đếm ngược
                {
                    if (remainingTime > TimeSpan.Zero)
                    {
                        ShowTimeOut($"Time out: {remainingTime:hh\\:mm\\:ss}");

                        Thread.Sleep(1000); // Chờ 1 giây
                        remainingTime -= TimeSpan.FromSeconds(1);
                    }
                    else
                    {
                        remainingTime = TimeSpan.FromMinutes(10); // Đặt lại thời gian đếm ngược sau mỗi lần gọi hàm
                    }
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
        public async void TimerCallback(object state)
        {
            try
            {
                List<string> listRabbit = new List<string>();
                List<string> listMidas = new List<string>();
                List<string> listTomerket = new List<string>();
                List<string> listGoldMiner = new List<string>();
                List<string> listKuroro = new List<string>();
                List<string> listOkx = new List<string>();
                List<string> listOnus = new List<string>();
                List<string> listPokey = new List<string>();
                List<string> listBanana = new List<string>();
                List<string> listAva = new List<string>();
                List<string> listTonrain = new List<string>();
                List<string> listWon = new List<string>();
                List<string> listTontab = new List<string>();
                List<string> listKaiaPlay = new List<string>();
                List<string> listBlum = new List<string>();
                List<string> listMatchQuest = new List<string>();
                List<string> listMajor = new List<string>();
                List<string> listCapybara = new List<string>();
                BodyUpload body = new BodyUpload();

                string path = txtPathFolder.Text.Trim();
                if (path == "")
                {
                    path = "C:\\Users\\Xoai\\Documents\\UrlGameTele.txt";
                }

                string[] arrayCookies = FileHelperController.ReadAllLines(txtPathFolder.Text.Trim());
                bool isCheck = await IsCheckScheduleStatus();
                LogMessage($"Check data ====>  count : {arrayCookies.Length} | isCheck : {isCheck}", isCheck == true ? "success" :"error");
                if (arrayCookies.Length > 10 && isCheck == true)
                {
                    var arrayPath = path.Split('\\');
                    string pathCopy = "";
                    for (int i = 0; i < arrayPath.Length; i++)
                    {
                        if (!arrayPath[i].Contains(".txt"))
                        {
                            pathCopy += arrayPath[i] + "\\";
                        }
                    }
                    pathCopy += "UrlGameTeleCopy.txt";

                    foreach (var line in arrayCookies)
                    {
                        var item = line.Trim().Split('|');
                        if (item[0].Contains("rabbit"))
                        {
                            listRabbit.Add(RegexCookies.RegexAuth(item[1].Trim(), "rockyrabbit"));
                        }
                        else if (item[0].Contains("midas"))
                        {
                            listMidas.Add(RegexCookies.RegexAuth(item[1].Trim(), "midas"));
                        }
                        else if (item[0].Contains("tomerket"))
                        {
                            listTomerket.Add(RegexCookies.RegexAuth(item[1].Trim(), "tomarket"));
                        }
                        else if (item[0].Contains("goldminer"))
                        {
                            listGoldMiner.Add(RegexCookies.RegexAuth(item[1].Trim(), "goldminer"));
                        }
                        else if (item[0].Contains("kuroro"))
                        {
                            listKuroro.Add(RegexCookies.RegexAuth(item[1].Trim(), "kuroro"));
                        }
                        else if (item[0].Contains("okx"))
                        {
                            listOkx.Add(RegexCookies.RegexAuth(item[1].Trim(), "okx"));
                        }
                        else if (item[0].Contains("pokey"))
                        {
                            listPokey.Add(RegexCookies.RegexAuth(item[1].Trim(), "pokey"));
                        }
                        else if (item[0].Contains("capybara"))
                        {
                            listCapybara.Add(RegexCookies.RegexAuth(item[1].Trim(), "capybara"));
                        }
                        else if (item[0].Contains("banana"))
                        {
                            listBanana.Add(RegexCookies.RegexAuth(item[1].Trim(), "listBanana"));
                        }
                        else if (item[0].Contains("ava"))
                        {
                            listAva.Add(RegexCookies.RegexAuth(item[1].Trim(), "ava"));
                        }
                        else if (item[0].Contains("tonrain"))
                        {
                            listTonrain.Add(RegexCookies.RegexAuth(item[1].Trim(), "tonrain"));
                        }
                        else if (item[0].Contains("won"))
                        {
                            listWon.Add(RegexCookies.RegexAuth(item[1].Trim(), "won"));
                        }
                        else if (item[0].Contains("tontab"))
                        {
                            listTontab.Add(RegexCookies.RegexAuth(item[1].Trim(), "tontab"));
                        }
                        else if (item[0].Contains("kaiaplay"))
                        {
                            listKaiaPlay.Add(RegexCookies.RegexAuth(item[1].Trim(), "kaiaplay"));
                        }
                        else if (item[0].Contains("blum"))
                        {
                            listBlum.Add(RegexCookies.RegexAuth(item[1].Trim(), "blum"));
                        }
                        else if (item[0].Contains("matchquest"))
                        {
                            listMatchQuest.Add(RegexCookies.RegexAuth(item[1].Trim(), "matchquest"));
                        }
                        else if (item[0].Contains("major"))
                        {
                            listMajor.Add(RegexCookies.RegexAuth(item[1].Trim(), "major"));
                        }
                    }

                    body.rockyrabbit = listRabbit.ToArray();
                    body.midas = listMidas.ToArray();
                    body.tomarket = listTomerket.ToArray();
                    body.goldminer = listGoldMiner.ToArray();
                    body.kuroro = listKuroro.ToArray();
                    body.okx = listOkx.ToArray();
                    body.capybara = listCapybara.ToArray();
                    body.pokey = listPokey.ToArray();
                    body.banana = listBanana.ToArray();
                    body.ava = listAva.ToArray();
                    body.tonrain = listTonrain.ToArray();
                    body.won = listWon.ToArray();
                    body.tontab = listTontab.ToArray();
                    body.kaiaplay = listKaiaPlay.ToArray();
                    body.blum = listBlum.ToArray();
                    body.matchquest = listMatchQuest.ToArray();
                    body.major = listMajor.ToArray();

                    ApiController api = new ApiController();
                    string result = await api.PostUploadFile(body);
                    LogMessage(result,"success");
                    FileHelperController.ClearTextInFile(path);
                    FileHelperController.TextInFile(pathCopy, string.Join("\n", arrayCookies));
                }

            }
            catch(Exception ex)
            {
                LogMessage(ex.Message, "error");
            }
        }
        public void ShowTimeOut(string time)
        {
            Invoke(new MethodInvoker(() =>
            {
                lbTime.Text = time;
            }));
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

        private void rtcLog_TextChanged(object sender, EventArgs e)
        {
            rtcLog.ScrollToCaret();
        }
    }
}
