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
using System.Globalization;
using System.Net;
using System.Media;

namespace KaryabiWindows
{
    public partial class frm_MainOfficers : Telerik.WinControls.UI.RadForm
    {
        public frm_MainOfficers()
        {
            InitializeComponent();
            timer1.Start();
        }

        KaryabiDBEntities database = new KaryabiDBEntities();
        private void Shamsi_date()
        {
            string Myday = DateTime.Now.DayOfWeek.ToString();
            if (Myday == DayOfWeek.Saturday.ToString())
                lbl_date.Text = "شنبه";
            if (Myday == DayOfWeek.Sunday.ToString())
                lbl_date.Text = "یک شنبه";
            if (Myday == DayOfWeek.Monday.ToString())
                lbl_date.Text = "دوشنبه";
            if (Myday == DayOfWeek.Tuesday.ToString())
                lbl_date.Text = "سه شنبه";
            if (Myday == DayOfWeek.Wednesday.ToString())
                lbl_date.Text = "چهارشنبه";
            if (Myday == DayOfWeek.Thursday.ToString())
                lbl_date.Text = "پنج شنبه";
            if (Myday == DayOfWeek.Friday.ToString())
                lbl_date.Text = "جمعه";
        }
        private void CurrentDate()
        {
            DateTime dt = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();
            string yyyy = pc.GetYear(dt).ToString("0000/");
            string mm = pc.GetMonth(dt).ToString("00/");
            string dd = pc.GetDayOfMonth(dt).ToString("00");
            lbl_currentDate.Text = yyyy + mm + dd;
        }

        private void frm_MainOfficers_Load(object sender, EventArgs e)
        {



            CurrentDate();
            Shamsi_date();
            #region IpAddress
            string ip;
            ip = Dns.GetHostName();
            lbl_ServerName.Text = ip;
            lbl_ip.Text = Dns.GetHostByName(ip).AddressList[0].ToString();
            #endregion

            #region CurrentInfo
            if (frm_Login.Permissoion == "0")
            {
                lbl_type.Text = " کارمند گرامی کد کاربری";
            }
            else if (frm_Login.Permissoion == "1")
            {
                lbl_type.Text = " حسابدار گرامی  کد کاربری";
            }
            else if (frm_Login.Permissoion == "2")
            {
                lbl_type.Text = "منشی گرامی  کد کاربری";
            }
            lbl_username.Text = frm_Login.Uname;
            lbl_Fullname.Text = frm_Login.FuName;
            #endregion

        }

        private void btn_Mcustomers_Click(object sender, EventArgs e)
        {
            frm_Customers f = new frm_Customers(customerFlag.officer);
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_time.Text = dt.Hour.ToString("00:") + dt.Minute.ToString("00:") + dt.Second.ToString("00");

        }

        private void btn_sendNotify_Click(object sender, EventArgs e)
        {
            frm_SendNotifyUsers f = new frm_SendNotifyUsers();
            f.ShowDialog();
        }

        private void frm_MainOfficers_Activated(object sender, EventArgs e)
        {

            DataSet1TableAdapters.tbl_NotifyTableAdapter tbl_notify = new DataSet1TableAdapters.tbl_NotifyTableAdapter();
            lbl_notify.Text = "[" + tbl_notify.CounterNotify(frm_Login.Uname).ToString() +"]  " + "اعلانیه تایید شده";
            //*********************
            DataSet1TableAdapters.tbl_NotifyFromAdminTableAdapter tbl_notifyFromAdmin = new DataSet1TableAdapters.tbl_NotifyFromAdminTableAdapter();
            lbl_notifyFromAdminToUser.Text = "[" + tbl_notifyFromAdmin.CountNotifyFromAdminToOneUser(frm_Login.Uname).ToString() + "]  " + "اعلانیه از مدیر به شما";
            //*********************
            lbl_PublicNotify.Text = "[" + tbl_notifyFromAdmin.CounterNotifyPublic().ToString() + "]  " + "اعلانیه عمومی از مدیر";

        }

        private void lbl_notify_Click(object sender, EventArgs e)
        {

        }

        private void lbl_notify_TextChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
           if (lbl_notify.Text.Contains("0"))
           {
               sp.Stop();
           }
           else
           {
               sp.SoundLocation = Application.StartupPath + "\\Windows Notify System Generic.wav";
               sp.Play();
           }
            
        }

        private void lbl_notifyFromAdmin_TextChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (lbl_notify.Text.Contains("0"))
            {
                sp.Stop();
            }
            else
            {
                sp.SoundLocation = Application.StartupPath + "\\Windows Notify System Generic.wav";
                sp.Play();
            }
        }

        private void lbl_PublicNotify_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (lbl_notify.Text.Contains("0"))
            {
                sp.Stop();
            }
            else
            {
                sp.SoundLocation = Application.StartupPath + "\\Windows Notify System Generic.wav";
                sp.Play();
            }
        }

        private void btn_viewNotify_Click(object sender, EventArgs e)
        {
            frm_ViewNotify f = new frm_ViewNotify();
            f.ShowDialog();
        }

        private void btn_TestIp_Click(object sender, EventArgs e)
        {
            frm_TestIp f = new frm_TestIp();
            f.ShowDialog();
        }

    }
}
