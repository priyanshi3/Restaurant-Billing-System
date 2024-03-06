using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace restaurantClient
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            restaurantClient.ItemServiceReference.itemInterfaceClient items = new
                restaurantClient.ItemServiceReference.itemInterfaceClient("BasicHttpBinding_itemInterface");
            DataSet dsitem = items.GetItems();
            itemsList.DataSource = dsitem;
            itemsList.DataBind();
            items.Close();

        }

        protected void itemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtItemName.Text = itemsList.SelectedRow.Cells[2].Text;
            txtAmount.Text = itemsList.SelectedRow.Cells[3].Text;
            lblQuantity.Text = "1";
        }

        protected void btnDec_Click(object sender, EventArgs e)
        {
            int amt = int.Parse(lblQuantity.Text) - 1;
            if(amt <= 0)
            {
                lblQuantity.Enabled = false;
            }
            else
            {
                lblQuantity.Text = amt.ToString();
                txtAmount.Text = (int.Parse(txtAmount.Text) - int.Parse(itemsList.SelectedRow.Cells[3].Text)).ToString();
            }
        }

        protected void btnInc_Click(object sender, EventArgs e)
        {
            int amt = int.Parse(lblQuantity.Text) + 1;
            lblQuantity.Text = amt.ToString();
            txtAmount.Text = (int.Parse(txtAmount.Text) + int.Parse(itemsList.SelectedRow.Cells[3].Text)).ToString();
        }

        protected void btnAddToBill_Click(object sender, EventArgs e)
        {
            String item = txtItemName.Text + "-" + lblQuantity.Text + "-" + txtAmount.Text;
            lbBillItems.Items.Add(item);
        }

        protected void btnGenerateBill_Click(object sender, EventArgs e)
        {
            restaurantClient.CustomerServiceReference.customerInterfaceClient cust = new
                restaurantClient.CustomerServiceReference.customerInterfaceClient("BasicHttpBinding_customerInterface");
            restaurantClient.CustomerServiceReference.Customer customer = 
                cust.GetCustByPhn(long.Parse(txtcust.Text));

            if (customer != null)
            {
                int total_amount = 0;
                string total_items = "";
                foreach (ListItem item in lbBillItems.Items)
                {
                    string[] data = item.Text.Split('-');
                    for (int i = 0; i<data.Length-1; i++)
                    {
                        total_items = total_items + data[i] + "  ";
                    }
                    
                    total_items = total_items + ", ";
                    total_amount = total_amount + int.Parse(item.Text.Split('-').Last());
                }
                lblBill.Text = "Total Amount to pay = " + total_amount.ToString();

                restaurantClient.BillServiceReference.billInterfaceClient bill = new
                    restaurantClient.BillServiceReference.billInterfaceClient("BasicHttpBinding_billInterface");
                bill.AddBill(customer.CustId, total_items, total_amount, DateTime.Now);
                bill.Close();
                txtAmount.Text = "";
                txtcust.Text = "";
                txtItemName.Text = "";
                lblQuantity.Text = "0";
                lbBillItems.Items.Clear();
            }
            
        }
    }
}