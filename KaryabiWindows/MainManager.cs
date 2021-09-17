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
using System.IO;


namespace KaryabiWindows
{
    public partial class frm_MainManager : Telerik.WinControls.UI.RadForm
    {
        public frm_MainManager()
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

        private void frm_MainManager_Load(object sender, EventArgs e)
        {
            Shamsi_date();
            CurrentDate();
            #region CurrentInfo
            lbl_username.Text = frm_Login.Username;
            lbl_Fullname.Text = frm_Login.Fullname;
            #endregion
            string ip;
            ip = Dns.GetHostName();
            lbl_ServerName.Text = ip;
            lbl_ip.Text = Dns.GetHostByName(ip).AddressList[0].ToString();
            //********************

      /*      try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Style.thm");
                string StrStyle = sr.ReadLine().ToString();
                sr.Close();

                switch (StrStyle)
                {
                    case "Office2007Blue":
                        {
                            styleManager1.ManagerStyle = eStyle.Office2007Blue;
                            break;
                        }
                    case "Office2007Black":
                        {
                            styleManager1.ManagerStyle = eStyle.Office2007Black;
                            break;
                        }
                    case "Office2010Blue":
                        {
                            styleManager1.ManagerStyle = eStyle.Office2010Blue;
                            break;
                        }
                    case "Office2010Black":
                        {
                            styleManager1.ManagerStyle = eStyle.Office2010Black;
                            break;
                        }
                    case "Windows7":
                        {
                            styleManager1.ManagerStyle = eStyle.Windows7Blue;
                            break;
                        }
                    case "Metro":
                        {
                            styleManager1.ManagerStyle = eStyle.Metro;
                            break;
                        }

                }

                //********************

            }
            catch
            {
                styleManager1.ManagerStyle = eStyle.Office2007Blue;
            }
         
       */
        }

        private void btn_Mofficres_Click(object sender, EventArgs e)
        {
            frm_manageOfficers f = new frm_manageOfficers(officeradd.NULL);
            f.ShowDialog();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            frm_Users f = new frm_Users();
            f.ShowDialog();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_ManagerTableAdapter tbl2 = new DataSet1TableAdapters.tbl_ManagerTableAdapter();
            DialogResult dr;
            dr = MessageBox.Show("آیا میخواهید کاربران را غیر فعال کنید", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DataSet1TableAdapters.tbl_UsersTableAdapter tbl_users = new DataSet1TableAdapters.tbl_UsersTableAdapter();
                tbl_users.DisableUsers(false);

                MessageBox.Show("تمامی ورود کاربران به سیستم غیر فعال شد", "Disable Users", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Backup f = new frm_Backup(exitApplication.exit);
               f.ShowDialog();
             
            }
            else
            {
                frm_Backup f = new frm_Backup(exitApplication.exit);
                f.ShowDialog();
             
            }
            tbl2.LogoutAdmin(false);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_time.Text = dt.Hour.ToString("00:") + dt.Minute.ToString("00:") + dt.Second.ToString("00");
        }
      
        private void frm_MainManager_Activated(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_NotifyTableAdapter tb = new DataSet1TableAdapters.tbl_NotifyTableAdapter();
            lbl_notify.Text = "[" + tb.CounterNotifyFalse().ToString() + "] " + "اعلانیه از کارمندان";
            //******************
            DataSet1TableAdapters.tbl_CustomersTableAdapter tbl_customer = new DataSet1TableAdapters.tbl_CustomersTableAdapter();
            lbl_CustomerTrue.Text = "[" + tbl_customer.SelectTrueORFalseCustomers(true).ToString() + "] " + "  مشتری تایید شده از طرف کارمندان";
            //******************
            lbl_CustomerFalse.Text = "[" + tbl_customer.SelectTrueORFalseCustomers(false).ToString() + "]" + "مشتری تایید نشده";


        }

        private void btn_Mcustomers_Click(object sender, EventArgs e)
        {
            frm_Customers f = new frm_Customers(customerFlag.admin);
            f.ShowDialog();
        }

        private void btn_CatJobKaryabi_Click(object sender, EventArgs e)
        {
            frm_CatJobKaryabi f = new frm_CatJobKaryabi();
            f.ShowDialog();
        }

        private void btn_ManageNotify_Click(object sender, EventArgs e)
        {
            frm_ManageNotify f = new frm_ManageNotify();
            f.ShowDialog();
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

        private void btn_sendNotify_Click(object sender, EventArgs e)
        {
            frm_Notification f = new frm_Notification();
            f.ShowDialog();
        }

        private void btn_sendMail_Click(object sender, EventArgs e)
        {
            frm_Email f = new frm_Email();
            f.ShowDialog();
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            frm_Backup f = new frm_Backup(exitApplication.notexit);
            f.ShowDialog();
        }

        private void btn_office2007blue_Click(object sender, EventArgs e)
        {
         /*   styleManager1.ManagerStyle = eStyle.Office2007Blue;
            TextWriter tw = new StreamWriter(Application.StartupPath + "\\Style.thm");
            tw.WriteLine("Office2007Blue");
            tw.Close(); */
        }

        private void btn_office2007black_Click(object sender, EventArgs e)
        {
         /*   styleManager1.ManagerStyle = eStyle.Office2007Black;
            TextWriter tw = new StreamWriter(Application.StartupPath + "\\Style.thm");
            tw.WriteLine("Office2007Black");
            tw.Close(); */
        }

        private void btn_office2010blue_Click(object sender, EventArgs e)
        {
       /*     styleManager1.ManagerStyle = eStyle.Office2010Blue;
            TextWriter tw = new StreamWriter(Application.StartupPath + "\\Style.thm");
            tw.WriteLine("Office2010Blue");
            tw.Close(); */
        }

        private void btn_office2010black_Click(object sender, EventArgs e)
        {
        /*    styleManager1.ManagerStyle = eStyle.Office2010Black;
            TextWriter tw = new StreamWriter(Application.StartupPath + "\\Style.thm");
            tw.WriteLine("Office2010Black");
            tw.Close(); */
        }

        private void btn_win7_Click(object sender, EventArgs e)
        {
        /*    styleManager1.ManagerStyle = eStyle.Windows7Blue;
            TextWriter tw = new StreamWriter(Application.StartupPath + "\\Style.thm");
            tw.WriteLine("Windows7");
            tw.Close(); */
        }

        private void btn_metro_Click(object sender, EventArgs e)
        {
       /*     styleManager1.ManagerStyle = eStyle.Metro;
            TextWriter tw = new StreamWriter(Application.StartupPath + "\\Style.thm");
            tw.WriteLine("Metro");
            tw.Close(); */
        }

        private void btn_ReportOfficers_Click(object sender, EventArgs e)
        {
            frm_ReportOfficers f = new frm_ReportOfficers();
            f.ShowDialog();
        }

        private void btn_manager_Click(object sender, EventArgs e)
        {
            Frm_Manager f = new Frm_Manager();
            f.ShowDialog();
        }

        private void lbl_CustomerTrue_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_CustomerFalse_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_CustomerTrue_TextChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (lbl_notify.Text.Contains("0"))
            {
                sp.Stop();
            }
            else
            {
                sp.SoundLocation = Application.StartupPath + @"\Windows Notify Email.wav";
                sp.Play();
            }
        }

        private void lbl_CustomerFalse_TextChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (lbl_notify.Text.Contains("0"))
            {
                sp.Stop();
            }
            else
            {
                sp.SoundLocation = Application.StartupPath + @"\Windows Notify Email.wav";
                sp.Play();
            }
        }

       
        private void btn_TestIp_Click(object sender, EventArgs e)
        {
            frm_TestIp f = new frm_TestIp();
            f.ShowDialog();
        }
    }
}
