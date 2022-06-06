using PSDProject.Controller;
using PSDProject.Model;
using System;

namespace PSDProject.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string name = usernameTxt.Text;
            string pass = passTxt.Text;
            string conf = confPassTxt.Text;
            string msg = UserController.register(name, pass, conf);
            errorLbl.Text = msg;
            if (msg.Equals(""))
            {
                User u = UserController.login(name, pass);
                Session["user"] = u;
                Response.Redirect("~/View/Home.aspx");
            }
        }
    }
}