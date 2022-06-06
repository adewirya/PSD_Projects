using PSDProject.Controller;
using PSDProject.Model;
using System;

namespace PSDProject.View
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                Product p = ProductController.selectBasedOnId(id);
                nameTxt.Text = p.ProductName;
                descTxt.Text = p.ProductDescription;
                priceTxt.Text = "$" + p.ProductPrice.ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["id"]);
            string name = nameTxt.Text;
            int price = int.Parse(priceTxt.Text);
            string desc = descTxt.Text;

            ProductController.updateProduct(name, desc,price, id);
            Response.Redirect("~/View/Home.aspx");
        }
    }
}