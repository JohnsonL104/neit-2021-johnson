using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JohnsonL_Activity2.Backend
{
    public partial class ControlPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["loggedIn"] == null || Session["loggedIn"].ToString() == "false")
            {
                Response.Redirect("~/Backend/default.aspx");
            }
        }
        protected void lougoutBtnClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Backend/Default.aspx");
            
        }
    }
}