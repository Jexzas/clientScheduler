using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientScheduler
{
    public class Appointment
    {
        public int appID {  get; set; }
        public int customerID { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string contact {  get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public Appointment(int appId, int customerID, int userId, string title, string description, string contact, string url, string type, DateTime start, DateTime end) {
            this.appID = appId;
            this.customerID = customerID;
            this.userId = userId;
            this.title = title;
            this.description = description;
            this.contact    = contact;
            this.type = type;
            this.url = url;
            this.start = start;
            this.end = end;

        }
    }
}
