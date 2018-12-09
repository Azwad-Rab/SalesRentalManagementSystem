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
    public partial class Order : Form
    {
        MySqlConnection connectionstring = new MySqlConnection("server=localhost;user id=root;database=posisdb_csharp_mike");
        MySqlCommand da;

        public Order()
        {
            InitializeComponent();
        }

        public List<CommonValue> Values { get; set; }

        public void AddToGrid(List<CommonValue> val)
        {
            if (val != null)
            {
                foreach (CommonValue item in val)
                {
                    int n = dataGridView.Rows.Add();
                    dataGridView.Rows[n].Cells[0].Value = item.ID;
                    dataGridView.Rows[n].Cells[1].Value = item.Code;
                    dataGridView.Rows[n].Cells[2].Value = item.desc;
                    dataGridView.Rows[n].Cells[3].Value = item.price;

                }
            }

        }

        private void Order_Load_1(object sender, EventArgs e)
        {
            AddToGrid(Values);
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                da = new MySqlCommand(@"INSERT INTO ordertable VALUES('" + dataGridView.Rows[i].Cells[0].Value + "','" + dataGridView.Rows[i].Cells[1].Value + "','" + dataGridView.Rows[i].Cells[2].Value + "','" + dataGridView.Rows[i].Cells[3].Value + "')", connectionstring);
                connectionstring.Open();
                da.ExecuteNonQuery();
                connectionstring.Close();
                //MessageBox.Show("Saved Successfully");

            }

            int sum = 0, j;
            for (j = 0; j < dataGridView.Rows.Count; j++)
            {
                sum = sum + Convert.ToInt32(dataGridView.Rows[j].Cells[3].Value);
            }

            MessageBox.Show("Total Bill ===" + sum.ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            form_product ob = new form_product();
            ob.Show();
            this.Hide();
        }

        
    }
}
