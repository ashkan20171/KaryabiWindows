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
    public partial class frm_Notification : Telerik.WinControls.UI.RadForm
    {
        KaryabiDBEntities database = new KaryabiDBEntities();
        public frm_Notification()
        {
            InitializeComponent();
        }

        private void frm_Notification_Load(object sender, EventArgs e)
        {
            dgw_notify.DataSource = database.tbl_NotifyFromAdmin.ToList();
        }

        private void chk_sendAll_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (chk_sendAll.Checked==true)
            {
                txt_officerId.Enabled = false;
                btn_selOfficer.Enabled = false;
                txt_officerId.ResetText();
            }
            else  if (chk_sendAll.Checked==false)
            {
                txt_officerId.Enabled = true;
                btn_selOfficer.Enabled = true;
            }
        }

        private void btn_selOfficer_Click(object sender, EventArgs e)
        {
            frm_manageOfficers f = new frm_manageOfficers(officeradd.notify);
            f.ShowDialog();
        }

        private void frm_Notification_Activated(object sender, EventArgs e)
        {
            txt_officerId.Text = frm_manageOfficers.OfficerId;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            
            if(txt_description.Text==string.Empty)
            {
                errorProvider1.SetError(txt_description, "متن اعلانیه را وارد کنید");
                return;
            }
            else if (txt_officerId.Text==string.Empty && chk_sendAll.Checked==false)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_officerId, "کد کارمندی را وارد کنید");
                return;
            }
            else
            {
                errorProvider1.Clear();
                if (chk_sendAll.Checked==false)
                {

                    tbl_NotifyFromAdmin tbl_NOTIFY = new tbl_NotifyFromAdmin()
                    {
                        Id = txt_id.Text,
                        OfficerId = txt_officerId.Text,
                        Description = txt_description.Text
                    };
                    database.tbl_NotifyFromAdmin.Add(tbl_NOTIFY);
                    database.SaveChanges();
                    MessageBox.Show("ارسال به کارمند مورد نظر با موفقیت ارسال گردید", "ارسال درخواست", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_description.ResetText();
                    txt_officerId.ResetText();
                    dgw_notify.DataSource = database.tbl_NotifyFromAdmin.ToList();
                }
                else if (chk_sendAll.Checked==true)
                {
                    tbl_NotifyFromAdmin tbl_NOTIFY = new tbl_NotifyFromAdmin()
                    {
                        Id = txt_id.Text,
                        OfficerId ="0",
                        Description = txt_description.Text
                    };
                    database.tbl_NotifyFromAdmin.Add(tbl_NOTIFY);
                    database.SaveChanges();
                    MessageBox.Show("ارسال اعلانیه برای تمام کارمندان با موفقیت ارسال گردید", "ارسال درخواست", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_description.ResetText();
                    txt_officerId.ResetText();
                    dgw_notify.DataSource = database.tbl_NotifyFromAdmin.ToList();

                }
            }

        }
    }
}
