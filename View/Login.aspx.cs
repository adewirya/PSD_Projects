using PSDProject.Controller;
using PSDProject.Model;
using System;

namespace PSDProject.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
            
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string user = userTxt.Text;
            string pass = passTxt.Text;
            User u = UserController.login(user, pass);

            if (u == null)
            {
                errLbl.Text = "Username / Password is Wrong";
                return;
            }

            Session["user"] = u;
            Response.Redirect("~/View/Home.aspx");
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Register.aspx");
        }
    }
}