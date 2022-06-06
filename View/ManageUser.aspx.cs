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
    public partial class ManageUser : System.Web.UI.Page
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
            List<User> users = UserController.select();
            UserView.DataSource = users;
            UserView.DataBind();
        }

        protected void UserView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = UserView.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text.ToString());
            UserController.delete(id);
            Response.Redirect("~/View/ManageUser.aspx");
        }

        protected void UserView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = UserView.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text.ToString());
            Response.Redirect("~/View/UpdateUser.aspx?id=" + id);
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passTxt.Text;

            UserController.register(username, password, password);
            Response.Redirect("~/View/ManageUser.aspx");
        }

        protected void manageProductBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageProduct.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/View/Login.aspx");
        }
    }
}