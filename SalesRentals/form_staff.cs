using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SalesRentals
{
    public partial class form_staff : Form
    {
        MySqlConnection connectionstring = new MySqlConnection("server=localhost;user id=root;database=posisdb_csharp_mike");

        public form_staff()
        {
            InitializeComponent();
            timer.Start();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectionstring.Open();
            MySqlCommand da = new MySqlCommand("Update signup set NewUser='" + txtUserName.Text + "', NewPass='" + txtPass.Text + "',Address='" + txtAddress.Text + "', Contact_No='" + txtContact.Text + "'Where ID='" + txtUserID.Text + "'", connectionstring);
            da.ExecuteNonQuery();
            MessageBox.Show("Update Successful");
            connectionstring.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            connectionstring.Open();
            MySqlCommand da = new MySqlCommand("Delete from signup where ID='" + txtUserID.Text + "'", connectionstring);
            da.ExecuteNonQuery();
            MessageBox.Show("Delete Successful");
            connectionstring.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            connectionstring.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from signup", connectionstring);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            connectionstring.Close();
        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtUserID.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtUserName.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtPass.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtContact.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblTime.Text = dateTime.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            form_menu ob = new form_menu();
            ob.Show();
            this.Hide();
        }
    }
}
