using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boodschapp
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user_id"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new BoodschappContext())
            {
                try
                {
                    var aankoop = new Aankoop();
                    aankoop.product_name = txtName.Text;
                    aankoop.price = txtPrice.Text;
                    aankoop.User_id = Convert.ToInt32(Session["user_id"]);
                    aankoop.created_at = String.Format("{0}", DateTime.Now);
                    aankoop.updated_at = String.Format("{0}", DateTime.Now);
                    context.Aankoops.Add(aankoop);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}