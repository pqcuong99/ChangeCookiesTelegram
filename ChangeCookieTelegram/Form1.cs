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
        string type = "30phut";
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
        public  string TypeCheck()
        {
            return null;
        }
        public void StartChange()
        {
            LogMessage("-------------- StartChange ----------");
            btnStart.Text = "Running ....";
            Thread thread = new Thread(() =>
            {
                if(type == "30phut")
                {
                    timer = new System.Threading.Timer(TimerCallback_30, null, TimeSpan.Zero, TimeSpan.FromMinutes(5)); // Gọi lại sau mỗi 10phut
                }
                //if (type == "60phut")
                //{
                //    timer = new System.Threading.Timer(TimerCallback, null, TimeSpan.Zero, TimeSpan.FromMinutes(10)); // Gọi lại sau mỗi 10phut
                //}
                if (type == "120phut")
                {
                    timer = new System.Threading.Timer(TimerCallback_120, null, TimeSpan.Zero, TimeSpan.FromMinutes(10)); // Gọi lại sau mỗi 10phut
                }

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
                        remainingTime = TimeSpan.FromMinutes(type == "30phut" ? 5 :10); // Đặt lại thời gian đếm ngược sau mỗi lần gọi hàm
                    }
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
        public async void TimerCallback_120(object state)
        {
            try
            {
                List<string> listRabbit = new List<string>();
                List<string> listMidas = new List<string>();
                List<string> listTomerket = new List<string>();
                List<string> listLumoz = new List<string>();
                List<string> listMozoAi = new List<string>();
                List<string> listBanana = new List<string>();
                List<string> listIamDog = new List<string>();
                List<string> listWon = new List<string>();
                List<string> listVanilla = new List<string>();
                List<string> listKaiaPlay = new List<string>();
                List<string> listBlum = new List<string>();
                List<string> listMatchQuest = new List<string>();
                List<string> listMajor = new List<string>();
                List<string> listCapybara = new List<string>();
                List<string> listTsubasa = new List<string>();
                BodyUpload_120 body = new BodyUpload_120();

                string path = txtPathFolder.Text.Trim();
                if (path == "")
                {
                    path = "C:\\Users\\Xoai\\Documents\\UrlGameTele.txt";
                }

                string[] arrayCookies = FileHelperController.ReadAllLines(path);
                bool isCheck = await IsCheckScheduleStatus();
                LogMessage($"Check data ====>  count : {arrayCookies.Length} | isCheck : {isCheck}", isCheck == true ? "success" :"error");
                if (arrayCookies.Length > 100 && isCheck == true)
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
                    pathCopy += "UrlGameTeleCopy_120.txt";

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
                        else if (item[0].Contains("lumoz"))
                        {
                            listLumoz.Add(RegexCookies.RegexAuth(item[1].Trim(), "lumoz"));
                        }
                        
                        else if (item[0].Contains("mozoai"))
                        {
                            listMozoAi.Add(RegexCookies.RegexAuth(item[1].Trim(), "mozoai"));
                        }
                        
                        else if (item[0].Contains("capybara"))
                        {
                            listCapybara.Add(RegexCookies.RegexAuth(item[1].Trim(), "capybara"));
                        }
                        else if (item[0].Contains("banana"))
                        {
                            listBanana.Add(RegexCookies.RegexAuth(item[1].Trim(), "listBanana"));
                        }
                        
                        else if (item[0].Contains("iamdog"))
                        {
                            listIamDog.Add(RegexCookies.RegexAuth(item[1].Trim(), "iamdog"));
                        }
                        else if (item[0].Contains("won"))
                        {
                            listWon.Add(RegexCookies.RegexAuth(item[1].Trim(), "won"));
                        }
                        else if (item[0].Contains("vanilla"))
                        {
                            listVanilla.Add(RegexCookies.RegexAuth(item[1].Trim(), "vanilla"));
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
                        }else if (item[0].Contains("tsubasa"))
                        {
                            listTsubasa.Add(RegexCookies.RegexAuth(item[1].Trim(), "tsubasa"));
                        }
                    }

                    body.rockyrabbit = listRabbit.ToArray();
                    body.midas = listMidas.ToArray();
                    body.tomarket = listTomerket.ToArray();
                    body.lumoz = listLumoz.ToArray();
                    body.mozoai = listMozoAi.ToArray();
                    body.capybara = listCapybara.ToArray();
                    body.banana = listBanana.ToArray();
                    body.iamdog = listIamDog.ToArray();
                    body.won = listWon.ToArray();
                    body.vanilla = listVanilla.ToArray();
                    body.kaiaplay = listKaiaPlay.ToArray();
                    body.blum = listBlum.ToArray();
                    body.matchquest = listMatchQuest.ToArray();
                    body.major = listMajor.ToArray();
                    body.tsubasa = listTsubasa.ToArray();

                    ApiController api = new ApiController();
                    string result = await api.PostUploadFile_120(body);
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
        public async void TimerCallback_30(object state)
        {
            try
            {
                List<string> listKuroro = new List<string>();
                List<string> listPokey = new List<string>();
                List<string> listAva = new List<string>();
                List<string> listGumart = new List<string>();
                List<string> listMoonbix = new List<string>();
                List<string> listFastmint = new List<string>();
                List<string> listCoinsweeper = new List<string>();
                BodyUpload_30 body = new BodyUpload_30();

                string path = txtPathFolder.Text.Trim();
                if (path == "")
                {
                    path = "C:\\Users\\Xoai\\Documents\\UrlGameTele.txt";
                }

                string[] arrayCookies = FileHelperController.ReadAllLines(txtPathFolder.Text.Trim());
                bool isCheck = await IsCheckScheduleStatus();
                LogMessage($"Check data ====>  count : {arrayCookies.Length} | isCheck : {isCheck}", isCheck == true ? "success" : "error");
                if (arrayCookies.Length > 20 && isCheck == true)
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
                    pathCopy += "UrlGameTeleCopy_30.txt";

                    foreach (var line in arrayCookies)
                    {
                        var item = line.Trim().Split('|');
                        if (item[0].Contains("kuroro"))
                        {
                            listKuroro.Add(RegexCookies.RegexAuth(item[1].Trim(), "kuroro"));
                        }
                        else if (item[0].Contains("pokey"))
                        {
                            listPokey.Add(RegexCookies.RegexAuth(item[1].Trim(), "pokey"));
                        }
                        else if (item[0].Contains("ava"))
                        {
                            listAva.Add(RegexCookies.RegexAuth(item[1].Trim(), "ava"));
                        }else if (item[0].Contains("gumart"))
                        {
                            listGumart.Add(RegexCookies.RegexAuth(item[1].Trim(), "gumart"));
                        }else if (item[0].Contains("moonbix"))
                        {
                            listMoonbix.Add(RegexCookies.RegexAuth(item[1].Trim(), "moonbix"));
                        }else if (item[0].Contains("fastmint"))
                        {
                            listFastmint.Add(RegexCookies.RegexAuth(item[1].Trim(), "fastmint"));
                        }else if (item[0].Contains("coinsweeper"))
                        {
                            listCoinsweeper.Add(RegexCookies.RegexAuth(item[1].Trim(), "coinsweeper"));
                        }
                    }

                    body.kuroro = listKuroro.ToArray();
                    body.pokey = listPokey.ToArray();
                    body.ava = listAva.ToArray();
                    body.gumart = listGumart.ToArray();
                    body.moonbix = listMoonbix.ToArray();
                    body.fastmint = listFastmint.ToArray();
                    body.coinsweeper = listCoinsweeper.ToArray();
                    
                    ApiController api = new ApiController();
                    string result = await api.PostUploadFile_30(body);
                    LogMessage(result, "success");
                    FileHelperController.ClearTextInFile(path);
                    FileHelperController.TextInFile(pathCopy, string.Join("\n", arrayCookies));
                }

            }
            catch (Exception ex)
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
            cb30phut.Checked = true;
            cb60phut.Checked = false;
            cb120phut.Checked = false;
            string pathLocal  = Directory.GetCurrentDirectory();
            string[] token = FileHelperController.ReadAllLines(pathLocal + "\\token.txt");
            ApiController.author = token[0];
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

        #region Xử lý sự kiện checkbox
        private void cb30phut_CheckedChanged(object sender, EventArgs e)
        {
            cb30phut.CheckedChanged -= cb30phut_CheckedChanged;
            cb60phut.CheckedChanged -= cb60phut_CheckedChanged;
            cb120phut.CheckedChanged -= cb120phut_CheckedChanged;

            try
            {
                // Thay đổi trạng thái của các checkbox
                cb30phut.Checked = true;
                cb60phut.Checked = false;
                cb120phut.Checked = false;
                type = "30phut";
            }
            finally
            {
                // Bật lại sự kiện CheckedChanged
                cb30phut.CheckedChanged += cb30phut_CheckedChanged;
                cb60phut.CheckedChanged += cb60phut_CheckedChanged;
                cb120phut.CheckedChanged += cb120phut_CheckedChanged;
            }
        }

        private void cb60phut_CheckedChanged(object sender, EventArgs e)
        {
            cb30phut.CheckedChanged -= cb30phut_CheckedChanged;
            cb60phut.CheckedChanged -= cb60phut_CheckedChanged;
            cb120phut.CheckedChanged -= cb120phut_CheckedChanged;

            try
            {
                // Thay đổi trạng thái của các checkbox
                cb30phut.Checked = false;
                cb60phut.Checked = true;
                cb120phut.Checked = false;
                type = "60phut";
            }
            finally
            {
                // Bật lại sự kiện CheckedChanged
                cb30phut.CheckedChanged += cb30phut_CheckedChanged;
                cb60phut.CheckedChanged += cb60phut_CheckedChanged;
                cb120phut.CheckedChanged += cb120phut_CheckedChanged;
            }
        }

        private void cb120phut_CheckedChanged(object sender, EventArgs e)
        {
            cb30phut.CheckedChanged -= cb30phut_CheckedChanged;
            cb60phut.CheckedChanged -= cb60phut_CheckedChanged;
            cb120phut.CheckedChanged -= cb120phut_CheckedChanged;

            try
            {
                // Thay đổi trạng thái của các checkbox
                cb30phut.Checked = false;
                cb60phut.Checked = false;
                cb120phut.Checked = true;
                type = "120phut";
            }
            finally
            {
                // Bật lại sự kiện CheckedChanged
                cb30phut.CheckedChanged += cb30phut_CheckedChanged;
                cb60phut.CheckedChanged += cb60phut_CheckedChanged;
                cb120phut.CheckedChanged += cb120phut_CheckedChanged;
            }
        }
        #endregion
    }
}
