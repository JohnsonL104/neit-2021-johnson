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

        }

        protected void numBtnClick(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            txtLCD.Text += temp.Text;
        }
        protected void opBtnClick(object sender, EventArgs e)
        {

            if (Session["op"] == null || Session["op"].ToString() == "" ) 
            {
                Button temp = (Button)sender;
                Session["op"] = temp.Text;
                Session["num1"] = txtLCD.Text;
                txtLCD.Text = "";
            }
            else
            {
                Button temp = (Button)sender;
                Session["op"] = temp.Text;
                txtLCD.Text = performMath().ToString();
                Session["num1"] = txtLCD.Text;

            }
        }
        protected void equalsBtnClick(object sender, EventArgs e)
        {
            txtLCD.Text = performMath().ToString();
        }
        protected void clsBtnClick(object sender, EventArgs e)
        {
            Session["op"] = "";
            Session["num1"] = "";
            txtLCD.Text = "";
        }
        private Double performMath()
        {
            Double result;
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
    }
}