using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Johnson_W5Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool completed = true;
            Book book = new Book();

            book.Title = txtTitle.Text;
            book.AuthorFirst = txtAuthFirst.Text;
            book.AuthorLast = txtAuthLast.Text;
            book.Email = txtEmail.Text;
            book.DatePublished = dtPublished.Value;
            int tempPages;
            if(int.TryParse(txtPages.Text, out tempPages))
            {
                book.Pages = tempPages;
            }
            else
            {
                MessageBox.Show("Pages must be an integer", "ERROR");
                completed = false;
            }

            double tempPrice;
            if (double.TryParse(txtPrice.Text, out tempPrice))
            {
                book.Price = tempPrice;
            }
            else
            {
                MessageBox.Show("Price must be an number", "ERROR");
                completed = false;
            }

            if (completed)
            {
                Size = new Size(359, 359);
                lblOut.Text = "Book Entered:\nTitle: " + book.Title + "\nAuthor: " + book.AuthorFirst + book.AuthorLast + "\nEmail: " + book.Email + "\nDate Published: " + book.DatePublished.ToShortDateString() + "\nPages: " + book.Pages + "\nPrice: " + book.Price;
            }
        }
    }
}