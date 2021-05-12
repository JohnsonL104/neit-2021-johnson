using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonClass;
namespace Johnson_Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer person = new Customer();

            person.FirstName = txtFName.Text;

            person.MiddleName = txtMName.Text;

            person.LastName = txtLName.Text;

            person.Street1 = txtStreet1.Text;

            person.Street2 = txtStreet2.Text;

            person.City = txtCity.Text;

            person.State = txtState.Text;

            person.Zip = txtZip.Text;

            person.Phone = txtPhone.Text;

            person.Email = txtEmail.Text;

            person.CellPhone = txtCellPhone.Text;

            person.InstagramURL = txtIGUrl.Text;

            person.CustomerSince = dateTimePicker1.Value;

            double tempDouble;
            if (Double.TryParse(txtTotalPurchases.Text, out tempDouble)){
                person.TotalPurchases = tempDouble;
            }
            else
            {
                person.TotalPurchases = -1;
            }

            person.DiscountMember = checkBox1.Checked;

            Int32 tempInt;
            if (Int32.TryParse(txtTotalPurchases.Text, out tempInt))
            {
                person.RewardsEarned = tempInt;
            }
            else
            {
                person.RewardsEarned = -1;
            }



            if (person.Feedback.Contains("ERROR:"))
            {
                MessageBox.Show(person.Feedback, "ERROR");
            }
            else
            {
                Size = new Size(289, 705);
                lblFeedback.Text = "First Name: " + person.FirstName + "\nMiddle Name: " + person.MiddleName + "\nLast Name: " + person.LastName + "\nStreet 1: " + person.Street1 + "\nStreet 2: " + person.Street2 + "\nCity: " + person.City + "\nState: " + person.State + "\nZip: " + person.Zip + "\nPhone: " + person.Phone + "\nCellPhone: " + person.CellPhone + "\nInstagram Url: " + person.InstagramURL + "\nEmail: " + person.Email +"\nCustomer Since: " + person.CustomerSince + "\nTotal Purchases: " + person.TotalPurchases + "\nDiscount Member: " + person.DiscountMember + "\nRewards Earned: " + person.RewardsEarned;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox2.Checked;
        }

        
    }
}
