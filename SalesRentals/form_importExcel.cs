using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace SalesRentals
{
    public partial class form_importExcel : Form
    {
        public form_importExcel()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtPath.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);

            OleDbDataAdapter da = new OleDbDataAdapter("select * from [" + txtSheet.Text + "$]", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            form_menu ob = new form_menu();
            ob.Show();
            this.Hide();
        }
    }
}
