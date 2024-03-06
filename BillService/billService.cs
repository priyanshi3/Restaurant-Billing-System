using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillService
{
    public class billService : billInterface
    {
        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-BVM550KD\\SQLEXPRESS01;Initial Catalog=restaurant;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public void AddBill(int cust_id, string items, int amount, DateTime date)
        {
            string query = "insert into bill(cust_id, items, amount, date) values(@cust_id, @item, @amount, @date)";
            SqlParameter custid, itm, amt, dt;
            custid = new SqlParameter("@cust_id", cust_id);
            cmd.Parameters.Add(custid);
            itm = new SqlParameter("@item", items);
            cmd.Parameters.Add(itm);
            amt = new SqlParameter("@amount", amount);
            cmd.Parameters.Add(amt);
            dt = new SqlParameter("@date", date);
            cmd.Parameters.Add(dt);
            cmd.Connection = con;
            cmd.CommandText = query;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet GetBills()
        {
            string query = "select * from bill";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
    }
}
