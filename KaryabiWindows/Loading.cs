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
    public partial class frm_Loading : Telerik.WinControls.UI.RadForm
    {
        public frm_Loading()
        {
            InitializeComponent();
            timer1.Start();
        }
        string text = "به سیستم مدیریت جامع کاریابی دانشجویار خوش امدید\n" + "از اینکه ما را انتخاب کرده اید متشکریم";
        int time = 0;
        private void frm_Loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.02;
            }
            time++;
            lbl_text.Text = text.Substring(0, time);
            if (time == text.Length)
            {
                timer1.Stop();
                this.Hide();
                frm_Login f = new frm_Login();
                f.ShowDialog();
            }
        }

        private void frm_Loading_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer1.Stop();
                this.Hide();
                frm_Login f = new frm_Login();
                f.ShowDialog();
            }
        }
    }
}
