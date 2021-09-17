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
    public partial class frm_ManageNotify : Telerik.WinControls.UI.RadForm

    {
        public frm_ManageNotify()
        {
            InitializeComponent();
        }
        KaryabiDBEntities database = new KaryabiDBEntities();
        private void frm_ManageNotify_Load(object sender, EventArgs e)
        {
            dgw_notify.DataSource = database.tbl_Notify.ToList(); 
        }

        private void dgw_notify_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgw_notify.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void ctm_review_Click(object sender, EventArgs e)
        {
            try
            {
                txt_id.Text = Convert.ToString(dgw_notify.SelectedRows[0].Cells["id"].Value.ToString());
                txt_officerId.Text = Convert.ToString(dgw_notify.SelectedRows[0].Cells["officerid"].Value.ToString());
                txt_description.Text = Convert.ToString(dgw_notify.SelectedRows[0].Cells["description"].Value.ToString());
                chk_valid.Checked = Convert.ToBoolean(dgw_notify.SelectedRows[0].Cells["validation"].Value.ToString());
                btn_add.Enabled = true;
                ctm_delete.Enabled = false;
                txt_SById.Enabled = false;
                txt_SbyOfficerId.Enabled = false;
            }
            catch
            {

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tbl_Notify table = database.tbl_Notify.First(c => c.Id == txt_id.Text);
            table.OfficerId = txt_officerId.Text;
            table.Description = txt_description.Text;
            table.Validation = chk_valid.Checked;
            database.SaveChanges();
            txt_description.ResetText();
            txt_id.ResetText();
            txt_officerId.ResetText();
            ctm_delete.Enabled = true;
            btn_add.Enabled = false;
            chk_valid.Checked = false;
            txt_SById.Enabled = true ;
            txt_SbyOfficerId.Enabled = true;
            dgw_notify.DataSource = database.tbl_Notify.ToList();

        }

        private void ctm_delete_Click(object sender, EventArgs e)
        {
          string current=dgw_notify.SelectedRows[0].Cells["id"].Value.ToString();

          var Del = database.tbl_Notify.First(c => c.Id == current);
            DialogResult dr;
            dr = MessageBox.Show("ایا میخواهید این درخواست را حذف نمایید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (dr == DialogResult.Yes)
            {
                database.tbl_Notify.Remove(Del);
                database.SaveChanges();
                dgw_notify.DataSource = database.tbl_Notify.ToList();
                
            }
        }

        private void frm_ManageNotify_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_add.Enabled == true)
            {
                DialogResult dr;
                dr = MessageBox.Show("شما در حال بررسی درخواست هستید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
                else
                    this.Close();
            }
        }

        private void txt_SById_TextChanged(object sender, EventArgs e)
        {
            var SearchById = database.tbl_Notify.Where(c => c.Id.Contains(txt_SById.Text));
            dgw_notify.DataSource = SearchById.ToList();

        }

        private void txt_SbyOfficerId_TextChanged(object sender, EventArgs e)
        {
            var SearchByOfficerId = database.tbl_Notify.Where(c => c.OfficerId.Contains(txt_SbyOfficerId.Text));
            dgw_notify.DataSource = SearchByOfficerId.ToList();
        }
    }
}
