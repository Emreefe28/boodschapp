using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boodschapp
{
    public partial class Pay : Page
    {
        private void check_if_user_is_logged_in()
        {
            if (Session["user_email"] == null)
                Response.Redirect("login.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            check_if_user_is_logged_in();

            using (var context = new BoodschappContext())
            {
                var aankopen = context.Users.GroupJoin(context.Aankoops, user => user.id,
                    aankoop => aankoop.User_id,
                    (user, userAankoops) =>
                        new {UserId = user.id, Price = userAankoops.Sum(x => x.price), Email = user.email});
                var totalCosts = context.Aankoops.Sum(x => x.price);
                var amountOfUsers = context.Users.Count();
                var average = Convert.ToInt32(totalCosts) / amountOfUsers;

                var header = new TableHeaderRow();
                PaymentTable.Rows.Add(header);

                var nameHeader = new TableHeaderCell();
                nameHeader.Text = "Total costs";
                header.Cells.Add(nameHeader);

                var debtHeader = new TableHeaderCell();
                debtHeader.Text = "Debt";
                header.Cells.Add(debtHeader);

                var priceHeader = new TableHeaderCell();
                priceHeader.Text = "Email";
                header.Cells.Add(priceHeader);

                foreach (var aankoop in aankopen)
                {
                    var tRow = new TableRow();
                    PaymentTable.Rows.Add(tRow);

                    var totalCell = new TableCell();
                    totalCell.Text = aankoop.Price.ToString();
                    tRow.Cells.Add(totalCell);

                    var debtCell = new TableCell();
                    debtCell.Text = (aankoop.Price - average).ToString();
                    tRow.Cells.Add(debtCell);

                    var emailCell = new TableCell();
                    emailCell.Text = aankoop.Email;
                    tRow.Cells.Add(emailCell);
                    // TODO: Button Redirect to payment screen.
                    // pass userid of the session and userid of the receiver.
                }
            }
        }
    }
}