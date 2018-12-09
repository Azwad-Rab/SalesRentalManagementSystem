using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesRentals
{
    public partial class form_login : Form
    {
        MySqlConnection connectionstring = new MySqlConnection("server=localhost;user id=root;database=posisdb_csharp_mike");

        public form_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da1 = new MySqlDataAdapter("select Count(*) from signup where NewUser='" + txtUserName.Text + "' and NewPass='" + txtPass.Text + "'  ", connectionstring);

            DataTable dt1 = new DataTable();


            da1.Fill(dt1);

            if (dt1.Rows[0][0].ToString() == "1")
            {
                form_menu ob = new form_menu();
                ob.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Enter Valid Username and Password");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            form_welcome ob = new form_welcome();
            ob.Show();
            this.Close();
        }
    }
}
