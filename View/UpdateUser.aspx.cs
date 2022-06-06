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
    public partial class UpdateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                User u = UserController.selectById(id);
                usernameTxt.Text = u.Username;
                passwordTxt.Text = u.Password;
                
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string pass = passwordTxt.Text;
            string username = usernameTxt.Text;
            int id = int.Parse(Request["id"]);
            UserController.update(id, username, pass);
            Response.Redirect("~/View/ManageUser.aspx");
        }
    }
}