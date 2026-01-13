using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Assignment
{
    public partial class Default : System.Web.UI.Page
    {
        Dictionary<string, (string ImageUrl, string Price)> products = new Dictionary<string, (string, string)>
        {
            { "Lipstick", ("https://tse2.mm.bing.net/th/id/OIP.VAAS22m_r8erDeDuCy_uTAHaFk?w=256&h=193&c=7&r=0&o=7&dpr=1.5&pid=1.7&rm=3", "₹500") },
            { "Foundation", ("https://tse1.mm.bing.net/th/id/OIP.eaaLoY6f82_cukSAtpFfXQHaHa?w=186&h=186&c=7&r=0&o=7&dpr=1.5&pid=1.7&rm=3", "₹1200") },
            { "Mascara", ("https://tse1.mm.bing.net/th/id/OIP.N4zgpoowNTATU7Vxm92tRgHaHa?w=129&h=180&c=7&r=0&o=7&dpr=1.5&pid=1.7&rm=3", "₹800") },
            { "Eyeliner", ("https://tse4.mm.bing.net/th/id/OIP.BlrDls-VqgfRS0FYa4woEwHaHa?w=118&h=180&c=7&r=0&o=7&dpr=1.5&pid=1.7&rm=3", "₹600") },
            { "Blush", ("https://tse1.mm.bing.net/th/id/OIP.O3OXyk_vW23DZDj_8HY5UQHaLH?w=127&h=190&c=7&r=0&o=7&dpr=1.5&pid=1.7&rm=3", "₹700") },
            { "Compact Powder", ("https://tse2.mm.bing.net/th/id/OIP.gY1dOJX6KwsZYsInrq-slwHaEo?w=271&h=180&c=7&r=0&o=7&dpr=1.5&pid=1.7&rm=3", "₹900") },
            { "Makeup Kit", ("https://tse3.mm.bing.net/th/id/OIP.jpK1gB5QQdthjdcQB9ExDQHaEK?w=331&h=186&c=7&r=0&o=7&dpr=1.5&pid=1.7&rm=3", "₹2500") }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                img_Product.ImageUrl = products["Lipstick"].ImageUrl;
            }
        }

        protected void ddl_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = ddl_Product.SelectedValue;
            img_Product.ImageUrl = products[selectedProduct].ImageUrl;
            lblPrice.Text = "";
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            string selectedProduct = ddl_Product.SelectedValue;
            lblPrice.Text = "Price: " + products[selectedProduct].Price;
        }
    }
}
