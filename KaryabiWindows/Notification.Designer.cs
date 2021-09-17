namespace KaryabiWindows
{
    partial class frm_Notification
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_send = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_id = new Telerik.WinControls.UI.RadTextBox();
            this.dgw_notify = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txt_officerId = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txt_description = new Telerik.WinControls.UI.RadTextBox();
            this.btn_selOfficer = new Telerik.WinControls.UI.RadButton();
            this.chk_sendAll = new Telerik.WinControls.UI.RadCheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_notify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_officerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_selOfficer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_sendAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_send.Location = new System.Drawing.Point(394, 186);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(84, 32);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "ارسال اعلانیه";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(484, 24);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(61, 27);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "کد اعلانیه : ";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_id.Location = new System.Drawing.Point(404, 24);
            this.txt_id.Name = "txt_id";
            this.txt_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_id.Size = new System.Drawing.Size(74, 27);
            this.txt_id.TabIndex = 2;
            this.txt_id.TabStop = false;
            // 
            // dgw_notify
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_notify.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_notify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_notify.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radif,
            this.id,
            this.officerid,
            this.description});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_notify.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_notify.EnableHeadersVisualStyles = false;
            this.dgw_notify.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgw_notify.Location = new System.Drawing.Point(23, 272);
            this.dgw_notify.MultiSelect = false;
            this.dgw_notify.Name = "dgw_notify";
            this.dgw_notify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_notify.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgw_notify.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_notify.Size = new System.Drawing.Size(522, 150);
            this.dgw_notify.TabIndex = 3;
            // 
            // radif
            // 
            this.radif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.radif.HeaderText = "ردیف";
            this.radif.Name = "radif";
            this.radif.Width = 57;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "کد اعلانیه";
            this.id.Name = "id";
            this.id.Width = 77;
            // 
            // officerid
            // 
            this.officerid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.officerid.DataPropertyName = "OfficerId";
            this.officerid.HeaderText = "کد کارمند";
            this.officerid.Name = "officerid";
            this.officerid.Width = 76;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "اعلانیه";
            this.description.Name = "description";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.Location = new System.Drawing.Point(303, 24);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(62, 27);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "کد کارمند : ";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_officerId
            // 
            this.txt_officerId.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_officerId.Location = new System.Drawing.Point(186, 24);
            this.txt_officerId.Modified = true;
            this.txt_officerId.Name = "txt_officerId";
            this.txt_officerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_officerId.Size = new System.Drawing.Size(111, 27);
            this.txt_officerId.TabIndex = 2;
            this.txt_officerId.TabStop = false;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.Location = new System.Drawing.Point(484, 96);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(70, 27);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "متن اعلانیه : ";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_description
            // 
            this.txt_description.AutoSize = false;
            this.txt_description.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_description.Location = new System.Drawing.Point(81, 96);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_description.Size = new System.Drawing.Size(397, 79);
            this.txt_description.TabIndex = 2;
            this.txt_description.TabStop = false;
            // 
            // btn_selOfficer
            // 
            this.btn_selOfficer.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_selOfficer.Location = new System.Drawing.Point(81, 24);
            this.btn_selOfficer.Name = "btn_selOfficer";
            this.btn_selOfficer.Size = new System.Drawing.Size(89, 27);
            this.btn_selOfficer.TabIndex = 0;
            this.btn_selOfficer.Text = "انتخاب کارمند";
            this.btn_selOfficer.Click += new System.EventHandler(this.btn_selOfficer_Click);
            // 
            // chk_sendAll
            // 
            this.chk_sendAll.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_sendAll.Location = new System.Drawing.Point(384, 63);
            this.chk_sendAll.Name = "chk_sendAll";
            this.chk_sendAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_sendAll.Size = new System.Drawing.Size(94, 27);
            this.chk_sendAll.TabIndex = 4;
            this.chk_sendAll.Text = "ارسال برای همه";
            this.chk_sendAll.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chk_sendAll_ToggleStateChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // frm_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 434);
            this.Controls.Add(this.chk_sendAll);
            this.Controls.Add(this.dgw_notify);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txt_officerId);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btn_selOfficer);
            this.Controls.Add(this.btn_send);
            this.Name = "frm_Notification";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ارسال اعلانیه";
            this.Activated += new System.EventHandler(this.frm_Notification_Activated);
            this.Load += new System.EventHandler(this.frm_Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_notify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_officerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_selOfficer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_sendAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_send;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txt_id;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgw_notify;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txt_description;
        private Telerik.WinControls.UI.RadButton btn_selOfficer;
        private Telerik.WinControls.UI.RadCheckBox chk_sendAll;
        public Telerik.WinControls.UI.RadTextBox txt_officerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn officerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}