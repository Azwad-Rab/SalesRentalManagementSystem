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
    public partial class form_productVsPrice : Form
    {
        MySqlConnection connectionstring = new MySqlConnection("server=localhost;user id=root;database=posisdb_csharp_mike");
        MySqlCommand da;

        public form_productVsPrice()
        {
            InitializeComponent();
        }

        private void btnLoadPrice_Click(object sender, EventArgs e)
        {
            da = new MySqlCommand("select * from products", connectionstring);
            MySqlDataReader myReader;

            try
            {
                connectionstring.Open();
                myReader = da.ExecuteReader();

                while (myReader.Read())
                {
                    this.chart1.Series["Price"].Points.AddXY(myReader.GetString("Description"), myReader.GetInt32("Unit_Price"));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_menu ob = new form_menu();
            ob.Show();
        }
    }
}
