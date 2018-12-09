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
    public partial class form_about : Form
    {
        public form_about()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            form_welcome ob = new form_welcome();
            ob.Show();
            this.Hide();
        }
    }
}
