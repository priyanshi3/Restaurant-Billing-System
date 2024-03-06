using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public class customerService : customerInterface
    {
        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-BVM550KD\\SQLEXPRESS01;Initial Catalog=restaurant;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public void AddCustomer(string cust_name, long cust_ph_num)
        {
            string query = "insert into customer(cust_name, cust_phone_number) values('" + cust_name + "', " + cust_ph_num + ")";
            cmd.Connection = con;
            cmd.CommandText = query;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Customer GetCustByPhn(long cust_ph_num)
        {
            string query = "select * from customer where cust_phone_number = " + cust_ph_num;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Customer cust = new Customer();
            while(reader.Read())
            {
                cust.CustId = reader.GetInt32(0);
                cust.CustName = reader.GetString(1);
                cust.CustPhoneNumber = reader.GetInt64(2);
            }
            reader.Close();
            con.Close();
            return cust;
        }

        public DataSet GetCustomers()
        {
            string query = "select * from customer";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
    }
}
