using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChangeCookieTelegram.controller
{
    public class ApiController
    {
        public static readonly HttpClient httpClient = new HttpClient();
        public static string author = "";
        public static string idFile = "";
        public HttpRequestMessage HeaderRequest(string url)
        {
            //var request = new HttpRequestMessage(HttpMethod.Post, "https://cdn.hidemium.com/v4/file/upload");
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add("authority", "cdn.hidemium.com");
            request.Headers.Add("accept", "application/json, text/plain, */*");
            request.Headers.Add("accept-language", "en-US");
            request.Headers.Add("authorization", author);
            request.Headers.Add("referer", "https://v4-renderer.hidemium.com/");
            request.Headers.Add("sec-ch-ua", "\"Not(A:Brand\";v=\"24\", \"Chromium\";v=\"122\"");
            request.Headers.Add("sec-ch-ua-mobile", "?0");
            request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
            request.Headers.Add("sec-fetch-dest", "empty");
            request.Headers.Add("sec-fetch-mode", "cors");
            request.Headers.Add("sec-fetch-site", "same-site");
            request.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Hidemium_4/4.0.20 Chrome/122.0.6261.156 Electron/29.3.0 Safari/537.36");

            return request;
        }
        public HttpRequestMessage HeaderLocal(string url,string type = "get")
        {
            //var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:2222/automation/schedule?page=1&limit=10");
            var request = new HttpRequestMessage(type == "get" ? HttpMethod.Get : HttpMethod.Post, url);
            request.Headers.Add("Accept", "application/json, text/plain, */*");
            request.Headers.Add("Accept-Language", "en-US");
            request.Headers.Add("Connection", "keep-alive");
            request.Headers.Add("Sec-Fetch-Dest", "empty");
            request.Headers.Add("Sec-Fetch-Mode", "cors");
            request.Headers.Add("Sec-Fetch-Site", "cross-site");
            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Hidemium_4/4.0.20 Chrome/122.0.6261.156 Electron/29.3.0 Safari/537.36");
            request.Headers.Add("sec-ch-ua", "\"Not(A:Brand\";v=\"24\", \"Chromium\";v=\"122\"");
            request.Headers.Add("sec-ch-ua-mobile", "?0");
            request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
            return request;
        }
        public async Task<string> PostUploadFile(string contentUpload)
        {
            string url = "https://cdn.hidemium.com/v4/file/upload";
            var request = HeaderRequest(url);

            var content = new MultipartFormDataContent();
            content.Add(new StringContent(contentUpload), "file_content");
            content.Add(new StringContent(idFile), "file_id");

            request.Content = content;
            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetSchedule()
        {
            string url = "http://localhost:2222/automation/schedule?page=1&limit=10";
            var request = HeaderLocal(url, "get");

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetWorkLogSchedule(int id)
        {
            string url = "http://localhost:2222/automation/worklogs/list";
            var request = HeaderLocal(url,"post");
            var json = new JObject
            {
                ["page"] = 1,
                ["limit"] = 15,
                ["schedule_id"] = id
            };

            var content = new StringContent(JsonConvert.SerializeObject(json), null, "application/json");
            request.Content = content;
            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
