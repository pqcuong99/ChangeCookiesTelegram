using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCookieTelegram.model
{
    public class ScheduleModel
    {
        public Schedule[] schedules { get; set; }
        public int total { get; set; }
    }

    public class Schedule
    {
        public int id { get; set; }
        public string name { get; set; }
        public int campaign_id { get; set; }
        public int task_type { get; set; }
        public int execution_frequency { get; set; }
        public int? interval_time { get; set; }
        public object execute_time { get; set; }
        public object execute_day { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string user_uuid { get; set; }
        public int status { get; set; }
        public int total_profile_pending { get; set; }
        public int total_profile_running { get; set; }
        public int total_profile_success { get; set; }
        public int total_profile_error { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

}
