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
    public partial class frm_Users : Telerik.WinControls.UI.RadForm
    {
        public frm_Users()
        {
            InitializeComponent();
        }
        KaryabiDBEntities database = new KaryabiDBEntities();
        private void ClearItmes()
        {
            txt_fullname.ResetText();
            txt_pass.ResetText();
            txt_pass2.ResetText();
            txt_username.ResetText();
            chk_flag.Checked = false;
            cmb_permission.SelectedIndex = 0;
        }
        private void frm_Users_Load(object sender, EventArgs e)
        {
            cmb_permission.SelectedIndex = 0;
            dgw_users.DataSource = database.tbl_Users.ToList();
        }

        private void dgw_users_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgw_users.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void frm_Users_Activated(object sender, EventArgs e)
        {
            txt_username.Text = frm_manageOfficers.OfficerId;
            txt_fullname.Text = frm_manageOfficers.Fname + " " + frm_manageOfficers.Lname;

        }

        private void txt_username_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {

            if (txt_username.Text == "" && e.KeyCode == Keys.Enter)
            {
                frm_manageOfficers f = new frm_manageOfficers(officeradd.user);
                f.ShowDialog();
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            var Already = database.tbl_Users.Where(c => c.Username == txt_username.Text);
            if (Already.Count() > 0)
            {
                MessageBox.Show("نام کاربری وارد شده تکراری می باشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txt_username.Text))
                {
                    errorProvider1.SetError(txt_username, "کد کاربری را وارد نمایید");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_fullname.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txt_fullname, "نام و نام خانوادگی را وارد نمایید");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_pass.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txt_pass, "رمز عبور را وارد نمایید");
                    return;
                }
                else if (txt_pass2.Text != txt_pass.Text)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txt_pass2, "کلمه عبور یا هم مطابقت ندارد");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                    tbl_Users table = new tbl_Users()
                    {
                        Username = txt_username.Text,
                        Password = txt_pass.Text,
                        FullName = txt_fullname.Text,
                        Flag = chk_flag.Checked,
                        Permission = cmb_permission.SelectedIndex
                    };
                    database.tbl_Users.Add(table);
                    database.SaveChanges();
                    MessageBox.Show("کاربر با موفقیت ذخیره گردید", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgw_users.DataSource = database.tbl_Users.ToList();
                    ClearItmes();
                }
            }


        }

        private void ctm_del_Click(object sender, EventArgs e)
        {
            string current = dgw_users.SelectedRows[0].Cells["username"].Value.ToString();

            var DelUser = database.tbl_Users.First(i => i.Username == current);
            DialogResult dr;
            dr = MessageBox.Show("ایا میخواهید این کاربر را حذف نمایید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                database.tbl_Users.Remove(DelUser);
                database.SaveChanges();
                dgw_users.DataSource = database.tbl_Users.ToList();

            }

        }

        private void ctm_edit_Click(object sender, EventArgs e)
        {


            txt_username.Text = Convert.ToString(dgw_users.SelectedRows[0].Cells["username"].Value.ToString());

            txt_fullname.Text = Convert.ToString(dgw_users.SelectedRows[0].Cells["fullname"].Value.ToString());
            chk_flag.Checked = Convert.ToBoolean(dgw_users.SelectedRows[0].Cells["flag"].Value);
            cmb_permission.SelectedIndex = int.Parse(dgw_users.SelectedRows[0].Cells["permission"].Value.ToString());
            //
            btn_delete.Enabled = false;
            btn_editFinal.Enabled = true;
            btn_insert.Enabled = false;
            txt_username.Enabled = false;
            ctm_del.Enabled = false;
        }

        private void btn_editFinal_Click(object sender, EventArgs e)
        {

            if (txt_username.Text == string.Empty)
            {
                MessageBox.Show("کد کاربری نمیتواند خالی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                tbl_Users t = database.tbl_Users.First(c => c.Username == txt_username.Text);
                t.FullName = txt_fullname.Text;
                t.Password = txt_pass.Text;
                t.Flag = chk_flag.Checked;
                t.Permission = cmb_permission.SelectedIndex;
                database.SaveChanges();
                dgw_users.DataSource = database.tbl_Users.ToList();
                //
                txt_username.Enabled = true;
                btn_delete.Enabled = true;
                btn_editFinal.Enabled = false;
                ctm_del.Enabled = true;
                btn_insert.Enabled = true;
                ClearItmes();
            }
        }

        private void frm_Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txt_username.Enabled == false && btn_editFinal.Enabled == true)
            {
                DialogResult dr;
                dr = MessageBox.Show(" شما در حال ویرایش اطلاعات هستید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
                else
                    this.Close();

            }
        }

        private void txt_SbyUserid_TextChanged(object sender, EventArgs e)
        {

            var Search = database.tbl_Users.Where(c => c.Username.Contains(txt_SbyUserid.Text));
            dgw_users.DataSource = Search.ToList();

        }

        private void txt_Sbyfullname_TextChanged(object sender, EventArgs e)
        {
            var Search = database.tbl_Users.Where(c => c.FullName.Contains(txt_Sbyfullname.Text));
            dgw_users.DataSource = Search.ToList();
        }

        private void dgw_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ctm_state_Click(object sender, EventArgs e)
        {



        }

        private void dgw_users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgw_users_SelectionChanged(object sender, EventArgs e)
        {
        

        }

        public static implicit operator ContainerControl(frm_Users v)
        {
            throw new NotImplementedException();
        }
    }
}
