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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Start();
            progressBar.Increment(1);

            if (progressBar.Value == 100)
            {
                timer.Stop();
                
                form_welcome ob = new form_welcome();
                ob.Show();
                this.Hide();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
