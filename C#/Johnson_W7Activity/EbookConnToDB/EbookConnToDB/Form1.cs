using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonClass;

namespace EbookConnToDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EBook ebook = new EBook();

            ebook.Title = txtTitle.Text;
            ebook.AuthorFirst = txtAuthorFirst.Text;
            ebook.AuthorLast = txtAuthorLast.Text;
            ebook.Email = txtEmail.Text;
            // have to put in most current validation and plan to add in thing to check if everything in the string is a number but i want to make sure it is in the most recent validation library and then i basicially just have to test the connection to the db and make sure i can then also insert but i think that is all good also have to make sure a bunch of the book things are being validated and fix some of the validation from last lab becuase it wasn't working like i thought it was just go and check the png from the feedback from that lab
            
            
            int tempInt;
            Double tempDoub;
            if(Int32.TryParse(txtPages.Text, out tempInt))
            {
                ebook.Pages = tempInt;
            }
            else
            {
                ebook.Feedback = ebook.Feedback + "\nERROR: Pages Must be Number";
            }


            ebook.DatePublished = dateTimePicker1.Value;
            ebook.DateRentalExpires = dateTimePicker2.Value;

            if (Double.TryParse(txtPrice.Text, out tempDoub))
            {
                ebook.Price = tempDoub;
            }
            else
            {
                ebook.Feedback = ebook.Feedback + "\nERROR: Price Must be Number";
            }
            if(Int32.TryParse(txtBookmarkPage.Text, out tempInt))
            {
                ebook.BookmarkPage = tempInt;
            }
            else
            {
                ebook.Feedback = ebook.Feedback + "\nERROR: Bookmark Page Must be Number";
            }


            if (!ebook.Feedback.Contains("ERROR:"))
            {
                String result = ebook.AddRecordToDB();
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show(ebook.Feedback);
            }

        }
    }
}
