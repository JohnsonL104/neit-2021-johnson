using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            BasicUtils.ToggleButton(btnDelete);
            BasicUtils.ToggleButton(btnUpdate);
        }
        public Form1(String id)
        {
            InitializeComponent();

            BasicUtils.ToggleButton(btnSubmit);
            PersonV2 person = new PersonV2();

            SqlDataReader dr = person.GetRecordsFromDBByID(id);

            person.Id = id;

            lblId.Text = id;

            while (dr.Read())
            {
                txtFName.Text = dr["FirstName"].ToString();
                txtMName.Text = dr["MiddleName"].ToString();
                txtLName.Text = dr["LastName"].ToString();
                txtStreet1.Text = dr["Street1"].ToString();
                txtStreet2.Text = dr["Street2"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtState.Text = dr["State"].ToString();
                txtZip.Text = dr["Zip"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtCellPhone.Text = dr["CellPhone"].ToString();
                txtIGUrl.Text = dr["InstagramURL"].ToString();
                txtEmail.Text = dr["Email"].ToString();




            
            }


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
        

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            PersonV2 person = new PersonV2();

            person.Id = lblId.Text;

            person.UpdateRecord();



            if (!person.Feedback.Contains("ERROR:"))
            {
                String result = person.DeleteRecord();
                MessageBox.Show(result);
                Close();
            }
            else
            {
                MessageBox.Show(person.Feedback);
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PersonV2 person = new PersonV2();

            person.Id = lblId.Text;

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
                MessageBox.Show(person.UpdateRecord());
                Close();
            }

            
        }
    }
}
