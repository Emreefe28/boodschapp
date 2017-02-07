using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boodschapp
{
    public partial class Overview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_email"] != null)
            {
                lblName.Text = "Welcome, " + Session["user_email"].ToString();
            }
            else
            {
                lblName.Text = "";
            }
        }
    }
}