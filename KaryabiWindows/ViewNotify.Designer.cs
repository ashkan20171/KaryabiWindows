namespace KaryabiWindows
{
    partial class frm_ViewNotify
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_back = new Telerik.WinControls.UI.RadButton();
            this.dgw_notifyPuPr = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_view = new System.Windows.Forms.ToolStripMenuItem();
            this.rdo_PrivateNotify = new Telerik.WinControls.UI.RadRadioButton();
            this.rdo_PublicNotify = new Telerik.WinControls.UI.RadRadioButton();
            this.txt_ViewNotify = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_notifyPuPr)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdo_PrivateNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdo_PublicNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ViewNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(445, 167);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(66, 34);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "بازگشت";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgw_notifyPuPr
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_notifyPuPr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgw_notifyPuPr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_notifyPuPr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radif,
            this.id,
            this.officerid,
            this.description});
            this.dgw_notifyPuPr.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_notifyPuPr.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgw_notifyPuPr.EnableHeadersVisualStyles = false;
            this.dgw_notifyPuPr.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgw_notifyPuPr.Location = new System.Drawing.Point(12, 211);
            this.dgw_notifyPuPr.MultiSelect = false;
            this.dgw_notifyPuPr.Name = "dgw_notifyPuPr";
            this.dgw_notifyPuPr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_notifyPuPr.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgw_notifyPuPr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_notifyPuPr.Size = new System.Drawing.Size(499, 128);
            this.dgw_notifyPuPr.TabIndex = 1;
            this.dgw_notifyPuPr.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgw_notifyPuPr_CellFormatting);
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
            this.officerid.DataPropertyName = "OfficerId";
            this.officerid.HeaderText = "کد کارمندی";
            this.officerid.Name = "officerid";
            this.officerid.Visible = false;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "متن اعلانیه";
            this.description.Name = "description";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctm_view});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 32);
            // 
            // ctm_view
            // 
            this.ctm_view.Image = global::KaryabiWindows.Properties.Resources.search_mail_512;
            this.ctm_view.Name = "ctm_view";
            this.ctm_view.Size = new System.Drawing.Size(117, 28);
            this.ctm_view.Text = "مشاهده";
            this.ctm_view.Click += new System.EventHandler(this.ctm_view_Click);
            // 
            // rdo_PrivateNotify
            // 
            this.rdo_PrivateNotify.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdo_PrivateNotify.Location = new System.Drawing.Point(331, 9);
            this.rdo_PrivateNotify.Name = "rdo_PrivateNotify";
            this.rdo_PrivateNotify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdo_PrivateNotify.Size = new System.Drawing.Size(180, 27);
            this.rdo_PrivateNotify.TabIndex = 2;
            this.rdo_PrivateNotify.TabStop = true;
            this.rdo_PrivateNotify.Text = "نمایش اعلانیه های از مدیر به شما";
            this.rdo_PrivateNotify.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.rdo_PrivateNotify.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdo_PrivateNotify_ToggleStateChanged);
            // 
            // rdo_PublicNotify
            // 
            this.rdo_PublicNotify.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdo_PublicNotify.Location = new System.Drawing.Point(330, 37);
            this.rdo_PublicNotify.Name = "rdo_PublicNotify";
            this.rdo_PublicNotify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdo_PublicNotify.Size = new System.Drawing.Size(181, 27);
            this.rdo_PublicNotify.TabIndex = 2;
            this.rdo_PublicNotify.Text = "نمایش اعلانیه های عمومی از مدیر";
            this.rdo_PublicNotify.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdo_PublicNotify_ToggleStateChanged);
            // 
            // txt_ViewNotify
            // 
            this.txt_ViewNotify.AutoSize = false;
            this.txt_ViewNotify.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ViewNotify.Location = new System.Drawing.Point(12, 70);
            this.txt_ViewNotify.Multiline = true;
            this.txt_ViewNotify.Name = "txt_ViewNotify";
            this.txt_ViewNotify.ReadOnly = true;
            this.txt_ViewNotify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ViewNotify.Size = new System.Drawing.Size(499, 91);
            this.txt_ViewNotify.TabIndex = 3;
            this.txt_ViewNotify.TabStop = false;
            // 
            // frm_ViewNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 351);
            this.Controls.Add(this.txt_ViewNotify);
            this.Controls.Add(this.rdo_PublicNotify);
            this.Controls.Add(this.rdo_PrivateNotify);
            this.Controls.Add(this.dgw_notifyPuPr);
            this.Controls.Add(this.btn_back);
            this.Name = "frm_ViewNotify";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "مشاهده اعلانیه ها";
            this.Load += new System.EventHandler(this.frm_ViewNotify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_notifyPuPr)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdo_PrivateNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdo_PublicNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ViewNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_back;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgw_notifyPuPr;
        private Telerik.WinControls.UI.RadRadioButton rdo_PrivateNotify;
        private Telerik.WinControls.UI.RadRadioButton rdo_PublicNotify;
        private Telerik.WinControls.UI.RadTextBox txt_ViewNotify;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn officerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_view;
    }
}