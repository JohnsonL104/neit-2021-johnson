using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;

using Activity5.Models;

using Microsoft.Extensions.Configuration;

namespace Activity5.Models
{
    public class TroubleTicketDataAccessLayer
    {
        string connectionString;

        private readonly IConfiguration _configuration;

        public TroubleTicketDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(TroubleTicketModel ticket)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT Into TroubleTickets (Ticket_Title, Ticket_Desc, Category, Reporting_Email, Orig_Date) VALUES (@Ticket_Title, @Ticket_Desc, @Category, @Reporting_Email, @Orig_Date);";

                ticket.Feedback = "";

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;

                        command.Parameters.AddWithValue(("@Ticket_Title"), ticket.TicketTitle);
                        command.Parameters.AddWithValue(("@Ticket_Desc"), ticket.TicketDesc);
                        command.Parameters.AddWithValue(("@Category"), ticket.Category);
                        command.Parameters.AddWithValue(("@Reporting_Email"), ticket.ReportingEmail);
                        command.Parameters.AddWithValue(("@Orig_Date"), DateTime.Now);

                        connection.Open();

                        ticket.Feedback = command.ExecuteNonQuery().ToString() + " Recored Added";

                        connection.Close();

                    }
                }
                catch(Exception err)
                {
                    ticket.Feedback = "Error: " + err.Message;
                }
            }
        }

        public IEnumerable<TroubleTicketModel> GetActiveRecords()
        {
            List<TroubleTicketModel> lstTix = new List<TroubleTicketModel>();
            TroubleTicketModel ticket = new TroubleTicketModel();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string strSql = "SELECT * FROM TroubleTickets ORDER BY Orig_Date;";
                    SqlCommand cmd = new SqlCommand(strSql, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        ticket = new TroubleTicketModel();
                        ticket.TicketID = Convert.ToInt32(rdr["Ticket_ID"].ToString());
                        ticket.TicketTitle = rdr["Ticket_Title"].ToString();
                        ticket.Category = rdr["Category"].ToString();
                        ticket.ReportingEmail = rdr["Reporting_Email"].ToString();
                        ticket.OrigDate = DateTime.Parse(rdr["Orig_Date"].ToString());
                        ticket.Active = Boolean.Parse(rdr["Active"].ToString());
                        ticket.ResponderEmail = rdr["Responder_Email"].ToString();
                        ticket.ResponderNotes = rdr["Responder_Notes"].ToString();

                        lstTix.Add(ticket);
                    }
                    con.Close();
                }

            }
            catch(Exception err)
            {
                ticket.Feedback = err.Message;
                lstTix.Add(ticket);
            }
            return lstTix;
        }
    }
}
