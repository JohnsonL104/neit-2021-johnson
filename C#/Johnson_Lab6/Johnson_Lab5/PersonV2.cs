using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CommonClass
{
    class PersonV2:Person
    {
        private String cellPhone;
        private String instagramURL;
        
        public String CellPhone
        {
            get
            {
                return cellPhone;
            }
            set
            {
                if (Validation.ValidatePhone(value))
                {

                    cellPhone = value;
                }
                else
                {
                    feedback += "ERROR: Invalid Cellphone\n";
                }
            }
        }
        public String InstagramURL
        {
            get
            {
                return instagramURL;
            }
            set
            {
                if (Validation.ValidateInstagramURL(value))
                {
                    instagramURL = value;
                }
                else
                {
                    feedback += "ERROR: Invalid Instagram URL\n";
                }
            }
        }
        public String AddRecordToDB()
        {
            string result = "";

            SqlConnection conn = new SqlConnection(@"Server = sql.neit.edu\sqlstudentserver, 4500; Database = SE245_LJohnson; User Id = SE245_LJohnson; Password = 008009764; ");


            SqlCommand comm = new SqlCommand("INSERT INTO PersonV2 (FirstName, MiddleName, LastName, Street1, Street2, City, State, Zip, Phone, CellPhone, InstagramURL, Email) VALUES (@FirstName, @MiddleName, @LastName, @Street1, @Street2, @City, @State, @Zip, @Phone, @CellPhone, @InstagramURL, @Email)");
            comm.Connection = conn;


            comm.Parameters.AddWithValue("@FirstName", FirstName);
            comm.Parameters.AddWithValue("@MiddleName", MiddleName);
            comm.Parameters.AddWithValue("@LastName", LastName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@CellPhone", CellPhone);
            comm.Parameters.AddWithValue("@InstagramURL", InstagramURL);
            comm.Parameters.AddWithValue("@Email", Email);



            try
            {
                conn.Open();
                int resultInt = comm.ExecuteNonQuery();
                result = $"SUCCESS: Returned {resultInt} records";

                conn.Close();
            }
            catch (Exception err)
            {
                result = "ERROR:" + err.Message;
            }
            return result;
        }
    }
}
