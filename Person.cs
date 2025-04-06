using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientScheduler
{
    class Person
    {
        public int customerId {  get; set; }
        public string customerName { get; set; }
        public string address {  get; set; }
        Person (int customerId, string customerName, string address)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.address = address;
        }

    }
}
