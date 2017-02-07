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

            using (var context = new BoodschappContext())
            {
                try
                {
                    var aankopen = context.Aankoops.Include("User").ToList();
                    TableHeaderRow header = new TableHeaderRow();
                    ProductsTable.Rows.Add(header);
                    // Table headers
                    TableHeaderCell nameHeader = new TableHeaderCell();
                    nameHeader.Text = "Product name";
                    header.Cells.Add(nameHeader);

                    TableHeaderCell priceHeader = new TableHeaderCell();
                    priceHeader.Text = "Price";
                    header.Cells.Add(priceHeader);

                    TableHeaderCell emailHeader = new TableHeaderCell();
                    emailHeader.Text = "Email";
                    header.Cells.Add(emailHeader);

                    foreach (var aankoop in aankopen)
                    {
                        // For every product a new row being created
                        TableRow tRow = new TableRow();
                        ProductsTable.Rows.Add(tRow);

                        TableCell nameCell = new TableCell();
                        nameCell.Text = aankoop.product_name;
                        tRow.Cells.Add(nameCell);

                        TableCell priceCell = new TableCell();
                        priceCell.Text = aankoop.price;
                        tRow.Cells.Add(priceCell);

                        TableCell userCell = new TableCell();
                        userCell.Text = aankoop.User.email;
                        tRow.Cells.Add(userCell);
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