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
    public partial class form_signup : Form
    {
        MySqlConnection connectionstring = new MySqlConnection("server=localhost;user id=root;database=posisdb_csharp_mike");

        public form_signup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into signup(NewUser,NewPass,Address,Contact_No)Values('" + txtUserName.Text + "','" + txtPass.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "')", connectionstring);
            
            connectionstring.Open();
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Insert Successful");
            connectionstring.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            form_welcome ob = new form_welcome();
            ob.Show();
            this.Hide();
        }
    }
}
