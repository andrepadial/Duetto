using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleAcademia
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect(FormsAuthentication.DefaultUrl);
            }
        }


        protected void ValidateUser(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            
            if (username.ToUpper() == "DUETOADM" && password.ToUpper() == "DUETOP2020")
            {
                dvMessage.Visible = false;
                //FormsAuthentication.SetAuthCookie(username, chkRememberMe.Checked);
                Response.Redirect(FormsAuthentication.DefaultUrl);
            }
            else
            {
                dvMessage.Visible = true;
                lblMessage.Text = "Login e/ou senha incorretos";
            }
        }
    }
}