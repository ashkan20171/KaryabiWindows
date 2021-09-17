namespace KaryabiWindows
{
    partial class frm_Users
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
            this.dgw_users = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctm_del = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_pass2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_pass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chk_flag = new Telerik.WinControls.UI.RadCheckBox();
            this.cmb_permission = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txt_fullname = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txt_username = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btn_insert = new Telerik.WinControls.UI.RadButton();
            this.btn_editFinal = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_delete = new Telerik.WinControls.UI.RadButton();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.txt_SbyUserid = new Telerik.WinControls.UI.RadTextBox();
            this.txt_Sbyfullname = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_users)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fullname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SbyUserid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sbyfullname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_users
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radif,
            this.username,
            this.password,
            this.fullname,
            this.flag,
            this.Permission});
            this.dgw_users.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_users.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_users.EnableHeadersVisualStyles = false;
            this.dgw_users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgw_users.Location = new System.Drawing.Point(12, 12);
            this.dgw_users.MultiSelect = false;
            this.dgw_users.Name = "dgw_users";
            this.dgw_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_users.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgw_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_users.Size = new System.Drawing.Size(582, 167);
            this.dgw_users.TabIndex = 0;
            this.dgw_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_users_CellContentClick);
            this.dgw_users.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgw_users_CellFormatting);
            this.dgw_users.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_users_RowHeaderMouseClick);
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
            this.username.HeaderText = "کد کاربری";
            this.username.Name = "username";
            this.username.Width = 71;
            // 
            // password
            // 
            this.password.DataPropertyName = "Password";
            this.password.HeaderText = "کلمه عبور";
            this.password.Name = "password";
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "Fullname";
            this.fullname.HeaderText = "نام کامل";
            this.fullname.Name = "fullname";
            this.fullname.Width = 90;
            // 
            // flag
            // 
            this.flag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.flag.DataPropertyName = "Flag";
            this.flag.HeaderText = "وضعیت دسترسی";
            this.flag.Name = "flag";
            this.flag.Width = 101;
            // 
            // Permission
            // 
            this.Permission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Permission.DataPropertyName = "Permission";
            this.Permission.HeaderText = "سطح دسترسی";
            this.Permission.Name = "Permission";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctm_del,
            this.ctm_edit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 60);
            // 
            // ctm_del
            // 
            this.ctm_del.Image = global::KaryabiWindows.Properties.Resources._1324747694_DeleteRed;
            this.ctm_del.Name = "ctm_del";
            this.ctm_del.Size = new System.Drawing.Size(114, 28);
            this.ctm_del.Text = "حذف";
            this.ctm_del.Click += new System.EventHandler(this.ctm_del_Click);
            // 
            // ctm_edit
            // 
            this.ctm_edit.Image = global::KaryabiWindows.Properties.Resources.Refresh;
            this.ctm_edit.Name = "ctm_edit";
            this.ctm_edit.Size = new System.Drawing.Size(114, 28);
            this.ctm_edit.Text = "ویرایش";
            this.ctm_edit.Click += new System.EventHandler(this.ctm_edit_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txt_pass2);
            this.groupPanel1.Controls.Add(this.txt_pass);
            this.groupPanel1.Controls.Add(this.chk_flag);
            this.groupPanel1.Controls.Add(this.cmb_permission);
            this.groupPanel1.Controls.Add(this.radLabel5);
            this.groupPanel1.Controls.Add(this.txt_fullname);
            this.groupPanel1.Controls.Add(this.radLabel4);
            this.groupPanel1.Controls.Add(this.radLabel3);
            this.groupPanel1.Controls.Add(this.radLabel2);
            this.groupPanel1.Controls.Add(this.txt_username);
            this.groupPanel1.Controls.Add(this.radLabel1);
            this.groupPanel1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 249);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupPanel1.Size = new System.Drawing.Size(582, 202);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "سطح دسترسی";
            // 
            // txt_pass2
            // 
            // 
            // 
            // 
            this.txt_pass2.Border.Class = "TextBoxBorder";
            this.txt_pass2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_pass2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_pass2.Location = new System.Drawing.Point(311, 104);
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_pass2.Size = new System.Drawing.Size(156, 22);
            this.txt_pass2.TabIndex = 4;
            this.txt_pass2.UseSystemPasswordChar = true;
            // 
            // txt_pass
            // 
            // 
            // 
            // 
            this.txt_pass.Border.Class = "TextBoxBorder";
            this.txt_pass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_pass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_pass.Location = new System.Drawing.Point(312, 61);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_pass.Size = new System.Drawing.Size(156, 22);
            this.txt_pass.TabIndex = 4;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // chk_flag
            // 
            this.chk_flag.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_flag.Location = new System.Drawing.Point(90, 105);
            this.chk_flag.Name = "chk_flag";
            this.chk_flag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_flag.Size = new System.Drawing.Size(99, 27);
            this.chk_flag.TabIndex = 3;
            this.chk_flag.Text = "وضعیت دسترسی";
            // 
            // cmb_permission
            // 
            this.cmb_permission.DisplayMember = "Text";
            this.cmb_permission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_permission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_permission.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_permission.FormattingEnabled = true;
            this.cmb_permission.ItemHeight = 23;
            this.cmb_permission.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem3,
            this.comboItem2});
            this.cmb_permission.Location = new System.Drawing.Point(34, 59);
            this.cmb_permission.Name = "cmb_permission";
            this.cmb_permission.Size = new System.Drawing.Size(155, 29);
            this.cmb_permission.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_permission.TabIndex = 2;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "کارمند";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "حسابدار";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "منشی";
            // 
            // radLabel5
            // 
            this.radLabel5.BackColor = System.Drawing.Color.Transparent;
            this.radLabel5.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel5.Location = new System.Drawing.Point(205, 63);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel5.Size = new System.Drawing.Size(82, 27);
            this.radLabel5.TabIndex = 0;
            this.radLabel5.Text = "سطح دسترسی : ";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_fullname.Location = new System.Drawing.Point(34, 23);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(155, 20);
            this.txt_fullname.TabIndex = 1;
            this.txt_fullname.TabStop = false;
            // 
            // radLabel4
            // 
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel4.Location = new System.Drawing.Point(205, 19);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel4.Size = new System.Drawing.Size(69, 27);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "نامل کامل : ";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.Location = new System.Drawing.Point(464, 104);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(78, 27);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "تکرار رمز عبور : ";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.Location = new System.Drawing.Point(464, 62);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(53, 27);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "رمز عبور : ";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_username.Location = new System.Drawing.Point(312, 23);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(155, 20);
            this.txt_username.TabIndex = 1;
            this.txt_username.TabStop = false;
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
            this.txt_username.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_username_MouseDoubleClick);
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(464, 19);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(61, 27);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "کد کاربری : ";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_insert.Location = new System.Drawing.Point(383, 463);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(91, 36);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "ثبت کاربر";
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_editFinal
            // 
            this.btn_editFinal.Enabled = false;
            this.btn_editFinal.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_editFinal.Location = new System.Drawing.Point(254, 463);
            this.btn_editFinal.Name = "btn_editFinal";
            this.btn_editFinal.Size = new System.Drawing.Size(91, 36);
            this.btn_editFinal.TabIndex = 3;
            this.btn_editFinal.Text = "ویرایش نهایی";
            this.btn_editFinal.Click += new System.EventHandler(this.btn_editFinal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.Location = new System.Drawing.Point(127, 463);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 36);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "حذف کاربر";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(0, 234);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(615, 10);
            this.radSeparator1.TabIndex = 4;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // txt_SbyUserid
            // 
            this.txt_SbyUserid.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_SbyUserid.Location = new System.Drawing.Point(356, 198);
            this.txt_SbyUserid.Name = "txt_SbyUserid";
            this.txt_SbyUserid.NullText = "جست جو بر اساس کد کاربری";
            this.txt_SbyUserid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SbyUserid.Size = new System.Drawing.Size(184, 24);
            this.txt_SbyUserid.TabIndex = 5;
            this.txt_SbyUserid.TabStop = false;
            this.txt_SbyUserid.TextChanged += new System.EventHandler(this.txt_SbyUserid_TextChanged);
            // 
            // txt_Sbyfullname
            // 
            this.txt_Sbyfullname.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Sbyfullname.Location = new System.Drawing.Point(62, 198);
            this.txt_Sbyfullname.Name = "txt_Sbyfullname";
            this.txt_Sbyfullname.NullText = "جست و جو بر اساس نام";
            this.txt_Sbyfullname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Sbyfullname.Size = new System.Drawing.Size(184, 24);
            this.txt_Sbyfullname.TabIndex = 5;
            this.txt_Sbyfullname.TabStop = false;
            this.txt_Sbyfullname.TextChanged += new System.EventHandler(this.txt_Sbyfullname_TextChanged);
            // 
            // frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 537);
            this.Controls.Add(this.txt_Sbyfullname);
            this.Controls.Add(this.txt_SbyUserid);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_editFinal);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dgw_users);
            this.Name = "frm_Users";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کارمندان";
            this.Activated += new System.EventHandler(this.frm_Users_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Users_FormClosing);
            this.Load += new System.EventHandler(this.frm_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_users)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fullname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_editFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SbyUserid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sbyfullname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgw_users;
        private Telerik.WinControls.UI.RadCheckBox chk_flag;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_permission;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private DevComponents.Editors.ComboItem comboItem3;
        public DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        public Telerik.WinControls.UI.RadTextBox txt_fullname;
        public Telerik.WinControls.UI.RadTextBox txt_username;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_pass2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_pass;
        private Telerik.WinControls.UI.RadButton btn_insert;
        private Telerik.WinControls.UI.RadButton btn_editFinal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadButton btn_delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctm_del;
        private System.Windows.Forms.ToolStripMenuItem ctm_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permission;
        private Telerik.WinControls.UI.RadTextBox txt_Sbyfullname;
        private Telerik.WinControls.UI.RadTextBox txt_SbyUserid;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;

    }
}