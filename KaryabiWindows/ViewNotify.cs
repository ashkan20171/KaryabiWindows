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
    
    public partial class frm_ViewNotify : Telerik.WinControls.UI.RadForm
    {
        public frm_ViewNotify()
        {
            InitializeComponent();
        }
        KaryabiDBEntities database = new KaryabiDBEntities();
        private void ViewPrivteNotify()
        {
            var Private = database.tbl_NotifyFromAdmin.Where(c => c.OfficerId == frm_Login.Uname);
            dgw_notifyPuPr.DataSource = Private.ToList();
        }
        private void ViewPublicNotify()
        {
            var Public = database.tbl_NotifyFromAdmin.Where(c => c.OfficerId == "0");
            dgw_notifyPuPr.DataSource = Public.ToList();
        }
       
        private void frm_ViewNotify_Load(object sender, EventArgs e)
        {
            rdo_PrivateNotify.IsChecked = true;
            ViewPrivteNotify();
        }

        private void ctm_view_Click(object sender, EventArgs e)
        {
            txt_ViewNotify.Text = Convert.ToString(dgw_notifyPuPr.CurrentRow.Cells["description"].Value.ToString());
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgw_notifyPuPr_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgw_notifyPuPr.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void rdo_PrivateNotify_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ViewPrivteNotify();
        }

        private void rdo_PublicNotify_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ViewPublicNotify();

        }
    }
}
