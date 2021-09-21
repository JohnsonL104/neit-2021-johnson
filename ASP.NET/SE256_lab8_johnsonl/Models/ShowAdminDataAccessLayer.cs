using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;

using SE256_lab5_johnsonl.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_lab5_johnsonl.Models
{
    public class ShowAdminDataAccessLayer
    {
        string connectionString;

        private readonly IConfiguration _configuration;

        public ShowAdminDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<ShowAdmin> GetAdminLogin(ShowAdmin admin)
        {
            List<ShowAdmin> lstShowAdmin = new List<ShowAdmin>();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSql = "SELECT TOP 1 * FROM ShowAdminRegistry WHERE ShowAdminEmail = @ShowAdminEmail AND ShowAdminPW = @ShowAdminPW";
                    SqlCommand cmd = new SqlCommand(strSql, con);
                    cmd.CommandType = CommandType.Text;


                    cmd.Parameters.AddWithValue("@ShowAdminEmail", admin.ShowAdminEmail);
                    cmd.Parameters.AddWithValue("@ShowAdminPW", admin.ShowAdminPW);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        admin = new ShowAdmin();
                        admin.ShowAdminID = Convert.ToInt32(rdr["ShowAdminID"].ToString());
                        admin.ShowAdminEmail = rdr["ShowAdminEmail"].ToString();
                        admin.ShowAdminPW = rdr["ShowAdminPW"].ToString();
                        

                        lstShowAdmin.Add(admin);
                    }
                    con.Close();
                }

            }
            catch (Exception err)
            {
                
            }
            return lstShowAdmin;
        }
    }
}
