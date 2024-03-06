using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    [DataContract]
    public class Customer
    {
        private int cust_id;
        private string cust_name;
        private long cust_phone_number;

        [DataMember]
        public int CustId
        {
            get { return cust_id; }
            set { cust_id = value; }
        }

        [DataMember]
        public string CustName
        {
            get { return cust_name; }
            set { cust_name = value; }
        }

        [DataMember]
        public long CustPhoneNumber
        {
            get { return cust_phone_number; }
            set { cust_phone_number = value; }
        }
    }
}
