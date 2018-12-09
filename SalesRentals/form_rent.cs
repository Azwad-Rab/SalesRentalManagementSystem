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
    public partial class form_rent : Form
    {
        MySqlConnection connectionstring = new MySqlConnection("server=localhost;user id=root;database=posisdb_csharp_mike");

        public form_rent()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            connectionstring.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from renttable", connectionstring);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connectionstring.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            form_menu ob = new form_menu();
            ob.Show();
            this.Hide();
        }
    }
}
