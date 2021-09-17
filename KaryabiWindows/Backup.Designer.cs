namespace KaryabiWindows
{
    partial class frm_Backup
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
            this.btn_Backup = new Telerik.WinControls.UI.RadButton();
            this.btn_Restore = new Telerik.WinControls.UI.RadButton();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Backup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Backup
            // 
            this.btn_Backup.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Backup.Location = new System.Drawing.Point(249, 130);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(94, 29);
            this.btn_Backup.TabIndex = 0;
            this.btn_Backup.Text = "پشتیبان گیری";
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Restore.Location = new System.Drawing.Point(78, 130);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(94, 29);
            this.btn_Restore.TabIndex = 0;
            this.btn_Restore.Text = "بازیابی اطلاعات";
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Location = new System.Drawing.Point(78, 56);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.Size = new System.Drawing.Size(265, 49);
            this.radProgressBar1.TabIndex = 1;
            // 
            // frm_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 212);
            this.Controls.Add(this.radProgressBar1);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.btn_Backup);
            this.Name = "frm_Backup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "پشتیان گیری و بازیابی داده ها";
            this.Load += new System.EventHandler(this.frm_Backup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Backup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_Backup;
        private Telerik.WinControls.UI.RadButton btn_Restore;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;

    }
}