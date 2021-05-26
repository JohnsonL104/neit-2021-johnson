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
        private int ebookID;

        public int EBookID
        {
            get
            {
                return ebookID;
            }
            set
            {
                ebookID = value;
            }


        }

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

            SqlConnection conn = new SqlConnection(@GetConnection());


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

        public String UpdateRecord()
        {
            string result = "";

            SqlConnection conn = new SqlConnection(GetConnection());


            SqlCommand comm = new SqlCommand("UPDATE EBooks SET Title = @Title, AuthorFirst = @AuthorFirst, AuthorLast = @AuthorLast, AuthorEmail = @AuthorEmail, Pages = @Pages, DatePublished = @DatePublished, dateRentalExpires = @dateRentalExpires, Price = @Price, BookmarkPage = @BookmarkPage WHERE EBookID = @EBookID");
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
            comm.Parameters.AddWithValue("@EBookID", EBookID);

            try
            {
                conn.Open();
                int resultInt = comm.ExecuteNonQuery();
                result = $"SUCCESS: Updated {resultInt} records";

                conn.Close();
            }
            catch (Exception err)
            {

                result = "ERROR:" + err.Message + "\n" + comm.CommandText;
            }
            return result;
        }

        public String DeleteRecord()
        {
            string result = "";

            SqlConnection conn = new SqlConnection(@GetConnection());

            SqlCommand comm = new SqlCommand("DELETE FROM EBooks WHERE EBookID = @EBookID");
            comm.Connection = conn;


           
            comm.Parameters.AddWithValue("@EBookID", EBookID);

            try
            {
                conn.Open();
                int resultInt = comm.ExecuteNonQuery();
                result = $"SUCCESS: Updated {resultInt} records";

                conn.Close();
            }
            catch (Exception err)
            {

                result = "ERROR:" + err.Message;
            }
            return result;
        }

        public DataSet GetRecordsFromDB(String title, String last)
        {
            DataSet ds = new DataSet();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @GetConnection();

            String commStr = "SELECT EBookID, Title, AuthorFirst, AuthorLast FROM EBooks WHERE 0=0";
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;

            if(title.Length > 0)
            {
                commStr += " AND Title LIKE @Title";
                comm.Parameters.AddWithValue("@Title", "%" + title + "%");
            }
            if (last.Length > 0)
            {
                commStr += " AND Title LIKE @AuthorLast";
                comm.Parameters.AddWithValue("@AuthorLast", "%" + last + "%");
            }

            comm.CommandText = commStr;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            conn.Open();
            da.Fill(ds, "EBooks");
            conn.Close();



            return ds;
            
        }

        public SqlDataReader GetRecordsFromDBByID(int ebookID)
        {
            DataSet ds = new DataSet();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @GetConnection();

            String commStr = "SELECT * FROM EBooks WHERE EBookID = @EBookID";
            SqlCommand comm = new SqlCommand();

            comm.CommandText = commStr;
            comm.Parameters.AddWithValue("@EBookID", ebookID);
            comm.Connection = conn;

            

            comm.CommandText = commStr;

            conn.Open();
            return comm.ExecuteReader();

        }



        public String GetConnection()
        {
            return @"Server = sql.neit.edu\studentsqlserver, 4500; Database = SE245_LJohnson; User Id = SE245_LJohnson; Password = 008009764; ";

        }

        public EBook(): base()
        {
            bookmarkPage = 1;
            dateRentalExpires = DateTime.Now.AddDays(14);
        }
    }
}
