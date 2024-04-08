using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace restaurantClient
{
    public partial class items : System.Web.UI.Page
    {
        public int itemId;
        protected void Page_Load(object sender, EventArgs e)
        {
            showGridData();
            if (rblAction.Text == "Insert")
            {
                gvItemsData.Visible = false;
                btnAdd.Text = "Add";
            }
            else
            {
                gvItemsData.Visible = true;
                btnAdd.Text = "Update";
            }
        }

        protected void showGridData()
        {
            restaurantClient.ItemServiceReference.itemInterfaceClient items = new
                restaurantClient.ItemServiceReference.itemInterfaceClient("BasicHttpBinding_itemInterface");
            DataSet dsitem = items.GetItems();
            gvItemsData.DataSource = dsitem;
            gvItemsData.DataBind();
            items.Close();
        }
        protected void rblAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rblAction.Text == "Insert")
            {
                gvItemsData.Visible = false;
                btnAdd.Text = "Add";
                txtItemName.Text = "";
                txtItemPrice.Text = "";
            }
            else
            {
                gvItemsData.Visible = true;
                btnAdd.Text = "Update";
                txtItemName.Text = "";
                txtItemPrice.Text = "";
            }
        }
        
        protected void gvItemsData_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemId = int.Parse(gvItemsData.SelectedRow.Cells[1].Text);
            txtItemName.Text = gvItemsData.SelectedRow.Cells[2].Text;
            txtItemPrice.Text = gvItemsData.SelectedRow.Cells[3].Text;
            txtItemName.ReadOnly = true;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if(rblAction.Text == "Insert")
            {
                restaurantClient.ItemServiceReference.itemInterfaceClient addItem = new
                    restaurantClient.ItemServiceReference.itemInterfaceClient("BasicHttpBinding_itemInterface");
                addItem.AddItem(txtItemName.Text, int.Parse(txtItemPrice.Text));
                addItem.Close();
                lblMessage.Text = "Data Insert Successfully";
            }
            else
            {
                restaurantClient.ItemServiceReference.itemInterfaceClient updateItem = new
                    restaurantClient.ItemServiceReference.itemInterfaceClient("BasicHttpBinding_itemInterface");
                updateItem.UpdateItem(int.Parse(gvItemsData.SelectedRow.Cells[1].Text), int.Parse(txtItemPrice.Text));
                updateItem.Close();
                showGridData();
                lblMessage.Text = "Data Updated Successfully";
            }
            /*txtItemName.Text = "";
            txtItemPrice.Text = "";*/
        }
    }
}