using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CommonClass.App_Code;

namespace JohnsonL_Activity2.Backend
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] == null || Session["loggedIn"].ToString() == "false")
            {
                Response.Redirect("~/Backend/default.aspx");
            }
        }

        protected void doneBtnClick(object sender, EventArgs e)
        {
            EBook book = new EBook();

            

            book.Title = txtTitle.Text;
            book.AuthorFirst = txtFName.Text;
            book.AuthorLast = txtLName.Text;
            book.Email = txtEmail.Text;


            int tempInt;
            Double tempDoub;
            if (Int32.TryParse(txtPages.Text, out tempInt))
            {
                book.Pages = tempInt;
            }
            else
            {
                book.Feedback = book.Feedback + "\nERROR: Pages Must be Number";
            }

            int tempInt2;
            if (Int32.TryParse(txtBookmark.Text, out tempInt2))
            {
                book.Pages = tempInt2;
            }
            else
            {
                book.Feedback = book.Feedback + "\nERROR: Pages Must be Number";
            }

            book.DatePublished = calDate.SelectedDate;
            book.DateRentalExpires = calDateExpires.SelectedDate;
            if (Double.TryParse(txtPrice.Text, out tempDoub))
            {
                book.Price = tempDoub;
            }
            else
            {
                book.Feedback = book.Feedback + "\nERROR: Price Must be Number";
            }


            if (!book.Feedback.Contains("ERROR:"))
            {
                String result = book.AddRecordToDB();
                lblFeedback.Text = result;
            }
            else
            {

                lblFeedback.Text = book.Feedback;
            }
        }
    }
}