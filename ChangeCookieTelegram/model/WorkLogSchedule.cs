using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCookieTelegram.model
{
    public class WorkLogSchedule
    {
        public Data data { get; set; }
        public Links links { get; set; }
        public Meta1 meta { get; set; }
    }

    public class Data
    {
        public string type { get; set; }
        public string title { get; set; }
        public Content[] content { get; set; }
        public Meta meta { get; set; }
    }

    public class Meta
    {
        public int total { get; set; }
    }

    public class Content
    {
        public int id { get; set; }
        public int campaign_id { get; set; }
        public int schedule_id { get; set; }
        public string profile_uuid { get; set; }
        public string profile_name { get; set; }
        public int status { get; set; }
        public string user_uuid { get; set; }
        public string start_time { get; set; }
        public string start_run_time { get; set; }
        public string end_run_time { get; set; }
        public string end_time { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class Links
    {
        public string first { get; set; }
        public string last { get; set; }
        public string prev { get; set; }
        public string next { get; set; }
    }

    public class Meta1
    {
        public int current_page { get; set; }
        public int from { get; set; }
        public int last_page { get; set; }
        public string path { get; set; }
        public int per_page { get; set; }
        public int to { get; set; }
        public int total { get; set; }
    }

}
