using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace restaurantClient
{
    public partial class customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            restaurantClient.CustomerServiceReference.customerInterfaceClient addCust = new
                restaurantClient.CustomerServiceReference.customerInterfaceClient("BasicHttpBinding_customerInterface");
            addCust.AddCustomer(txtCustName.Text, long.Parse(txtCustPhnNo.Text));
            addCust.Close();
            lblMessage.Text = "Customer added successfully";
            /*txtCustName.Text = "";
            txtCustPhnNo.Text = "";*/
        }
    }
}