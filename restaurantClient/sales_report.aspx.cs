using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace restaurantClient
{
    public partial class sales_report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            restaurantClient.BillServiceReference.billInterfaceClient billData = new
                restaurantClient.BillServiceReference.billInterfaceClient("BasicHttpBinding_billInterface");
            DataSet bill = billData.GetBills();
            gvBillData.DataSource = bill;
            gvBillData.DataBind();
            billData.Close();
        }
    }
}