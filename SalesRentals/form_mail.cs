using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SalesRentals
{
    public partial class form_mail : Form
    {
        public form_mail()
        {
            InitializeComponent();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(txtFrom.Text);
            mail.To.Add(txtTo.Text);
            mail.Subject = txtSubject.Text;
            mail.Body = txtBody.Text;
            System.Net.Mail.Attachment att;
            att = new Attachment("");
            mail.Attachments.Add(att);


            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential(txtFrom.Text, txtTo.Text);
            smtpServer.EnableSsl = true;
            smtpServer.Send(mail);
            MessageBox.Show("Mail Sent Successfully");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Order ob = new Order();
            ob.Show();
            this.Hide();
        }
    }
}
