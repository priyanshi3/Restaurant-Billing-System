using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemService
{
    public class itemService : itemInterface
    {
        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-BVM550KD\\SQLEXPRESS01;Initial Catalog=restaurant;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public void AddItem(string item_name, int item_price)
        {
            string query = "insert into items(item_name, item_price) values('" + item_name + "', " + item_price + ")";
            cmd.Connection = con;
            cmd.CommandText = query;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet GetItems()
        {
            string query = "select * from items";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public void UpdateItem(int item_id, int item_price)
        {
            string query = "update items set item_price=" + item_price + " where item_no=" + item_id;
            cmd.Connection = con;
            cmd.CommandText = query;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
