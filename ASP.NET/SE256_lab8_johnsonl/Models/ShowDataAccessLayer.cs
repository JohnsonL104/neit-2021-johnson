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
    public class ShowDataAccessLayer
    {
        string connectionString;

        private readonly IConfiguration _configuration;

        public ShowDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(Show show)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT Into Shows (Title, Description, ReleaseDate, EndDate, EpisodeCount) VALUES (@Title, @Description, @ReleaseDate, @EndDate, @EpisodeCount);";

                show.Feedback = "";

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue(("@Title"), show.Title);
                        command.Parameters.AddWithValue(("@Description"), show.Description);
                        command.Parameters.AddWithValue(("@ReleaseDate"), show.ReleaseDate);
                        command.Parameters.AddWithValue(("@EndDate"), show.EndDate);
                        command.Parameters.AddWithValue(("@EpisodeCount"), show.EpisodeCount);

                        connection.Open();

                        show.Feedback = command.ExecuteNonQuery().ToString() + " Recored Added";

                        connection.Close();

                    }
                }
                catch(Exception err)
                {
                    show.Feedback = "Error: " + err.Message;
                }
            }
        }

        public IEnumerable<Show> GetActiveRecords()
        {
            List<Show> lst = new List<Show>();
            Show show = new Show();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSql = "SELECT * FROM Shows;";
                    SqlCommand cmd = new SqlCommand(strSql, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        show = new Show();
                        show.ShowID = Convert.ToInt32(rdr["ShowID"].ToString());
                        show.Title = rdr["Title"].ToString();
                        show.ReleaseDate = DateTime.Parse(rdr["ReleaseDate"].ToString());
                        if(rdr["EndDate"].ToString() != "")
                        {
                            show.EndDate = DateTime.Parse(rdr["EndDate"].ToString());
                        }
                        show.EpisodeCount = Convert.ToInt32(rdr["EpisodeCount"].ToString());
                        

                        lst.Add(show);
                    }
                    con.Close();
                }

            }
            catch(Exception err)
            {
                show.Feedback = err.Message;
                lst.Add(show);
            }
            return lst;
        }
        public Show DeleteShow(int? id)
        {
            Show show = new Show();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSQL = "DELETE FROM Shows WHERE ShowID = @ShowID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ShowID", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                }
            }
            catch (Exception err)
            {
                show.Feedback = "ERROR: " + err.Message;

            }
            return show;
        }
        public Show GetOneRecord(int? id)
        {
            Show show = new Show();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSql = "SELECT * FROM Shows WHERE ShowID = @ShowID";
                    SqlCommand cmd = new SqlCommand(strSql, con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ShowID", id);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();



                    while (rdr.Read())
                    {
                        show = new Show();
                        show.ShowID = Convert.ToInt32(rdr["ShowID"].ToString());
                        show.Title = rdr["Title"].ToString();
                        show.Description = rdr["Description"].ToString();
                        show.ReleaseDate = DateTime.Parse(rdr["ReleaseDate"].ToString());
                        if (rdr["EndDate"].ToString() != "")
                        {
                            show.EndDate = DateTime.Parse(rdr["EndDate"].ToString());
                        }
                        show.EpisodeCount = Convert.ToInt32(rdr["EpisodeCount"].ToString());

                    }
                    con.Close();
                }

            }
            catch (Exception err)
            {
                show.Feedback = err.Message;
            }
            return show;
        }

        public void UpdateShow(Show show)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSql;
                    SqlCommand cmd = new SqlCommand();
                   
                    strSql = "UPDATE Shows SET  Title = @Title, Description = @Description, ReleaseDate = @ReleaseDate, EndDate = @EndDate, EpisodeCount = @EpisodeCount WHERE ShowID = @ShowID;";
                    

                    cmd.CommandText = strSql;
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;


                    cmd.Parameters.AddWithValue(("@Title"), show.Title);
                    cmd.Parameters.AddWithValue(("@Description"), show.Description);
                    cmd.Parameters.AddWithValue(("@ReleaseDate"), show.ReleaseDate);
                    cmd.Parameters.AddWithValue(("@EndDate"), show.EndDate);
                    cmd.Parameters.AddWithValue(("@EpisodeCount"), show.EpisodeCount);
                    cmd.Parameters.AddWithValue(("@ShowID"), show.ShowID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception err)
            {
                show.Feedback = "ERROR: " + err.Message;
            }
        }

    }
}
