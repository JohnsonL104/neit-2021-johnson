using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CommonClass

{
    class EBook : Book
    {
        private DateTime dateRentalExpires;
        private int bookmarkPage;

        public DateTime DateRentalExpires
        {
            get
            {
                return dateRentalExpires;
            }
            set
            {
                if (Validation.IsFutureDate(value))
                {
                    dateRentalExpires = value;
                }
                else
                {
                    feedback += "\nERROR: you must enter future dates";
                }
            }
        }

        public int BookmarkPage
        {
            get
            {
                return bookmarkPage;
            }
            set
            {
                if(value > 0 && value <= Pages)
                {
                    bookmarkPage = value;
                }
                else
                {
                    feedback += "\nERROR: Sorry you entered an invalid bookmark page number, Must be greater than 0 and less than the pages of the book";
                }
            }
        }
        


        public String AddRecordToDB()
        {
            string result = "";

            SqlConnection conn = new SqlConnection(@"Server = sql.neit.edu\sqlstudentserver, 4500; Database = SE245_LJohnson; User Id = SE245_LJohnson; Password = 008009764; ");


            SqlCommand comm = new SqlCommand("INSERT INTO EBooks (Title, AuthorFirst, AuthorLast, AuthorEmail, Pages, DatePublished, dateRentalExpires, Price, BookmarkPage) VALUES (@Title, @AuthorFirst, @AuthorLast, @AuthorEmail, @Pages, @DatePublished, @dateRentalExpires, @Price, @BookmarkPage)");
            comm.Connection = conn;


            comm.Parameters.AddWithValue("@Title", Title);
            comm.Parameters.AddWithValue("@AuthorFirst", AuthorFirst);
            comm.Parameters.AddWithValue("@AuthorLast", AuthorLast);
            comm.Parameters.AddWithValue("@AuthorEmail", Email);
            comm.Parameters.AddWithValue("@Pages", Pages);
            comm.Parameters.AddWithValue("@DatePublished", DatePublished);
            comm.Parameters.AddWithValue("@dateRentalExpires", DateRentalExpires);
            comm.Parameters.AddWithValue("@Price", Price);
            comm.Parameters.AddWithValue("@BookmarkPage", BookmarkPage);


            try
            {
                conn.Open();
                int resultInt = comm.ExecuteNonQuery();
                result = $"SUCCESS: Returned {resultInt} records";

                conn.Close();
            }
            catch(Exception err)
            {
                result = "ERROR:" + err.Message;
            }
            return result;
        }




        public EBook(): base()
        {
            bookmarkPage = 1;
            dateRentalExpires = DateTime.Now.AddDays(14);
        }
    }
}
