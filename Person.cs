using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientScheduler
{
    public class Person
    {
        public int customerId {  get; set; }
        public string customerName { get; set; }
        public string address {  get; set; }
        public int cityId { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }
        public int active { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate {  get; set; }
        public string lastUpdatedBy { get; set; }
        public Person (int customerId, string customerName, string address, int cityId, string postalCode, string phone, Int32 active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.address = address;
            this.active = active;
            this.createDate = createDate;
            this.createdBy = createdBy;
            this.lastUpdate = lastUpdate;
            this.lastUpdatedBy = lastUpdateBy;
            this.cityId = cityId;
            this.postalCode = postalCode;
            this.phone = phone;
        }

    }
}
