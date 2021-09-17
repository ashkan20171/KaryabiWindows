namespace KaryabiWindows
{
    partial class frm_CatJobKaryabi
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
            this.dgw_cat = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tozihat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_id = new Telerik.WinControls.UI.RadTextBox();
            this.btn_insert = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txt_name = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txt_tedad = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txt_tozihat = new Telerik.WinControls.UI.RadTextBox();
            this.btn_editFinal = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_cat)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tozihat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_cat
            // 
            this.dgw_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radif,
            this.id,
            this.jobname,
            this.tedad,
            this.tozihat});
            this.dgw_cat.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_cat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_cat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgw_cat.Location = new System.Drawing.Point(17, 183);
            this.dgw_cat.MultiSelect = false;
            this.dgw_cat.Name = "dgw_cat";
            this.dgw_cat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgw_cat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_cat.Size = new System.Drawing.Size(482, 120);
            this.dgw_cat.TabIndex = 0;
            this.dgw_cat.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgw_cat_CellFormatting);
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
            this.id.HeaderText = "کد گروه";
            this.id.Name = "id";
            this.id.Width = 69;
            // 
            // jobname
            // 
            this.jobname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.jobname.DataPropertyName = "JobName";
            this.jobname.HeaderText = "نام گروه";
            this.jobname.Name = "jobname";
            this.jobname.Width = 70;
            // 
            // tedad
            // 
            this.tedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tedad.DataPropertyName = "Tedad";
            this.tedad.HeaderText = "تعداد نفرات";
            this.tedad.Name = "tedad";
            this.tedad.Width = 87;
            // 
            // tozihat
            // 
            this.tozihat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tozihat.DataPropertyName = "Description";
            this.tozihat.HeaderText = "توضیحات";
            this.tozihat.Name = "tozihat";
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
            this.ctm_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.radLabel1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(426, 24);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(49, 27);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "کد گروه :";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_id.Location = new System.Drawing.Point(322, 22);
            this.txt_id.Name = "txt_id";
            this.txt_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_id.Size = new System.Drawing.Size(98, 27);
            this.txt_id.TabIndex = 2;
            this.txt_id.TabStop = false;
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_insert.Location = new System.Drawing.Point(166, 124);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(78, 34);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "ثبت گروه";
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.Location = new System.Drawing.Point(249, 24);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(55, 27);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "نام گروه : ";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_name.Location = new System.Drawing.Point(100, 22);
            this.txt_name.Name = "txt_name";
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_name.Size = new System.Drawing.Size(144, 27);
            this.txt_name.TabIndex = 2;
            this.txt_name.TabStop = false;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.Location = new System.Drawing.Point(426, 63);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(73, 27);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "تعداد نفرات : ";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_tedad
            // 
            this.txt_tedad.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_tedad.Location = new System.Drawing.Point(322, 61);
            this.txt_tedad.Name = "txt_tedad";
            this.txt_tedad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_tedad.Size = new System.Drawing.Size(98, 27);
            this.txt_tedad.TabIndex = 2;
            this.txt_tedad.TabStop = false;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel4.Location = new System.Drawing.Point(249, 63);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel4.Size = new System.Drawing.Size(61, 27);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "توضیحات : ";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_tozihat
            // 
            this.txt_tozihat.AutoSize = false;
            this.txt_tozihat.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_tozihat.Location = new System.Drawing.Point(17, 61);
            this.txt_tozihat.Multiline = true;
            this.txt_tozihat.Name = "txt_tozihat";
            this.txt_tozihat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_tozihat.Size = new System.Drawing.Size(227, 41);
            this.txt_tozihat.TabIndex = 2;
            this.txt_tozihat.TabStop = false;
            // 
            // btn_editFinal
            // 
            this.btn_editFinal.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_editFinal.Location = new System.Drawing.Point(66, 124);
            this.btn_editFinal.Name = "btn_editFinal";
            this.btn_editFinal.Size = new System.Drawing.Size(78, 34);
            this.btn_editFinal.TabIndex = 3;
            this.btn_editFinal.Text = "ویرایش نهایی";
            this.btn_editFinal.Click += new System.EventHandler(this.btn_editFinal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // frm_CatJobKaryabi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.btn_editFinal);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_tozihat);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.txt_tedad);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dgw_cat);
            this.Name = "frm_CatJobKaryabi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت گروه کاری کاریابی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_CatJobKaryabi_FormClosing);
            this.Load += new System.EventHandler(this.frm_CatJobKaryabi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_cat)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tozihat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgw_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tozihat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_delete;
        private System.Windows.Forms.ToolStripMenuItem ctm_edit;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txt_id;
        private Telerik.WinControls.UI.RadButton btn_insert;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txt_name;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txt_tedad;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txt_tozihat;
        private Telerik.WinControls.UI.RadButton btn_editFinal;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}