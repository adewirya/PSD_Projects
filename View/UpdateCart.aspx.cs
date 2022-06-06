using PSDProject    .Controller;
using PSDProject.Model;
using System;

namespace PSDProject.View
{
    public partial class UpdateCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                Cart c = CartController.selectById(id);
                qtyTxt.Text = c.Quantity.ToString();
                int prodId = c.ProductId;
                Product p = ProductController.selectBasedOnId(prodId);
                prodLbl.Text = p.ProductName;
                descLbl.Text = p.ProductDescription;
                priceLbl.Text = p.ProductPrice.ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["id"]);
            int qty = int.Parse(qtyTxt.Text);

            CartController.updateCart(id, qty);
            Response.Redirect("~/View/ManageCart.aspx");
        }
    }
}