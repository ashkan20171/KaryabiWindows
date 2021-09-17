using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
namespace KaryabiWindows
{
    public partial class frm_Email : Telerik.WinControls.UI.RadForm
    {
        public frm_Email()
        {
            InitializeComponent();
        }

        private override void btn_send_Click(object sender, EventArgs e)
        {

            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(userpass.Username, txt_name.Text, Encoding.UTF8);
                MailAddress To = new MailAddress(txt_to.Text);
                msg = new MailMessage(msg.From, To);
                if (txt_cc.Text!=string.Empty)
                {
                    msg.CC.Add(txt_cc.Text);
                }
                if (txt_bcc.Text !=string.Empty)
                {
                    msg.Bcc.Add(txt_bcc.Text);
                }
                msg.Subject = txt_subject.Text;
                msg.Body = txt_body.Text;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    Attachment Attach = new Attachment(listBox1.Items[i].ToString(), MediaTypeNames.Application.Octet);
                    msg.Attachments.Add(Attach);
                }
                SmtpClient SmtpClient = new SmtpClient();
                SmtpClient.Host = userpass.Account_Send;
                SmtpClient.Port = userpass.Port_Send;
                SmtpClient.EnableSsl = userpass.EnableSSL;
                SmtpClient.Credentials = new NetworkCredential(userpass.Username, userpass.Password);
                SmtpClient.Send(msg);
                btn_send.Enabled = false;
                MessageBox.Show("ایمیل با موفقیت ارسال شد", "Send Mail Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_send.Enabled = true;
            }
            catch
            {
                MessageBox.Show(" Send Error","Faild",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
