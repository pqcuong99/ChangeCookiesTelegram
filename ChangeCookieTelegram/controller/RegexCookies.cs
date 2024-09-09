using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace ChangeCookieTelegram.controller
{
    public class RegexCookies
    {
        public static string regexCapyBara(string input)
        {
            string decodedUrl = HttpUtility.UrlDecode(input);

            string queryIdPattern = @"query_id=([^&]+)";
            string userPattern = @"user=({.*?})";
            string hashPattern = @"hash=([^&]+)";
            string hashAuthdate = @"auth_date=([^&]+)";

            Match queryIdMatch = Regex.Match(decodedUrl, queryIdPattern);
            Match userMatch = Regex.Match(decodedUrl, userPattern);
            Match hashMatch = Regex.Match(decodedUrl, hashPattern);
            Match AuthDateMatch = Regex.Match(decodedUrl, hashAuthdate);

            if (queryIdMatch.Success && userMatch.Success && hashMatch.Success && AuthDateMatch.Success)
            {
                string queryId = queryIdMatch.Groups[1].Value;
                string jsonUser = userMatch.Groups[1].Value;
                string hash = hashMatch.Groups[1].Value;
                string AuthDate = AuthDateMatch.Groups[1].Value;

                // Create JObject to hold all the extracted data
                JObject jsonObject = new JObject();
                jsonObject["auth_date"] = AuthDate;
                jsonObject["hash"] = hash;
                jsonObject["query_id"] = queryId;
                jsonObject["user"] = JObject.Parse(jsonUser);

                // Convert JObject to JSON string
                string jsonString = jsonObject.ToString();

                // Print the JSON string
                return jsonString;
            }
            return null;
        }

        public static string regexPokey(string input)
        {
            string decodedUrl = HttpUtility.UrlDecode(input);

            string queryIdPattern = @"query_id=([^&]+)";
            string userPattern = @"user=({.*?})";
            string hashPattern = @"hash=([^&]+)";
            string hashAuthdate = @"auth_date=([^&]+)";

            Match queryIdMatch = Regex.Match(decodedUrl, queryIdPattern);
            Match userMatch = Regex.Match(decodedUrl, userPattern);
            Match hashMatch = Regex.Match(decodedUrl, hashPattern);
            Match AuthDateMatch = Regex.Match(decodedUrl, hashAuthdate);

            if (queryIdMatch.Success && userMatch.Success && hashMatch.Success && AuthDateMatch.Success)
            {
                string queryId = queryIdMatch.Groups[1].Value;
                string jsonUser = userMatch.Groups[1].Value;
                string hash = hashMatch.Groups[1].Value;
                string AuthDate = AuthDateMatch.Groups[1].Value;

                // Create JObject to hold all the extracted data
                JObject jsonObject = new JObject();
                jsonObject["auth_date"] = AuthDate;
                jsonObject["hash"] = hash;
                jsonObject["query_id"] = queryId;
                jsonObject["user"] = JObject.Parse(jsonUser);

                // Convert JObject to JSON string
                string jsonString = jsonObject.ToString();

                // Print the JSON string
                return jsonString;
            }
            return null;
        }

        public static string RegexAuth(string input, string type = "rockyrabbit")
        {
            string decodedUrl = HttpUtility.UrlDecode(input);
            
            if (type == "pokey")
            {
                return regexPokey(decodedUrl);
            }
            if (type == "capybara")
            {
                return regexCapyBara(decodedUrl);
            }

            if (type == "rockyrabbit")
            {
                return "tma " + decodedUrl;
            }
            if (type == "goldminer")
            {
                decodedUrl = HttpUtility.UrlEncode(decodedUrl);
                return decodedUrl;
            }
            if (type == "tonrain")
            {
                return "tma " + decodedUrl;
            }

            return decodedUrl;
        }
    }
}
