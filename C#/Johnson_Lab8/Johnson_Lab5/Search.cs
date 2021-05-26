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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

      
        private void btnSearch_Click(object sender, EventArgs e)
        {
            PersonV2 person = new PersonV2();
            DataSet ds = person.GetRecordsFromDB(txtFirst.Text, txtLast.Text);

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables["Persons"].ToString();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            MessageBox.Show(id);


            Form1 form = new Form1(id);
            form.ShowDialog();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
