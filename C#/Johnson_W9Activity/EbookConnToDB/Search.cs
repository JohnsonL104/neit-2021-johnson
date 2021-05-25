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

namespace EbookConnToDB
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EBook ebook = new EBook();
            DataSet ds = ebook.GetRecordsFromDB(txtTitle.Text, txtAuthorLast.Text);

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables["EBooks"].ToString();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ebookID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            MessageBox.Show(ebookID);

            int ebookIDInt = Convert.ToInt32(ebookID);

            Form1 form = new Form1(ebookIDInt);
            form.ShowDialog();
        }
    }
}
