using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ItemService;
using CustomerService;
using BillService;

namespace restaurantHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri item = new Uri("http://localhost:8733/Design_Time_Addresses/itemService");
            Uri cust = new Uri("http://localhost:8733/Design_Time_Addresses/customerService");
            Uri bill = new Uri("http://localhost:8733/Design_Time_Addresses/billService");
            ServiceHost item_host, cust_host, bill_host; 
            item_host = new ServiceHost(typeof(ItemService.itemService), item);
            cust_host = new ServiceHost(typeof(CustomerService.customerService), cust);
            bill_host = new ServiceHost(typeof(BillService.billService), bill);
            item_host.Open();
            cust_host.Open();
            bill_host.Open();
            Console.WriteLine("Server Connection Successful");
            Console.ReadLine();
            item_host.Close();
            cust_host.Close();
            bill_host.Close ();
        }
    }
}
