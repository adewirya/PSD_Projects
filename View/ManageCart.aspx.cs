using PSDProject.Controller;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.View
{
    public partial class ManageCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["user"];
            if (u == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            int id = (int)u.UserId;

            List<Cart> carts = CartController.select(id);
            CartView.DataSource = carts;
            CartView.DataBind();
        }

        protected void CartView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = CartView.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text.ToString());
            Response.Redirect("~/View/UpdateCart.aspx?id=" + id);
        }

        protected void CartView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            User u = (User)Session["user"];
            int uId = (int)u.UserId;
            GridViewRow row = CartView.Rows[e.RowIndex];
            int prodId = int.Parse(row.Cells[1].Text.ToString());
            CartController.deleteCart(uId, prodId);
            Response.Redirect("~/View/ManageCart.aspx");
        }

        protected void checkOutBtn_Click(object sender, EventArgs e)
        {
            User u = (User)Session["user"];
            int id = (int)u.UserId;

            List<Cart> carts = CartController.select(id);
            TransactionController.newTransaction(id, carts);
            CartController.clearCart(id);
            Response.Redirect("~/View/ManageCart.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/View/Login.aspx");
        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home.aspx");
        }
    }
}