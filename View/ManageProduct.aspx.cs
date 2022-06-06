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
    public partial class ManageProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["user"];
            Boolean isAdmin = (u.Username == "nikoAdmin" && u.Password == "nikoAdmin");

            if (u == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            else if (!isAdmin)
            {
                Response.Redirect("~/View/Home.aspx");
            }
            
            List<Product> products = ProductController.select();
            ProductView.DataSource = products;
            ProductView.DataBind();
        }

        protected void ProductView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = ProductView.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text.ToString());
            Response.Redirect("~/View/Update.aspx?id=" + id);
        }

        protected void ProductView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = ProductView.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text.ToString());
            ProductController.deleteProduct(id);
            Response.Redirect("~/View/ManageProduct.aspx");
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            int price = int.Parse(priceTxt.Text);
            string desc = descTxt.Text;

            ProductController.insertProduct(name, desc, price);
            Response.Redirect("~/View/ManageProduct.aspx");
        }

        protected void logoutBtn_Click1(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/View/Login.aspx");
        }

        protected void manageUserBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageUser.aspx");
        }
    }
}