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
    public partial class form_menu : Form
    {
        MySqlConnection connectionstring = new MySqlConnection("server=localhost;user id=root;database=posisdb_csharp_mike");

        public form_menu()
        {
            InitializeComponent();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblTime.Text = dateTime.ToString();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            
            form_staff ob = new form_staff();
            ob.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            
            form_product ob = new form_product();
            ob.Show();
            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            
            form_rent ob = new form_rent();
            ob.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            form_order ob = new form_order();
            ob.Show();
            this.Hide();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            form_graphInfo ob = new form_graphInfo();
            ob.Show();
            this.Hide();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            form_importExcel ob = new form_importExcel();
            ob.Show();
            this.Hide();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            connectionstring.Close();

            form_welcome ob = new form_welcome();
            ob.Show();
            this.Hide();

        }
    }
}
