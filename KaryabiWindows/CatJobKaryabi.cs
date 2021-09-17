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
    public partial class frm_CatJobKaryabi : Telerik.WinControls.UI.RadForm
    {
        public frm_CatJobKaryabi()
        {
            InitializeComponent();
        }
        KaryabiDBEntities database = new KaryabiDBEntities();
        private void ClearItems()
        {
            txt_name.Clear();
            txt_tedad.Clear();
            txt_tozihat.Clear();
        }
        private void GetMaxId()
        {
            DataSet1TableAdapters.tbl_JobCategoryTableAdapter table = new DataSet1TableAdapters.tbl_JobCategoryTableAdapter();
            txt_id.Text = table.GetMaxID().ToString();
        }
        private void frm_CatJobKaryabi_Load(object sender, EventArgs e)
        {
            GetMaxId();
            dgw_cat.DataSource = database.tbl_JobCategory.ToList();

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == string.Empty)
            {

                errorProvider1.SetError(txt_id, "کد گروه را وارد نمایید");
                return;
            }
            else if (txt_name.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_name, "نام گروه را وارد نمایید");
                return;

            }
            else if (txt_tedad.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_tedad, "تعداد نفرات گروه را وارد نمایید");
                return;
            }
            else
            {
                errorProvider1.Clear();
                var Already = database.tbl_JobCategory.Where(c => c.Id == txt_id.Text);
                if (Already.Count() > 0)
                {
                    MessageBox.Show("کد گروه تکراری می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetMaxId();
                    return;
                }
                else
                {
                    tbl_JobCategory t = new tbl_JobCategory()
                    {
                        Id = txt_id.Text,
                        JobName = txt_name.Text,
                        Tedad = int.Parse(txt_tedad.Text),
                        Description = txt_tozihat.Text
                    };
                    database.tbl_JobCategory.Add(t);
                    database.SaveChanges();
                    GetMaxId();
                    dgw_cat.DataSource = database.tbl_JobCategory.ToList();
                    ClearItems();
                }
            }
        }

        private void ctm_delete_Click(object sender, EventArgs e)
        {
           
                string current = dgw_cat.CurrentRow.Cells[1].Value.ToString();
                var del = database.tbl_JobCategory.First(c => c.Id == current);
                DialogResult dr;
                dr = MessageBox.Show("ایا میخواهید این گروه را حذف نمایید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    database.tbl_JobCategory.Remove(del);
                    database.SaveChanges();
                    dgw_cat.DataSource = database.tbl_JobCategory.ToList();
                    GetMaxId();
                }
            
        }

        private void ctm_edit_Click(object sender, EventArgs e)
        {
            try
            {
                txt_id.Text = Convert.ToString(dgw_cat.SelectedRows[0].Cells["id"].Value.ToString());
                txt_name.Text = Convert.ToString(dgw_cat.SelectedRows[0].Cells["jobname"].Value.ToString());
                txt_tedad.Text = Convert.ToString(dgw_cat.SelectedRows[0].Cells["tedad"].Value.ToString());
                txt_tozihat.Text = Convert.ToString(dgw_cat.SelectedRows[0].Cells["tozihat"].Value.ToString());
            }
            catch
            {

            }
            //
            txt_id.Enabled = false;
            btn_editFinal.Enabled = true;
            btn_insert.Enabled = false;
            ctm_delete.Enabled = false;

        }

        private void btn_editFinal_Click(object sender, EventArgs e)
        {
                if (txt_name.Text == string.Empty)
            {
               
                errorProvider1.SetError(txt_name, "نام گروه را وارد نمایید");
                return;

            }
            else if (txt_tedad.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_tedad, "تعداد نفرات گروه را وارد نمایید");
                return;
            }
            else
            {
                errorProvider1.Clear();

            tbl_JobCategory table = database.tbl_JobCategory.First(c => c.Id == txt_id.Text);
            table.JobName = txt_name.Text;
            table.Tedad = int.Parse(txt_tedad.Text);
            table.Description = txt_tozihat.Text;
            database.SaveChanges();
            dgw_cat.DataSource = database.tbl_JobCategory.ToList();
            //
            txt_id.Enabled = true;
            btn_editFinal.Enabled = false;
            btn_insert.Enabled = true;
            ctm_delete.Enabled = true;
            //
            GetMaxId();
            ClearItems();
            }

        }

        private void frm_CatJobKaryabi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_editFinal.Enabled = true && txt_id.Enabled == false)
            {
                DialogResult dr;
                dr = MessageBox.Show("شما در حال ویرایش اطلاعات هستید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
                else
                    this.Close();
            }
        }

        private void dgw_cat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgw_cat.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        public static implicit operator ContainerControl(frm_CatJobKaryabi v)
        {
            throw new NotImplementedException();
        }
    }
}
