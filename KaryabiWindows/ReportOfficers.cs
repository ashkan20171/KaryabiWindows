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
    public partial class frm_ReportOfficers : Telerik.WinControls.UI.RadForm
    {
        public frm_ReportOfficers()
        {
            InitializeComponent();
        }
        KaryabiDBEntities database = new KaryabiDBEntities();
        private void frn_ReportOfficers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.tbl_Officers' table. You can move, or remove it, as needed.
            this.tbl_OfficersTableAdapter.Fill(this.dataSet1.tbl_Officers);

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_OfficersTableAdapter tbl=new DataSet1TableAdapters.tbl_OfficersTableAdapter();
            stiReport1.Load(Application.StartupPath + @"\Report\rptOfficers.mrt");
           // tblOfficersBindingSource.DataSource = database.tbl_Officers.ToList();
            stiReport1.RegData(dataSet1.tbl_Officers);
            stiReport1.Show();
        }
    }
}
