namespace KaryabiWindows
{
    partial class frm_ManageNotify
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
            this.txt_description = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txt_id = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txt_officerId = new Telerik.WinControls.UI.RadTextBox();
            this.chk_valid = new Telerik.WinControls.UI.RadCheckBox();
            this.btn_add = new Telerik.WinControls.UI.RadButton();
            this.dgw_notify = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_review = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_SById = new Telerik.WinControls.UI.RadTextBox();
            this.txt_SbyOfficerId = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_officerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_valid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_notify)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SById)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SbyOfficerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_description
            // 
            this.txt_description.AutoSize = false;
            this.txt_description.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_description.Location = new System.Drawing.Point(195, 75);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_description.Size = new System.Drawing.Size(305, 85);
            this.txt_description.TabIndex = 5;
            this.txt_description.TabStop = false;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.Location = new System.Drawing.Point(506, 75);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(87, 27);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "متن در خواست : ";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_id.Location = new System.Drawing.Point(437, 22);
            this.txt_id.Name = "txt_id";
            this.txt_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_id.Size = new System.Drawing.Size(75, 24);
            this.txt_id.TabIndex = 6;
            this.txt_id.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(518, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(75, 27);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "کد درخواست : ";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.Location = new System.Drawing.Point(315, 22);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(70, 27);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "کد کارمندی : ";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_officerId
            // 
            this.txt_officerId.Enabled = false;
            this.txt_officerId.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_officerId.Location = new System.Drawing.Point(195, 22);
            this.txt_officerId.Name = "txt_officerId";
            this.txt_officerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_officerId.Size = new System.Drawing.Size(114, 24);
            this.txt_officerId.TabIndex = 6;
            this.txt_officerId.TabStop = false;
            // 
            // chk_valid
            // 
            this.chk_valid.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_valid.Location = new System.Drawing.Point(83, 75);
            this.chk_valid.Name = "chk_valid";
            this.chk_valid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_valid.Size = new System.Drawing.Size(94, 31);
            this.chk_valid.TabIndex = 7;
            this.chk_valid.Text = "وضعیت تایید";
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add.Location = new System.Drawing.Point(406, 170);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 36);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "تایید درخواست";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgw_notify
            // 
            this.dgw_notify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_notify.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radif,
            this.id,
            this.officerId,
            this.validation,
            this.description});
            this.dgw_notify.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_notify.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_notify.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgw_notify.Location = new System.Drawing.Point(27, 271);
            this.dgw_notify.MultiSelect = false;
            this.dgw_notify.Name = "dgw_notify";
            this.dgw_notify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgw_notify.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_notify.Size = new System.Drawing.Size(566, 158);
            this.dgw_notify.TabIndex = 9;
            this.dgw_notify.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgw_notify_CellFormatting);
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
            this.id.HeaderText = "کد درخواست";
            this.id.Name = "id";
            this.id.Width = 92;
            // 
            // officerId
            // 
            this.officerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.officerId.DataPropertyName = "OfficerId";
            this.officerId.HeaderText = "کد کارمندی";
            this.officerId.Name = "officerId";
            this.officerId.Width = 84;
            // 
            // validation
            // 
            this.validation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.validation.DataPropertyName = "Validation";
            this.validation.HeaderText = "وضعیت تایید";
            this.validation.Name = "validation";
            this.validation.Width = 93;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "متن درخواست";
            this.description.Name = "description";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctm_delete,
            this.ctm_review});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 60);
            // 
            // ctm_delete
            // 
            this.ctm_delete.Image = global::KaryabiWindows.Properties.Resources._1324747694_DeleteRed;
            this.ctm_delete.Name = "ctm_delete";
            this.ctm_delete.Size = new System.Drawing.Size(152, 28);
            this.ctm_delete.Text = "حذف";
            this.ctm_delete.Click += new System.EventHandler(this.ctm_delete_Click);
            // 
            // ctm_review
            // 
            this.ctm_review.Image = global::KaryabiWindows.Properties.Resources.Refresh;
            this.ctm_review.Name = "ctm_review";
            this.ctm_review.Size = new System.Drawing.Size(152, 28);
            this.ctm_review.Text = "بررسی درخواست";
            this.ctm_review.Click += new System.EventHandler(this.ctm_review_Click);
            // 
            // txt_SById
            // 
            this.txt_SById.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_SById.Location = new System.Drawing.Point(365, 226);
            this.txt_SById.Name = "txt_SById";
            this.txt_SById.NullText = "جست و جو بر اساس کد درخواست";
            this.txt_SById.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SById.Size = new System.Drawing.Size(172, 24);
            this.txt_SById.TabIndex = 6;
            this.txt_SById.TabStop = false;
            this.txt_SById.TextChanged += new System.EventHandler(this.txt_SById_TextChanged);
            // 
            // txt_SbyOfficerId
            // 
            this.txt_SbyOfficerId.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_SbyOfficerId.Location = new System.Drawing.Point(127, 226);
            this.txt_SbyOfficerId.Name = "txt_SbyOfficerId";
            this.txt_SbyOfficerId.NullText = "جست و جو بر اساس کد کارمندی";
            this.txt_SbyOfficerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SbyOfficerId.Size = new System.Drawing.Size(182, 24);
            this.txt_SbyOfficerId.TabIndex = 6;
            this.txt_SbyOfficerId.TabStop = false;
            this.txt_SbyOfficerId.TextChanged += new System.EventHandler(this.txt_SbyOfficerId_TextChanged);
            // 
            // frm_ManageNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 441);
            this.Controls.Add(this.dgw_notify);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.chk_valid);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txt_SbyOfficerId);
            this.Controls.Add(this.txt_SById);
            this.Controls.Add(this.txt_officerId);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.radLabel1);
            this.Name = "frm_ManageNotify";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "مدیریت درخواست ها ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ManageNotify_FormClosing);
            this.Load += new System.EventHandler(this.frm_ManageNotify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_officerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_valid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_notify)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SById)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SbyOfficerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txt_description;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txt_id;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txt_officerId;
        private Telerik.WinControls.UI.RadCheckBox chk_valid;
        private Telerik.WinControls.UI.RadButton btn_add;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgw_notify;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn officerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn validation;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_delete;
        private System.Windows.Forms.ToolStripMenuItem ctm_review;
        private Telerik.WinControls.UI.RadTextBox txt_SById;
        private Telerik.WinControls.UI.RadTextBox txt_SbyOfficerId;

    }
}