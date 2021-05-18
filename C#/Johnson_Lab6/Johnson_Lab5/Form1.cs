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
            PersonV2 person = new PersonV2();

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

            if (person.Feedback.Contains("ERROR:"))
            {
                MessageBox.Show(person.Feedback, "ERROR");
            }
            else
            {
                MessageBox.Show(person.AddRecordToDB());
            }
        }

       
    }
}
