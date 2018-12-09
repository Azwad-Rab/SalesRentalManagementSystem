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
    public partial class form_welcome : Form
    {
        public form_welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            form_login ob = new form_login();
            ob.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            
            form_signup ob = new form_signup();
            ob.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            
            form_about ob = new form_about();
            ob.Show();
            this.Hide();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            
            form_contact ob = new form_contact();
            ob.Show();
            this.Hide();
        }

        private void btnFaq_Click(object sender, EventArgs e)
        {
            
            form_faq ob = new form_faq();
            ob.Show();
            this.Hide();
        }
    }
}
