using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boodschapp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new BoodschappContext())
            {
                try
                {
                    var password = txtPass.Text;
                    // Check if the user details are correct
                    var user = context.Users.Where(u => u.email == txtEmail.Text && u.password == password).FirstOrDefault();
                    if (user != null)
                    {
                        Session["user_email"] = user.email;
                        Response.Redirect("Overview.aspx");
                    }
                    else
                    {
                        lblError.Text = "Email or password is wrong!";
                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}