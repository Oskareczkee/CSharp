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

namespace Fake_Mail_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage(To.Text, From.Text, Subject.Text, Text.Text);
                message.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("poczta.o2.pl", 995);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential(From.Text, "nieznamkurwahasla");
                client.Send(message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
