using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ElectricityBillingAutomation.BusinessLogic;
using ElectricityBillingAutomation.Models;


namespace ElectricityBillingAutomation
{
    public partial class ViewBills : System.Web.UI.Page
    {
        protected void btnView_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            ElectricityBoard board = new ElectricityBoard();
            var bills = board.Generate_N_BillDetails(n);
            gvBills.DataSource = bills;
            gvBills.DataBind();
        }

    }
}