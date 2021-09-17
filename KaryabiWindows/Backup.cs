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
using Microsoft.SqlServer.Management;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data;
using System.Data.SqlClient;


namespace KaryabiWindows
{
    public partial class frm_Backup : Telerik.WinControls.UI.RadForm
    {
        exitApplication _exit_app;
        public frm_Backup(exitApplication ExitApp)
        {
            this._exit_app =ExitApp;
            InitializeComponent();
        }
        public string ConBackup = "Data Source=192.168.1.12,1433;Network Library=DBMSSOCN;initial catalog=KaryabiDB;user id=admin;password=adminadmin;MultipleActiveResultSets=True;App=EntityFramework";
        public string ConRestore = "Data Source=192.168.1.12,1433;Network Library=DBMSSOCN;user id=admin;password=adminadmin;MultipleActiveResultSets=True;App=EntityFramework";
        private void frm_Backup_Load(object sender, EventArgs e)
        {

        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConBackup))
            {
                ServerConnection srvConn = new ServerConnection(con);
                Server srvr = new Server(srvConn);

                if (srvr != null)
                {
                    try
                    {
                        Backup backupdb = new Backup();
                        backupdb.Action = BackupActionType.Database;
                        backupdb.Database = "KaryabiDB";
                        SaveFileDialog savefd = new SaveFileDialog();
                        savefd.Filter = "Backup File (*.Bak)|*.Bak";
                        savefd.FileName = DateTime.Now.ToString("ddMMyyyy_HHmmss");
                        Nullable<bool> result =Convert.ToBoolean( savefd.ShowDialog());
                        if (result == true)
                        {
                            BackupDeviceItem bkpDevice = new BackupDeviceItem(savefd.FileName, DeviceType.File);
                            backupdb.Devices.Add(bkpDevice);
                            backupdb.SqlBackup(srvr);

                            for (int i = 0; i < 100; i++)
                            {
                                radProgressBar1.Value1 = i;
                                radProgressBar1.Text = "در حال پشتیبان گیری";

                            }
                            MessageBox.Show("عملیات پتشبان گیر یا موفقیت انجام شد", "Backup Successully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            radProgressBar1.Value1 = 0;
                            radProgressBar1.Text = "";

                        }
                    }
                    catch
                    {
                        MessageBox.Show("خطا در پشتیبان گیری", "Fail Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (_exit_app==exitApplication.exit)
            {
                Application.ExitThread();
            }
            else if (_exit_app==exitApplication.notexit)
            {
                return;
            }
              

        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
              SqlConnection.ClearAllPools();
            using (SqlConnection con = new SqlConnection(ConRestore))
            {
                ServerConnection srvConn = new ServerConnection(con);
                Server srvr = new Server(srvConn);

                if (srvr != null)
                {
                    try
                    {
                        Restore restoredb = new Restore();
                        restoredb.Action = RestoreActionType.Database;
                        restoredb.Database = "KaryabiDB";
                        OpenFileDialog openfd = new OpenFileDialog();
                        openfd.Filter = "Backup File (*.Bak)|*.Bak";

                        Nullable<bool> result =Convert.ToBoolean( openfd.ShowDialog());
                        if (result == true)
                        {
                            BackupDeviceItem bkpDevice = new BackupDeviceItem(openfd.FileName, DeviceType.File);

                            restoredb.Devices.Add(bkpDevice);
                            restoredb.ReplaceDatabase = true;
                            restoredb.SqlRestore(srvr);

                               for (int i = 0; i < 100; i++)
                            {
                                radProgressBar1.Value1 = i;
                                radProgressBar1.Text = "در حال  بازیابی اطلاعات";

                            }
                            MessageBox.Show("عملیات بازیابی اطلاعات با موفقیت انجام شد","Restor SuccessFully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            radProgressBar1.Value1 = 1;
                            radProgressBar1.Text ="";
                            
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("خطا در بازیابی اطلاعات", "Fail Restort", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
