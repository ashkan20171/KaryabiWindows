namespace KaryabiWindows
{
    partial class frm_TestIp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ping = new Telerik.WinControls.UI.RadButton();
            this.txt_IpOrName = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IpOrName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ping
            // 
            this.btn_ping.Location = new System.Drawing.Point(113, 97);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(86, 28);
            this.btn_ping.TabIndex = 0;
            this.btn_ping.Text = "Ping";
            this.btn_ping.Click += new System.EventHandler(this.btn_ping_Click);
            // 
            // txt_IpOrName
            // 
            this.txt_IpOrName.Location = new System.Drawing.Point(67, 42);
            this.txt_IpOrName.Name = "txt_IpOrName";
            this.txt_IpOrName.NullText = "192.168.255.255";
            this.txt_IpOrName.Size = new System.Drawing.Size(181, 20);
            this.txt_IpOrName.TabIndex = 0;
            this.txt_IpOrName.TabStop = false;
            // 
            // frm_TestIp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 164);
            this.Controls.Add(this.txt_IpOrName);
            this.Controls.Add(this.btn_ping);
            this.Name = "frm_TestIp";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "بررزسی اتصال کامپیوترها";
            this.Load += new System.EventHandler(this.frm_TestIp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_ping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IpOrName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_ping;
        private Telerik.WinControls.UI.RadTextBox txt_IpOrName;

    }
}