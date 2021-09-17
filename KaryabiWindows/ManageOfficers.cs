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
using System.IO;
using System.Globalization;
namespace KaryabiWindows
{
    public partial class frm_manageOfficers : Telerik.WinControls.UI.RadForm
    {
        officeradd _officer_Add;
        public frm_manageOfficers(officeradd officeradd)
        {
            InitializeComponent();
        }
        KaryabiDBEntities database = new KaryabiDBEntities();

        private void ClearItems()
        {
            txt_address.ResetText();
            txt_birth.ResetText();
            txt_codeMelli.ResetText();
            txt_family.ResetText();
            txt_madark.ResetText();
            txt_mobile.ResetText();
            txt_name.ResetText();
            txt_tell.ResetText();
            txt_inCompany.ResetText();
            pictureBox1.Image = KaryabiWindows.Properties.Resources._1324746922_User;
            cmb_TheWork.SelectedIndex = 0;
        }
        private void CurrnetDate()
        {
            DateTime dt = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();
            string Date = pc.GetYear(dt).ToString("0000/") + pc.GetMonth(dt).ToString("00/") + pc.GetDayOfMonth(dt).ToString("00");
            txt_inCompany.Text = Date;
        }
        private void GetMaxIdOfficer()
        {
            DataSet1TableAdapters.tbl_OfficersTableAdapter tbl_officers = new DataSet1TableAdapters.tbl_OfficersTableAdapter();
            txt_id.Text = tbl_officers.GetMaxIdOfficers().ToString();
        }
        private void BindTheWork()
        {

            var Showall = from a in database.tbl_CatWork select a.WorkName;
            cmb_TheWork.DataSource = Showall.ToList();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {


            var AlreadyId = database.tbl_Officers.Where(i => i.OfficerId == txt_id.Text);
            if (AlreadyId.Count() != 0)
            {
                MessageBox.Show("کد کارمندی وارد شده تکراری می باشد\n " + " کد کارمندی به طور اتوماتیک تغییر کرد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
                //  GetMaxIdOfficer();
                return;
            }
            else
            {
                if (txt_id.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_id, "کد کارمندی را وارد کنید");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_name.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txt_name, "نام کارمند را وارد کنید");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_family.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txt_family, " نام خانوادگی کارمند را وارد کنید");
                    return;
                }

                /* errorProvider1.SetError(txt_id,"");
                 errorProvider1.SetError(txt_family, "");
                 errorProvider1.SetError(txt_name, ""); */

                errorProvider1.Clear();

                //************************************
                #region SaveImgInMemory
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] imgdata = ms.GetBuffer();
                #endregion
                tbl_Officers table = new tbl_Officers()
                {
                    OfficerId = txt_id.Text,
                    Fname = txt_name.Text,
                    Lname = txt_family.Text,
                    Birth = txt_birth.Text,
                    TheWork = cmb_TheWork.Text,
                    CodeMelli = txt_codeMelli.Text,
                    Tell = txt_tell.Text,
                    Mobile = txt_mobile.Text,
                    DateInCompany = txt_inCompany.Text,
                    Madrak = txt_madark.Text,
                    Image = imgdata,
                    Address = txt_address.Text
                };
                database.tbl_Officers.Add(table);
                database.SaveChanges();
                GetMaxIdOfficer();
                dgw_Officers.DataSource = database.tbl_Officers.ToList();
                MessageBox.Show("اطلاعات کارمند با موفقیت ذخیره گردید", "ذخیره اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearItems();
            }

        }

        private void btn_ChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.FilterIndex = 1;
            op.Filter = "Jpeg Files |*.jpeg| Png Files |*.Png| Jpg Files |*.jpg| All Files |*.* ";

            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = op.FileName;

            }
            op.ShowDialog();

        }

        private void frm_manageOfficers_Load(object sender, EventArgs e)
        {
            CurrnetDate();
            dgw_Officers.DataSource = database.tbl_Officers.ToList();
            GetMaxIdOfficer();
            BindTheWork();
            cmb_TheWork.SelectedIndex = 0;
        }

        private void dgw_Officers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgw_Officers.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void ctm_delete_Click(object sender, EventArgs e)
        {
           
            
            string Currentid = dgw_Officers.CurrentRow.Cells[1].Value.ToString();

            var Del = database.tbl_Officers.First(c => c.OfficerId == Currentid);

            string Qinfo = "select * from tbl_Officers where OfficerId='" + Currentid + "' ";
            DataTable dt = new DataTable();
            dt = Function.DoQuery(Qinfo);

            DialogResult dr;
            dr = MessageBox.Show("ایا میخواهید کارمند "+" [ "+ dt.Rows[0]["Fname"] + " " + dt.Rows[0]["Lname"] + "]" + "را حذف نمایید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
         
            if (dr == DialogResult.Yes)
            {
                database.tbl_Officers.Remove(Del);
                database.SaveChanges();
                dgw_Officers.DataSource = database.tbl_Officers.ToList();
                GetMaxIdOfficer();
            }
        }

        private void txt_SbyId_TextChanged(object sender, EventArgs e)
        {
            var Search = database.tbl_Officers.Where(c => c.OfficerId.Contains(txt_SbyId.Text));
            dgw_Officers.DataSource = Search.ToList();
        }

        private void txt_SbyName_TextChanged(object sender, EventArgs e)
        {
            var Search = database.tbl_Officers.Where(c => c.Fname.Contains(txt_SbyName.Text));
            dgw_Officers.DataSource = Search.ToList();
        }

        private void txt_SbyFamily_TextChanged(object sender, EventArgs e)
        {
            var Search = database.tbl_Officers.Where(c => c.Lname.Contains(txt_SbyFamily.Text));
            dgw_Officers.DataSource = Search.ToList();
        }

        byte[] imgdata;
        private void ctm_edit_Click(object sender, EventArgs e)
        {
            txt_id.Text = Convert.ToString(dgw_Officers.SelectedRows[0].Cells["officerIdd"].Value.ToString());
            txt_name.Text = Convert.ToString(dgw_Officers.SelectedRows[0].Cells["fnamee"].Value.ToString());
            txt_family.Text = Convert.ToString(dgw_Officers.SelectedRows[0].Cells["lnamee"].Value.ToString());
            txt_birth.Text = Convert.ToString(dgw_Officers.SelectedRows[0].Cells["birth"].Value.ToString());
            cmb_TheWork.Text = Convert.ToString(dgw_Officers.SelectedRows[0].Cells["theWork"].Value.ToString());
            txt_codeMelli.Text = Convert.ToString(dgw_Officers.SelectedRows[0].Cells["codemelli"].Value.ToString());
            txt_tell.Text = Convert.ToString(dgw_Officers.SelectedRows[0].Cells["tell"].Value.ToString());
            txt_mobile.Text = Convert.ToString(dgw_Officers.SelectedRows[0].Cells["mobile"].Value.ToString());
            txt_inCompany.Text = Convert.ToString(dgw_Officers.SelectedRows[0].Cells["dateincompany"].Value.ToString());
            txt_madark.Text = Convert.ToString(dgw_Officers.SelectedRows[0].Cells["madrak"].Value.ToString());
            txt_address.Text = Convert.ToString(dgw_Officers.SelectedRows[0].Cells["address"].Value.ToString());

            
            try
            {
                string Current = dgw_Officers.CurrentRow.Cells[1].Value.ToString();
                var Currentimg = database.tbl_Officers.First(c => c.OfficerId == Current);
                 imgdata = Currentimg.Image.ToArray();
                 MemoryStream ms = new MemoryStream(imgdata);
                 pictureBox1.Image = Image.FromStream(ms);
            }
            catch { }
           

            txt_id.Enabled = false;
            btn_insert.Enabled = false;
            btn_EditFinal.Enabled = true;
            ctm_delete.Enabled = false;
            txt_SbyId.Enabled = false;
            txt_SbyName.Enabled = false;
            txt_SbyFamily.Enabled = false;

        }

        private void btn_EditFinal_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] imgdata = ms.GetBuffer();

            tbl_Officers t = database.tbl_Officers.First(c => c.OfficerId == txt_id.Text);
            t.Fname = txt_name.Text;
            t.Lname = txt_family.Text;
            t.Birth = txt_birth.Text;
            t.TheWork = cmb_TheWork.Text;
            t.CodeMelli = txt_codeMelli.Text;
            t.Tell = txt_tell.Text;
            t.Mobile = txt_mobile.Text;
            t.DateInCompany = txt_inCompany.Text;
            t.Madrak = txt_madark.Text;
            t.Image = imgdata;
            t.Address = txt_address.Text;
            database.SaveChanges();
            dgw_Officers.DataSource = database.tbl_Officers.ToList();
            //********
            string Currentid = txt_id.Text;
            string Qinfo = "select * from tbl_Officers where OfficerId='" + Currentid + "' ";
            DataTable dt = new DataTable();
            dt = Function.DoQuery(Qinfo);
            //********
            MessageBox.Show("اطلاعات کارمند"+"[ "+ dt.Rows[0]["Fname"] +" "+ dt.Rows[0]["Lname"] +"] " +" با موفقیت ویرایش گردید", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_id.Enabled = true;
            btn_insert.Enabled = true;
            btn_EditFinal.Enabled = false;
            ctm_delete.Enabled = true ;
            //
            txt_SbyId.Enabled = true;
            txt_SbyName.Enabled = true;
            txt_SbyFamily.Enabled = true;
            ClearItems();
            GetMaxIdOfficer();
           
        }

        private void txt_codeMelli_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_manageOfficers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_EditFinal.Enabled = true && txt_id.Enabled == false)
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

        private void txt_tell_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void txt_tell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;

        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void txt_codeMelli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void cmb_TheWork_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public static string OfficerId, Fname, Lname;
        private void dgw_Officers_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (_officer_Add == officeradd.user)
            {
                frm_Users f = new frm_Users();
                f.txt_username.Text = dgw_Officers.SelectedRows[0].Cells["officerIdd"].Value.ToString();
                f.txt_fullname.Text = dgw_Officers.CurrentRow.Cells["fnamee"].Value.ToString() + " " +
                dgw_Officers.CurrentRow.Cells["lnamee"].Value.ToString();

                OfficerId = dgw_Officers.SelectedRows[0].Cells["officerIdd"].Value.ToString();
                Fname = dgw_Officers.CurrentRow.Cells["fnamee"].Value.ToString();
                Lname = dgw_Officers.CurrentRow.Cells["lnamee"].Value.ToString();
                this.Hide();
            }
            else if (_officer_Add==officeradd.notify)
            {
                frm_Notification f = new frm_Notification();
                f.txt_officerId.Text = dgw_Officers.SelectedRows[0].Cells["officeridd"].Value.ToString();
                OfficerId = dgw_Officers.SelectedRows[0].Cells["officerIdd"].Value.ToString();
                this.Hide();

            }
           
        }

        public static implicit operator ContainerControl(frm_manageOfficers v)
        {
            throw new NotImplementedException();
        }
    }
}
