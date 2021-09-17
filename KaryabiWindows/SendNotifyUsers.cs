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
    public partial class frm_SendNotifyUsers :Telerik.WinControls.UI.RadForm
    {
        public frm_SendNotifyUsers()
        {
            InitializeComponent();
        }
        KaryabiDBEntities database = new KaryabiDBEntities();
        private void GetMaxId()
        {
            DataSet1TableAdapters.tbl_NotifyTableAdapter table = new DataSet1TableAdapters.tbl_NotifyTableAdapter();
            txt_id.Text=table.GetMaxIdNotify().ToString();
        }
        private void frm_SendNotifyUsers_Load(object sender, EventArgs e)
        {
            GetMaxId();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            tbl_Notify table = new tbl_Notify()
            {
                Id=txt_id.Text,
                OfficerId=frm_Login.Uname,
                Description=txt_description.Text,
                Validation=false
            };
            database.tbl_Notify.Add(table);
            database.SaveChanges();
            txt_description.ResetText();
            MessageBox.Show("درخواست شما ارسال شد و پس از بررسی مدیر به شما اعلان خواهد شد", "ارسال درخواست", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetMaxId();

        }
    }
}
