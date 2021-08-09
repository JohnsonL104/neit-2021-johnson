using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
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

            string strEBookID = "";
            int intEBookID = 0;

            if((!IsPostBack) && Request.QueryString["EBookID"] != null)
            {
                btnDone.Visible = false;
                btnDone.Enabled = false;
                strEBookID = Request.QueryString["EBookID"].ToString();
                lblID.Text = strEBookID;
                intEBookID = Convert.ToInt32(strEBookID);

                EBook ebook = new EBook();
                SqlDataReader dr = ebook.GetRecordsFromDBByID(intEBookID);

                while (dr.Read())
                {
                    txtTitle.Text = dr["Title"].ToString();
                    txtFName.Text = dr["AuthorFirst"].ToString();
                    txtLName.Text = dr["AuthorLast"].ToString();
                    txtEmail.Text = dr["AuthorEmail"].ToString();
                    txtPages.Text = dr["Pages"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                    txtBookmark.Text = dr["BookmarkPage"].ToString();
                    calDate.VisibleDate = DateTime.Parse(dr["DatePublished"].ToString());
                    calDate.SelectedDate = calDate.VisibleDate;
                    calDateExpires.VisibleDate = DateTime.Parse(dr["DateRentalExpires"].ToString());
                    calDateExpires.SelectedDate = calDateExpires.VisibleDate;
                }
            }
            else
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            EBook book = new EBook();


            book.EBookID = Int32.Parse(lblID.Text);
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
                String result = book.UpdateRecord();
                lblFeedback.Text = result;
            }
            else
            {

                lblFeedback.Text = book.Feedback;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            EBook ebook = new EBook();
            ebook.EBookID = Int32.Parse(lblID.Text);
            lblFeedback.Text = ebook.DeleteRecord();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Backend/ControlPanel.aspx");
        }
    }
}