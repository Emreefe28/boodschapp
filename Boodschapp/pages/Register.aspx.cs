using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boodschapp.Pages
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            using (var context = new BoodschappContext())
            {
                try
                {
                    var user = new User();
                    // Check if email already exists
                    if (context.Users.Any(a => a.email == txtEmail.Text))
                    {
                        lblError.Text = "Email already exists!";
                    }
                    else
                    {
                        user.name = txtName.Text;
                        user.surname = txtSurname.Text;
                        user.email = txtEmail.Text;
                        user.password = txtPassword.Text;
                        user.bank_nr = txtBanknr.Text;
                        user.created_at = String.Format("{0}", DateTime.Now);
                        context.Users.Add(user);
                        context.SaveChanges();
                        lblError.Text = "Successfully registered";
                    }
          
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }
    }
}
    