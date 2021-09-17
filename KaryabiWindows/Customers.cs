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
    public partial class frm_Customers : Telerik.WinControls.UI.RadForm
    {
        customerFlag _customer_flag;
        public frm_Customers(customerFlag CutomerFlag)
        {
            this._customer_flag = CutomerFlag;
            InitializeComponent();
        }

        KaryabiDBEntities database = new KaryabiDBEntities();
        public static string AddEmail;
        private void BindTheWork()
        {

            //  var Showall = from a in database.tbl_JobCategory select a.JobName;
            //    cmb_workname.DataSource = Showall.ToList();
            cmb_workname.DataSource = database.tbl_JobCategory.Select(c => c.JobName).ToList();

        }
        private void ResetItems()
        {
            txt_username.ResetText();
            txt_address.ResetText();
            txt_birth.ResetText();
            txt_codeMelli.ResetText();
            txt_description.ResetText();
            txt_email.ResetText();
            txt_family.ResetText();
            txt_mobile.ResetText();
            txt_name.ResetText();
            txt_password.ResetText();
            txt_tell.ResetText();
            cmb_workname.SelectedIndex = 0;
            cmb_miartalStatus.SelectedIndex = 0;
            chk_state.Checked = false;
        }

        private void frm_Customers_Load(object sender, EventArgs e)
        {

            dgw_customers.DataSource = database.tbl_Customers.ToList();
            cmb_miartalStatus.SelectedIndex = 0;
            rdo_SbyUname.IsChecked = true;
            txt_Search.NullText = "جست و جو بر اساس نام کاربری";
            BindTheWork();
            if (_customer_flag == customerFlag.admin)
            {
                chk_flagAdmin.Visible = true;
                dgw_customers.Columns["officervalid"].Visible = true;

            }
            else if (_customer_flag == customerFlag.officer)
            {
                chk_flagAdmin.Visible = false;
                dgw_customers.Columns["officervalid"].Visible = false;
            }




        }

        private void dgw_customers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgw_customers.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string find = txt_username.Text;
            var findcustomers = database.tbl_Customers.Where(i => i.Username == find);
            if (findcustomers.Count() != 0)
            {
                var del = database.tbl_Customers.First(i => i.Username == find);

                DialogResult dr;
                dr = MessageBox.Show("ایا میخواهید این مشتری را حذف نمایید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    database.tbl_Customers.Remove(del);
                    database.SaveChanges();
                    dgw_customers.DataSource = database.tbl_Customers.ToList();
                    txt_username.ResetText();
                }

            }
            else
            {
                MessageBox.Show("همچین مشتری وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_username.Focus();
                txt_username.SelectAll();
            }
        }

        private void ctm_deleting_Click(object sender, EventArgs e)
        {
            string current = dgw_customers.SelectedRows[0].Cells["username"].Value.ToString();
            var del = database.tbl_Customers.First(i => i.Username == current);

            DialogResult dr;
            dr = MessageBox.Show("ایا میخواهید این مشتری را حذف نمایید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                database.tbl_Customers.Remove(del);
                database.SaveChanges();
                dgw_customers.DataSource = database.tbl_Customers.ToList();
            }
        }

        private void btn_delete_MouseHover(object sender, EventArgs e)
        {
            txt_username.NullText = "حذف بر اساس نام کاربری";
        }

        private void btn_delete_MouseLeave(object sender, EventArgs e)
        {
            txt_username.NullText = "";
        }

        private void ctm_editing_Click(object sender, EventArgs e)
        {


            txt_username.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["username"].Value.ToString());
            txt_password.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["password"].Value.ToString());
            txt_name.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["name"].Value.ToString());
            txt_family.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["family"].Value.ToString());
            txt_birth.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["birth"].Value.ToString());
            txt_codeMelli.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["codemelli"].Value.ToString());
            txt_tell.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["tell"].Value.ToString());
            txt_mobile.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["mobile"].Value.ToString());
            txt_email.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["email"].Value.ToString());
            cmb_workname.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["workname"].Value.ToString());
            cmb_miartalStatus.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["maritalstatus"].Value.ToString());
            txt_address.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["address"].Value.ToString());
            txt_description.Text = Convert.ToString(dgw_customers.SelectedRows[0].Cells["description"].Value.ToString());
            chk_state.Checked = Convert.ToBoolean(dgw_customers.SelectedRows[0].Cells["state"].Value.ToString());

            if (_customer_flag == customerFlag.admin)
            {
                chk_flagAdmin.Checked = Convert.ToBoolean(dgw_customers.SelectedRows[0].Cells["flagadmin"].Value.ToString());
            }
            //
            txt_username.Enabled = false;
            btn_back.Enabled = false;
            btn_delete.Enabled = false;
            btn_editFinal.Enabled = true;
            ctm_deleting.Enabled = false;
            groupPanel1.Enabled = false;


        }

        private void btn_editFinal_Click(object sender, EventArgs e)
        {
            tbl_Customers t = database.tbl_Customers.First(c => c.Username == txt_username.Text);
            t.Password = txt_password.Text;
            t.Name = txt_name.Text;
            t.Family = txt_family.Text;
            t.Birth = txt_birth.Text;
            t.CodeMelli = txt_codeMelli.Text;
            t.Tell = txt_tell.Text;
            t.Mobile = txt_mobile.Text;
            t.Email = txt_email.Text;
            t.WorkName = cmb_workname.Text;
            t.MaritalStatus = cmb_miartalStatus.Text;
            t.Address = txt_address.Text;
            t.Description = txt_description.Text;
            t.State = chk_state.Checked;
            if (_customer_flag == customerFlag.officer)
            {
                t.OfficerValid = frm_Login.Uname;
            }
            if (_customer_flag==customerFlag.admin)
            {
                t.FlagAdmin = chk_flagAdmin.Checked;
            }


            database.SaveChanges();

            dgw_customers.DataSource = database.tbl_Customers.ToList();
            //
            txt_username.Enabled = true;
            btn_back.Enabled = true;
            btn_delete.Enabled = true;

            btn_editFinal.Enabled = false;
            ctm_deleting.Enabled = true;
            groupPanel1.Enabled = true;

            ResetItems();


        }

        private void rdo_SbyUname_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            txt_Search.NullText = "جست و جو بر اساس نام کاربری";
            txt_Search.RightToLeft = RightToLeft.No;
        }

        private void rdo_SbyCmelli_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            txt_Search.NullText = "جست و جو بر اساس کد ملی ";
            txt_Search.RightToLeft = RightToLeft.Yes;
        }

        private void rdo_SbyFamily_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            txt_Search.NullText = "جست و جو بر اساس نام خانوادگی";
            txt_Search.RightToLeft = RightToLeft.Yes;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            var SearchByUsername = database.tbl_Customers.Where(c => c.Username.Contains(txt_Search.Text));
            var SearchByCodeMelli = database.tbl_Customers.Where(c => c.CodeMelli.Contains(txt_Search.Text));
            var SearchByFamily = database.tbl_Customers.Where(c => c.Family.Contains(txt_Search.Text));
            if (rdo_SbyUname.IsChecked)
            {
                dgw_customers.DataSource = SearchByUsername.ToList();
            }
            else if (rdo_SbyCmelli.IsChecked)
            {
                dgw_customers.DataSource = SearchByCodeMelli.ToList();
            }
            else if (rdo_SbyFamily.IsChecked)
            {
                dgw_customers.DataSource = SearchByFamily.ToList();
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

        }

        private void frm_Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_editFinal.Enabled = true && txt_username.Enabled == false)
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

        private void frm_Customers_Activated(object sender, EventArgs e)
        {

        }

        private void dgw_customers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frm_Email f = new frm_Email();
            if (_customer_flag==customerFlag.admin)
            {
                f.txt_to.Text=Convert.ToString( dgw_customers.SelectedRows[0].Cells["email"].Value.ToString());
                AddEmail = Convert.ToString(dgw_customers.SelectedRows[0].Cells["email"].Value.ToString());
                this.Hide();
            }
        }


    }
}
