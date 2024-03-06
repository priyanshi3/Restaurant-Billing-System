using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ItemService
{
    [DataContract]
    public class Item
    {
        private int item_id;
        private string item_name;
        private int item_price;

        [DataMember]
        public int ItemId
        {
            get { return item_id; }
            set { item_id = value; }
        }

        [DataMember]
        public string ItemName
        {
            get { return item_name; }
            set { item_name = value; }
        }

        [DataMember]
        public int ItemPrice
        {
            get { return item_price; }
            set { item_price = value; }
        }
    }
}
