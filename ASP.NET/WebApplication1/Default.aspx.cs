using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {

       

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["flag"] == null)
            {
                Session["flag"] = false;
            }

            
        }

        protected void numBtnClick(object sender, EventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + Session["flag"] + "')", true);


            if ((bool)Session["flag"])
            {
                Session["flag"] = false;
                Button temp = (Button)sender;
                txtLCD.Text = temp.Text;
            }
            
            else
            {
                Button temp = (Button)sender;
                txtLCD.Text += temp.Text;
            }
        }
        protected void opBtnClick(object sender, EventArgs e)
        {
            
            Button temp = (Button)sender;
            rstBtns();
            temp.BackColor = System.Drawing.ColorTranslator.FromHtml("#BCBCBC");
            if (Session["op"] == null || Session["op"].ToString() == "" || (bool)Session["flag"]) 
            {
                
                Session["op"] = temp.Text;
                Session["num1"] = txtLCD.Text;
                txtLCD.Text = "";
            }
            else
            {
                
                Session["op"] = temp.Text;
                txtLCD.Text = performMath().ToString();
                Session["num1"] = txtLCD.Text;
                Session["flag"] = true;
            }
        }
        protected void equalsBtnClick(object sender, EventArgs e)
        {
            rstBtns();
            Session["flag"] = true;
            txtLCD.Text = performMath().ToString();
        }
        protected void clsBtnClick(object sender, EventArgs e)
        {
            rstBtns();
            Session["op"] = "";
            Session["num1"] = "";
            txtLCD.Text = "";
        }
        private Double performMath()
        {
            
            if(Session["op"].ToString() == "+")
            {
                return Double.Parse(Session["num1"].ToString()) + Double.Parse(txtLCD.Text);
            }
            else if (Session["op"].ToString() == "-")
            {
                return Double.Parse(Session["num1"].ToString()) - Double.Parse(txtLCD.Text);
            }
            else if (Session["op"].ToString() == "*")
            {
                return Double.Parse(Session["num1"].ToString()) * Double.Parse(txtLCD.Text);
            }
            else if (Session["op"].ToString() == "/")
            {
                return Double.Parse(Session["num1"].ToString()) / Double.Parse(txtLCD.Text);
            }
            return 0;
        }

        private void rstBtns()
        {
            btnAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFEFEF");
            btnDiv.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFEFEF");
            btnMin.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFEFEF");
            btnMul.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFEFEF");
        }
    }
}