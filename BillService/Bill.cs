using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BillService
{
    [DataContract]
    public class Bill
    {
        private int cust_id;
        private String items;
        private int amount;
        private DateTime date;

        [DataMember]
        public int CustId
        {
            get { return cust_id; }
            set { cust_id = value; }
        }

        [DataMember]
        public String Items
        {
            get { return items; }
            set { items = value; }
        }

        [DataMember]
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        [DataMember]
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
