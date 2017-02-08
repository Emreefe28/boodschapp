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
            if (Session["user_id"] == null)
            {
                Response.Redirect("login.aspx");
            }

            using (var context = new BoodschappContext())
            {
                try
                {
                    TableHeaderRow header = new TableHeaderRow();
                    ProductsTable.Rows.Add(header);
                    TableHeaderCell nameHeader = new TableHeaderCell();
                    nameHeader.Text = "Product name";
                    header.Cells.Add(nameHeader);

                    TableHeaderCell priceHeader = new TableHeaderCell();
                    priceHeader.Text = "Price";
                    header.Cells.Add(priceHeader);
                    int user_id = Convert.ToInt32(Session["user_id"]);
                    var aankopen = context.Aankoops.Where(x => x.User_id == user_id).ToList();
                    foreach (var aankoop in aankopen)
                    {
                        TableRow tRow = new TableRow();
                        ProductsTable.Rows.Add(tRow);

                        TableCell nameCell = new TableCell();
                        nameCell.Text = aankoop.product_name;
                        tRow.Cells.Add(nameCell);

                        TableCell priceCell = new TableCell();
                        priceCell.Text = aankoop.price.ToString();
                        tRow.Cells.Add(priceCell);

                        TableCell buttonCell = new TableCell();
                        Button ButtonDelete = new Button();
                        ButtonDelete.Text = "Delete";
                        ButtonDelete.CommandArgument = aankoop.id.ToString();
                        ButtonDelete.ControlStyle.CssClass = "btn btn-primary";
                        ButtonDelete.Click += new EventHandler(delete_product);
                        buttonCell.Controls.Add(ButtonDelete);
                        tRow.Cells.Add(buttonCell);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
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
                    aankoop.price = Convert.ToDouble(txtPrice.Text);
                    aankoop.User_id = Convert.ToInt32(Session["user_id"]);

                    // Normaal is dit al automatisch in de model
                    aankoop.created_at = String.Format("{0}", DateTime.Now);
                    aankoop.updated_at = String.Format("{0}", DateTime.Now);

                    context.Aankoops.Add(aankoop);
                    context.SaveChanges();
                    Response.Redirect("Products.aspx");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        protected void delete_product(object sender, EventArgs e)
        {
            Button ButtonDelete = (Button) sender;
            int rowId = Convert.ToInt32(ButtonDelete.CommandArgument);
            using (var context = new BoodschappContext())
            {
                try
                {
                    var productToRemove = context.Aankoops.SingleOrDefault(a => a.id == rowId);
                    context.Aankoops.Remove(productToRemove);
                    context.SaveChanges();
                    Response.Redirect("Products.aspx");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}