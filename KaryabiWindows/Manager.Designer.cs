namespace KaryabiWindows
{
    partial class Frm_Manager
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
            this.dgw_manager = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_username = new Telerik.WinControls.UI.RadTextBox();
            this.btn_insert = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txt_pass = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txt_name = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txt_family = new Telerik.WinControls.UI.RadTextBox();
            this.btn_editFinal = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_manager)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_family)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_manager
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_manager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_manager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radif,
            this.username,
            this.name,
            this.family,
            this.loigin});
            this.dgw_manager.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_manager.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_manager.EnableHeadersVisualStyles = false;
            this.dgw_manager.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgw_manager.Location = new System.Drawing.Point(18, 214);
            this.dgw_manager.MultiSelect = false;
            this.dgw_manager.Name = "dgw_manager";
            this.dgw_manager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_manager.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgw_manager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_manager.Size = new System.Drawing.Size(525, 150);
            this.dgw_manager.TabIndex = 0;
            this.dgw_manager.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgw_manager_CellFormatting);
            // 
            // radif
            // 
            this.radif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.radif.HeaderText = "ردیف";
            this.radif.Name = "radif";
            this.radif.Width = 57;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.username.DataPropertyName = "Username";
            this.username.HeaderText = "نام کاربری";
            this.username.Name = "username";
            this.username.Width = 78;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.Width = 60;
            // 
            // family
            // 
            this.family.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.family.DataPropertyName = "Family";
            this.family.HeaderText = "نام خانوادگی";
            this.family.Name = "family";
            // 
            // loigin
            // 
            this.loigin.DataPropertyName = "Login";
            this.loigin.HeaderText = "لوگین";
            this.loigin.Name = "loigin";
            this.loigin.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctm_delete,
            this.ctm_edit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 60);
            // 
            // ctm_delete
            // 
            this.ctm_delete.Image = global::KaryabiWindows.Properties.Resources._1324747694_DeleteRed;
            this.ctm_delete.Name = "ctm_delete";
            this.ctm_delete.Size = new System.Drawing.Size(114, 28);
            this.ctm_delete.Text = "حذف";
            this.ctm_delete.Click += new System.EventHandler(this.ctm_delete_Click);
            // 
            // ctm_edit
            // 
            this.ctm_edit.Image = global::KaryabiWindows.Properties.Resources.Refresh;
            this.ctm_edit.Name = "ctm_edit";
            this.ctm_edit.Size = new System.Drawing.Size(114, 28);
            this.ctm_edit.Text = "ویرایش";
            this.ctm_edit.Click += new System.EventHandler(this.ctm_edit_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(507, 18);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(73, 31);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "نام کاربری : ";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_username.Location = new System.Drawing.Point(339, 16);
            this.txt_username.Name = "txt_username";
            this.txt_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_username.Size = new System.Drawing.Size(151, 27);
            this.txt_username.TabIndex = 2;
            this.txt_username.TabStop = false;
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_insert.Location = new System.Drawing.Point(390, 154);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(110, 33);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "ثبت مدیر";
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.Location = new System.Drawing.Point(244, 18);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(61, 31);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "رمز عبور : ";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_pass.Location = new System.Drawing.Point(76, 16);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pass.Size = new System.Drawing.Size(151, 27);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.TabStop = false;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.Location = new System.Drawing.Point(507, 67);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(36, 31);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "نام : ";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_name.Location = new System.Drawing.Point(339, 65);
            this.txt_name.Name = "txt_name";
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_name.Size = new System.Drawing.Size(151, 27);
            this.txt_name.TabIndex = 2;
            this.txt_name.TabStop = false;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel4.Location = new System.Drawing.Point(244, 69);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel4.Size = new System.Drawing.Size(87, 31);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "نام خانوادگی : ";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_family
            // 
            this.txt_family.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_family.Location = new System.Drawing.Point(76, 67);
            this.txt_family.Name = "txt_family";
            this.txt_family.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_family.Size = new System.Drawing.Size(151, 27);
            this.txt_family.TabIndex = 2;
            this.txt_family.TabStop = false;
            // 
            // btn_editFinal
            // 
            this.btn_editFinal.Enabled = false;
            this.btn_editFinal.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_editFinal.Location = new System.Drawing.Point(209, 154);
            this.btn_editFinal.Name = "btn_editFinal";
            this.btn_editFinal.Size = new System.Drawing.Size(110, 33);
            this.btn_editFinal.TabIndex = 3;
            this.btn_editFinal.Text = "ویرایش نهایی";
            this.btn_editFinal.Click += new System.EventHandler(this.btn_editFinal_Click);
            // 
            // frm_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 376);
            this.Controls.Add(this.btn_editFinal);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_family);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dgw_manager);
            this.Name = "frm_Manager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "مدیریت مدیرها";
            this.Load += new System.EventHandler(this.frm_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_manager)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_family)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgw_manager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_delete;
        private System.Windows.Forms.ToolStripMenuItem ctm_edit;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txt_username;
        private Telerik.WinControls.UI.RadButton btn_insert;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txt_pass;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txt_name;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txt_family;
        private Telerik.WinControls.UI.RadButton btn_editFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn loigin;

    }
}