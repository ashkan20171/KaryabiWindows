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
using System.Net.NetworkInformation;

namespace KaryabiWindows
{
    public partial class frm_TestIp : Telerik.WinControls.UI.RadForm
    {
        public frm_TestIp()
        {
            InitializeComponent();
        }

        private void frm_TestIp_Load(object sender, EventArgs e)
        {

        }

        private void btn_ping_Click(object sender, EventArgs e)
        {
            try
            {
                string IpOrName = txt_IpOrName.Text;
                int TimeOut = 5;
                Ping Ping = new Ping();
                PingReply Reply = Ping.Send(IpOrName, TimeOut);
                StringBuilder sb = new StringBuilder();
                sb.Append("Address Ip: " + Reply.Address.ToString());
                sb.Append("\nStatus: " + Reply.Status.ToString());
                sb.Append("\nTime: " + Reply.RoundtripTime.ToString());
                MessageBox.Show(sb.ToString(), "ResultIp " + IpOrName,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("چنین آدرس ای پی وجود ندارد","No Ip",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
