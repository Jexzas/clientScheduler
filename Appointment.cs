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
        public string location { get; set; }
        public string type { get; set; }
        public DateTime date { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate {  get; set; }
        public string updatedBy {  get; set; }
        public Appointment(int appId, int customerID, int userId, string title, string description, string contact, string url, string location, string type, DateTime date, DateTime start, DateTime end,
            DateTime createDate, string createdBy, DateTime lastUpdate, string updatedBy
            ) {
            this.appID = appId;
            this.customerID = customerID;
            this.userId = userId;
            this.title = title;
            this.location = location;
            this.description = description;
            this.contact    = contact;
            this.type = type;
            this.url = url;
            this.date = date;
            this.start = start;
            this.end = end;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.updatedBy = updatedBy;
        }
    }
}
