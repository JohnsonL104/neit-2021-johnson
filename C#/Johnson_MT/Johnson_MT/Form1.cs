using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Johnson_MT
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Person person = new Person();

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

            if (person.Feedback.Contains("ERROR:"))
            {
                MessageBox.Show(person.Feedback, "ERROR");
            }
            else
            {
                Size = new Size(289, 470);
                lblFeedback.Text = "First Name: " + person.FirstName + "\nMiddle Name: " + person.MiddleName + "\nLast Name: " + person.LastName + "\nStreet 1: " + person.Street1 + "\nStreet 2: " + person.Street2 + "\nCity: " + person.City + "\nState: " + person.State + "\nZip: " + person.Zip + "\nPhone: " + person.Phone + "\nEmail: " + person.Email;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicUtils.Cool();
        }
    }
}
