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
    public partial class form_product : Form
    {
        MySqlConnection connectionstring = new MySqlConnection("server=localhost;user id=root;database=posisdb_csharp_mike");

        public form_product()
        {
            InitializeComponent();
            timer.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into products(Product_ID,Product_Code,Description,StocksOnHand,Category_ID,Unit_Price)Values('" + txtProductID.Text + "','" + txtProductCode.Text + "','" + txtDesc.Text + "','" + txtStockQuantity.Text + "','" + txtCatID.Text + "','" + txtPrice.Text + "')", connectionstring);
            connectionstring.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert Successful");
            connectionstring.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectionstring.Open();
            MySqlCommand da = new MySqlCommand("Update products set Product_Code='" + txtProductCode.Text + "', Description='" + txtDesc.Text + "',StocksOnHand='" + txtStockQuantity.Text + "', Category_ID='" + txtCatID.Text + "', Unit_Price='" + txtPrice.Text + "'Where Product_ID='" + txtProductID.Text + "'", connectionstring);
            da.ExecuteNonQuery();
            MessageBox.Show("Update Successful");
            connectionstring.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            connectionstring.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from products", connectionstring);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView.Rows.Add();
                dataGridView.Rows[n].Cells[1].Value = item[0].ToString();
                dataGridView.Rows[n].Cells[2].Value = item[1].ToString();
                dataGridView.Rows[n].Cells[3].Value = item[2].ToString();
                dataGridView.Rows[n].Cells[4].Value = item[3].ToString();
                dataGridView.Rows[n].Cells[5].Value = item[4].ToString();
                dataGridView.Rows[n].Cells[6].Value = item[5].ToString();

            }
            //dataGridView1.DataSource = dt;
            connectionstring.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            connectionstring.Open();
            MySqlCommand da = new MySqlCommand("Delete from products where Product_ID='" + txtProductID.Text + "'", connectionstring);
            da.ExecuteNonQuery();
            MessageBox.Show("Delete Successful");
            connectionstring.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            List<CommonValue> CV = new List<CommonValue>();

            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    CV.Add(new CommonValue
                    {
                        ID = item.Cells[1].Value.ToString(),
                        Code = item.Cells[2].Value.ToString(),
                        desc = item.Cells[3].Value.ToString(),
                        price = item.Cells[6].Value.ToString(),
                    });
                }

            }

            Order ob = new Order();
            ob.Values = CV;
            ob.Show();
            this.Hide();
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtProductID.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtProductCode.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtDesc.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtStockQuantity.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtCatID.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtPrice.Text = dataGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblTime.Text = dateTime.ToString();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            List<CommonValue> CV = new List<CommonValue>();

            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    CV.Add(new CommonValue
                    {
                        ID = item.Cells[1].Value.ToString(),
                        Code = item.Cells[2].Value.ToString(),
                        desc = item.Cells[3].Value.ToString(),
                        price = item.Cells[6].Value.ToString(),
                    });
                }

            }

            Rent ob = new Rent();
            ob.Values = CV;
            ob.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            form_menu ob = new form_menu();
            ob.Show();
            this.Hide();
        }
    }
}
