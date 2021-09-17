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
using System.Data.SqlClient;

namespace KaryabiWindows
{
    public partial class frm_Login : Telerik.WinControls.UI.RadForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        KaryabiDBEntities database = new KaryabiDBEntities();
        public static string Username, Fullname;
        public static string Uname, FuName, Permissoion;
      
        private void frm_Login_Load(object sender, EventArgs e)
        {
            try
            {

                string checkLogin = "select * from tbl_Manager Where Login='True'";
                DataTable dtlogin = new DataTable();
                dtlogin = Function.DoQuery(checkLogin);
                //
                string checkEnable = "select * from tbl_Users Where Flag='True'";
                DataTable dtEnable = new DataTable();
                dtEnable = Function.DoQuery(checkEnable);

                if (dtlogin.Rows.Count != 0)
                {
                    if (dtEnable.Rows.Count != 0)
                    {
                        lbl_State.Text = "فعال";
                    }
                    else
                    {
                        lbl_State.Text = "غیر فعال";
                    }

                    lbl_loginAdmin.Text = "[وارد شده]";


                }
                else
                {
                    if (dtEnable.Rows.Count != 0)
                    {
                        lbl_State.Text = "فعال";
                    }
                    else
                    {
                        lbl_State.Text = "غیر فعال";
                    }
                    lbl_loginAdmin.Text = "[وارد نشده]";


                }
            }
            catch
            {
             //   MessageBox.Show("Database Error Appliation runned After Restart ");
                SqlConnection con = new SqlConnection();
                con.ConnectionString =KaryabiWindows.Properties.Settings.Default.DBMasterConString;
                con.Open();
                string QAttachDB = "USE master;" +
                    "EXECUTE sp_attach_db @dbname=N'KaryabiDB' , " +
                    "@filename1=N'" + System.Environment.CurrentDirectory + @"\KaryabiDB.mdf' ," +
                    "@filename2=N'" + System.Environment.CurrentDirectory + @"\KaryabiDB_log.ldf'";
                SqlCommand cmd = new SqlCommand(QAttachDB, con);
                cmd.CommandTimeout = 100;
                cmd.ExecuteNonQuery();
                con.Close();
                Application.Restart();
            }
           
           
           
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_UsersTableAdapter tbl = new DataSet1TableAdapters.tbl_UsersTableAdapter();
            DataSet1TableAdapters.tbl_ManagerTableAdapter tbl2 = new DataSet1TableAdapters.tbl_ManagerTableAdapter();

           
            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                errorProvider1.SetError(txt_username, "نام کاربری را وارد نمایید");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_password, "رمز عبور را وارد نمایید");
                return;
            }
            else
            {
                string selAdmin = "select * from tbl_Manager Where Username='" + txt_username.Text + "'";
                DataTable dt = new DataTable();
                dt = Function.DoQuery(selAdmin);
                errorProvider1.Clear();
                if (chk_loginManager.Checked == true)
                {
                    var loginAdmin = database.tbl_Manager.Where(c => c.Username == txt_username.Text && c.Password == txt_password.Text);
                    if (loginAdmin.Count() != 0)
                    {
                        Username = dt.Rows[0]["Username"].ToString();
                        Fullname = dt.Rows[0]["Name"].ToString() + " " + dt.Rows[0]["Family"].ToString();
                       
                        tbl.EnableUsers(true);
                        tbl2.LoginedAdmin(true);
                        this.Hide();
                        new frm_MainManager().ShowDialog();
                       
                    }
                    else
                    {
                      
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (chk_loginManager.Checked == false)
                {
                    string selUser = "select * from tbl_Users Where Username='" + txt_username.Text + "'";
                    DataTable dtUser = new DataTable();
                    dtUser = Function.DoQuery(selUser);
                    //*****
                    string stateUser = "select * from tbl_Users Where Username='"+txt_username.Text +"'AND Password='"+txt_password.Text+"'AND Flag='False'";
                    DataTable dtstateUser = new DataTable();
                    dtstateUser = Function.DoQuery(stateUser);
                    //*****

                    var loginUsers = database.tbl_Users.Where(c => c.Username == txt_username.Text && c.Password == txt_password.Text && c.Flag == true);
                    if (loginUsers.Count() != 0)
                    {
                      
                        Uname = dtUser.Rows[0]["Username"].ToString();
                        FuName = dtUser.Rows[0]["Fullname"].ToString();
                        Permissoion = dtUser.Rows[0]["Permission"].ToString();
                        frm_MainOfficers f = new frm_MainOfficers();
                        this.Hide();
                        f.ShowDialog();
                     

                    }
                    else
                    {
                        if (dtstateUser.Rows.Count != 0)
                        {
                            MessageBox.Show("کد کاربری شما غیر فعال است", " User Disable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void frm_Login_Activated(object sender, EventArgs e)
        {
        
        }

        private void chk_loginManager_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
         
        }
    }
}
