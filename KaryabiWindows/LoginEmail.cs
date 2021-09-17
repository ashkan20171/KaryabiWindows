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

namespace KaryabiWindows
{
    public partial class frm_LoginEmail : Telerik.WinControls.UI.RadForm
    {
        public frm_LoginEmail()
        {
            InitializeComponent();
        }

        private void btn_loginEmail_Click(object sender, EventArgs e)
        {
            ErrorProvider ep = new ErrorProvider();
            if (txt_username.Text == string.Empty && txt_pass.Text == string.Empty)
            {
               
                ep.SetError(txt_username, "نام کاربری را وارد کنید");
                ep.SetError(txt_pass, "رمز عبور را وارد کنید");
                return;

            }
            else
            {
                ep.Clear();
                userpass.Username = txt_username.Text;
                userpass.Password = txt_pass.Text;
                userpass.Port_Send = 587;
                userpass.EnableSSL = true;
                userpass.Account_Send = "smtp.mail.yahoo.com";
                this.Close();
            }
        }
    }
}
