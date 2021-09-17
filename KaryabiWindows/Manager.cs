using KaryabiWindows;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KaryabiWindows
{
    public partial class Frm_Manager : Telerik.WinControls.UI.RadForm
    {
    
        KaryabiDBEntities database = new KaryabiDBEntities();
        private void showall ()
        {
            dgw_manager.DataSource = database.tbl_Manager.ToList();
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            var Already = database.tbl_Manager.Where(c => c.Username == txt_username.Text);
            if (Already.Count() > 0)
            {
                MessageBox.Show("نام کاربری وارد شده تکراری میباشد");
                txt_username.Focus();
                txt_username.SelectAll();
                return;
            }
            else
            {
                tbl_Manager table=new tbl_Manager()
                {
                    Username=txt_username.Text,

                    Password=txt_pass.Text,
                    Name=txt_name.Text,
                    Family=txt_family.Text
                };
                database.tbl_Manager.Add(table);
                database.SaveChanges();
                MessageBox.Show("مدیر با موفقیت اضافه گردید ");
                txt_family.ResetText();
                txt_name.ResetText();
                txt_pass.ResetText();
                txt_username.ResetText();
                showall();

            }
        }

        private void frm_Manager_Load(object sender, EventArgs e)
        {
            showall();
        }

        private void ctm_delete_Click(object sender, EventArgs e)
        {
            string current = dgw_manager.CurrentRow.Cells["username"].Value.ToString();
            var Delete = database.tbl_Manager.First(c => c.Username == current);
            DialogResult dr;
            if (dgw_manager.RowCount==1)
            {
                MessageBox.Show("باید در جدول بیش از 2 نفر باشند ");
                return;
            }
            dr = MessageBox.Show("ایا میخواهید این مدیر را حذق نمایید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                database.tbl_Manager.Remove(Delete);
                database.SaveChanges();
                showall();
            }
        }

        private void dgw_manager_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgw_manager.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void ctm_edit_Click(object sender, EventArgs e)
        {
            btn_editFinal.Enabled = true;
            btn_insert.Enabled = false;
            ctm_delete.Enabled = false;
            txt_username.Enabled = false;
            try
            {
                txt_username.Text = Convert.ToString(dgw_manager.SelectedRows[0].Cells["username"].Value.ToString());
                txt_name.Text = Convert.ToString(dgw_manager.SelectedRows[0].Cells["name"].Value.ToString());
                txt_family.Text = Convert.ToString(dgw_manager.SelectedRows[0].Cells["family"].Value.ToString());
            }
            catch
            {

            }
        }

        private void btn_editFinal_Click(object sender, EventArgs e)
        {

            tbl_Manager t = database.tbl_Manager.First(c => c.Username == txt_username.Text);
            t.Username = txt_username.Text;
            t.Name = txt_name.Text;
            t.Family = txt_family.Text;
            t.Password = txt_pass.Text;
            database.SaveChanges();

            btn_editFinal.Enabled = false;
            btn_insert.Enabled = true;
            ctm_delete.Enabled = true;
            txt_username.Enabled = true;
            //************
            txt_family.ResetText();
            txt_name.ResetText();
            txt_pass.ResetText();
            txt_username.ResetText();
            showall();

        }

        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

        private override void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}

namespace Telerik
{
    public class WinControls
    {
        public class UI
        {
            public abstract class RadForm : RadFormBase
            {

#endregion

                private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.ListBox listBox1;
        private Telerik.WinControls.UI.RadButton btn_attach;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox txt_cc;
        private Telerik.WinControls.UI.RadTextBox txt_bcc;
        private Telerik.WinControls.UI.RadTextBox txt_subject;
        private Telerik.WinControls.UI.RadTextBox txt_name;
        private Telerik.WinControls.UI.RadTextBox txt_body;
        private Telerik.WinControls.UI.RadButton btn_send;

                private void btn_attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog()==DialogResult.OK)
            {
                listBox1.Items.Add(op.FileName);
            }
        }

                private abstract void Btn_send_Click(object sender, EventArgs e);

                private void frm_Email_Activated(object sender, EventArgs e)
        {

            txt_to.Text = frm_Customers.AddEmail;
        }

        private void frm_Email_Load(object sender, EventArgs e)
        {
            frm_LoginEmail f = new frm_LoginEmail();
            f.ShowDialog();
        }

                private abstract void InitializeComponent();

                private void txt_to_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_to.Text ==string.Empty && e.KeyCode==Keys.Enter)
            {
                frm_Customers f = new frm_Customers(customerFlag.admin);
                f.ShowDialog();

                
            }
        }
            }
        }
    }
}