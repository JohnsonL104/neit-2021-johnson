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
    public partial class EBookSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] == null || Session["loggedIn"].ToString() == "false")
            {
                Response.Redirect("~/Backend/default.aspx");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            EBook ebook = new EBook();

            DataSet ds = ebook.GetRecordsFromDB(txtTitle.Text, txtLast.Text);

            dgResults.DataSource = ds;
            dgResults.DataMember = ds.Tables[0].TableName;
            dgResults.DataBind();



            SqlDataReader dr = null;

            dr = ebook.GetRecordsFromDBDR(txtTitle.Text, txtLast.Text);

            rptSearch.DataSource = dr;
            rptSearch.DataBind();


            dr = ebook.GetRecordsFromDBDR(txtTitle.Text, txtLast.Text);

            litResults.Text = "<table>";

            litResults.Text += "<th>Title</th><th>First Name</th><th>Lastname</th><th>Date Published</th><th>EditLink</th>";

            while (dr.Read())
            {
                litResults.Text +=
                    "<tr>" +
                    "<td>" + dr["Title"].ToString() + "</td>" +
                    "<td>" + dr["AuthorFirst"].ToString() + "</td>" +
                    "<td>" + dr["AuthorLast"].ToString() + "</td>" +
                    "<td>" + dr["DatePublished"].ToString() + "</td>" +
                    "<td>" + "<a href = 'EBookManager.aspx?EBookID=" + dr["EBookID"].ToString() + "'>Edit</a></td>" +
                    "</tr>";
            }

            litResults.Text += "</table>";
        }
    }
}