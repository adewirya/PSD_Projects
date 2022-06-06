using PSDProject.Controller;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace PSDProject.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User) Session["user"];
            Boolean isAdmin = (u.Username == "nikoAdmin" && u.Password == "nikoAdmin");
            if (u == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            else if (isAdmin)
            {
                Response.Redirect("~/View/ManageProduct.aspx");
            }

            List<Product> products = ProductController.select();
            ProductView.DataSource = products;
            ProductView.DataBind();
        }


        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/View/Login.aspx");
        }

        protected void addCartBtn_Click(object sender, EventArgs e)
        {
            int prodId = int.Parse(productIdTxt.Text);
            User u = (User)Session["user"];
            int id = (int)u.UserId;
            int quantity = int.Parse(quantityTxt.Text);

            CartController.addToCart(id, prodId, quantity);
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageCart.aspx");
        }
    }
}