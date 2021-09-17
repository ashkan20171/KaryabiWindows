namespace KaryabiWindows
{
    partial class frm_MainOfficers
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
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_username = new Telerik.WinControls.UI.RadLabel();
            this.lbl_ip = new Telerik.WinControls.UI.RadLabel();
            this.lbl_ServerName = new Telerik.WinControls.UI.RadLabel();
            this.lbl_Fullname = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.lbl_type = new Telerik.WinControls.UI.RadLabel();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.lbl_time = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement2 = new Telerik.WinControls.UI.RadLabelElement();
            this.lbl_date = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement3 = new Telerik.WinControls.UI.RadLabelElement();
            this.lbl_currentDate = new Telerik.WinControls.UI.RadLabelElement();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_PublicNotify = new Telerik.WinControls.UI.RadLabel();
            this.lbl_notifyFromAdminToUser = new Telerik.WinControls.UI.RadLabel();
            this.lbl_notify = new Telerik.WinControls.UI.RadLabel();
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.btn_TestIp = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Mcustomers = new DevComponents.DotNetBar.ButtonItem();
            this.btn_sendNotify = new DevComponents.DotNetBar.ButtonItem();
            this.btn_viewNotify = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_ip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_ServerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Fullname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_PublicNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_notifyFromAdminToUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_notify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonControl1.Size = new System.Drawing.Size(695, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar7);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 61);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(695, 90);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_Mcustomers});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(116, 87);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "مدیریت مشتریان";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(695, 151);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_sendNotify,
            this.btn_viewNotify});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(220, 148);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 0;
            this.ribbonBar2.Text = "بخش اعلانیه";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "پنل کارمند";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "اعلانیه";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lbl_username);
            this.groupPanel1.Controls.Add(this.lbl_ip);
            this.groupPanel1.Controls.Add(this.lbl_ServerName);
            this.groupPanel1.Controls.Add(this.lbl_Fullname);
            this.groupPanel1.Controls.Add(this.radLabel3);
            this.groupPanel1.Controls.Add(this.radLabel2);
            this.groupPanel1.Controls.Add(this.radLabel4);
            this.groupPanel1.Controls.Add(this.lbl_type);
            this.groupPanel1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel1.Location = new System.Drawing.Point(440, 157);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(255, 251);
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
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "اطلاعات مدیر جاری";
            // 
            // lbl_username
            // 
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_username.ForeColor = System.Drawing.Color.Red;
            this.lbl_username.Location = new System.Drawing.Point(19, 16);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_username.Size = new System.Drawing.Size(30, 31);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "---";
            this.lbl_username.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_ip
            // 
            this.lbl_ip.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ip.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ip.ForeColor = System.Drawing.Color.Red;
            this.lbl_ip.Location = new System.Drawing.Point(19, 148);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ip.Size = new System.Drawing.Size(30, 31);
            this.lbl_ip.TabIndex = 0;
            this.lbl_ip.Text = "---";
            this.lbl_ip.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_ServerName
            // 
            this.lbl_ServerName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ServerName.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ServerName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ServerName.Location = new System.Drawing.Point(19, 111);
            this.lbl_ServerName.Name = "lbl_ServerName";
            this.lbl_ServerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ServerName.Size = new System.Drawing.Size(30, 31);
            this.lbl_ServerName.TabIndex = 0;
            this.lbl_ServerName.Text = "---";
            this.lbl_ServerName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Fullname
            // 
            this.lbl_Fullname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Fullname.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Fullname.ForeColor = System.Drawing.Color.Red;
            this.lbl_Fullname.Location = new System.Drawing.Point(19, 64);
            this.lbl_Fullname.Name = "lbl_Fullname";
            this.lbl_Fullname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Fullname.Size = new System.Drawing.Size(30, 31);
            this.lbl_Fullname.TabIndex = 0;
            this.lbl_Fullname.Text = "---";
            this.lbl_Fullname.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.ForeColor = System.Drawing.Color.Blue;
            this.radLabel3.Location = new System.Drawing.Point(107, 148);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(64, 31);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "آدرس ip :";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.ForeColor = System.Drawing.Color.Blue;
            this.radLabel2.Location = new System.Drawing.Point(107, 111);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(60, 31);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "نام سرور :";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel4
            // 
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel4.ForeColor = System.Drawing.Color.Blue;
            this.radLabel4.Location = new System.Drawing.Point(107, 64);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel4.Size = new System.Drawing.Size(71, 31);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "خوش امدید";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_type
            // 
            this.lbl_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_type.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_type.ForeColor = System.Drawing.Color.Blue;
            this.lbl_type.Location = new System.Drawing.Point(107, 16);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_type.Size = new System.Drawing.Size(30, 31);
            this.lbl_type.TabIndex = 0;
            this.lbl_type.Text = "---";
            this.lbl_type.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Font = new System.Drawing.Font("B Homa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.lbl_time,
            this.radLabelElement2,
            this.lbl_date,
            this.radLabelElement3,
            this.lbl_currentDate});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 405);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radStatusStrip1.Size = new System.Drawing.Size(695, 31);
            this.radStatusStrip1.TabIndex = 3;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.AccessibleDescription = "ساعت : ";
            this.radLabelElement1.AccessibleName = "ساعت : ";
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "ساعت : ";
            this.radLabelElement1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // lbl_time
            // 
            this.lbl_time.AccessibleDescription = "---";
            this.lbl_time.AccessibleName = "---";
            this.lbl_time.Name = "lbl_time";
            this.radStatusStrip1.SetSpring(this.lbl_time, false);
            this.lbl_time.Text = "---";
            this.lbl_time.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_time.TextWrap = true;
            this.lbl_time.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radLabelElement2
            // 
            this.radLabelElement2.AccessibleDescription = "امروز :";
            this.radLabelElement2.AccessibleName = "امروز :";
            this.radLabelElement2.Name = "radLabelElement2";
            this.radStatusStrip1.SetSpring(this.radLabelElement2, false);
            this.radLabelElement2.Text = "امروز :";
            this.radLabelElement2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement2.TextWrap = true;
            this.radLabelElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // lbl_date
            // 
            this.lbl_date.AccessibleDescription = "---";
            this.lbl_date.AccessibleName = "---";
            this.lbl_date.Name = "lbl_date";
            this.radStatusStrip1.SetSpring(this.lbl_date, false);
            this.lbl_date.Text = "---";
            this.lbl_date.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_date.TextWrap = true;
            this.lbl_date.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radLabelElement3
            // 
            this.radLabelElement3.AccessibleDescription = "تاریخ : ";
            this.radLabelElement3.AccessibleName = "تاریخ : ";
            this.radLabelElement3.Name = "radLabelElement3";
            this.radStatusStrip1.SetSpring(this.radLabelElement3, false);
            this.radLabelElement3.Text = "تاریخ : ";
            this.radLabelElement3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement3.TextWrap = true;
            this.radLabelElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // lbl_currentDate
            // 
            this.lbl_currentDate.AccessibleDescription = "---";
            this.lbl_currentDate.AccessibleName = "---";
            this.lbl_currentDate.Name = "lbl_currentDate";
            this.radStatusStrip1.SetSpring(this.lbl_currentDate, false);
            this.lbl_currentDate.Text = "---";
            this.lbl_currentDate.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_currentDate.TextWrap = true;
            this.lbl_currentDate.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.lbl_PublicNotify);
            this.groupPanel2.Controls.Add(this.lbl_notifyFromAdminToUser);
            this.groupPanel2.Controls.Add(this.lbl_notify);
            this.groupPanel2.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel2.Location = new System.Drawing.Point(235, 160);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(199, 151);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 5;
            this.groupPanel2.Text = "بخش اعلانیه ها";
            // 
            // lbl_PublicNotify
            // 
            this.lbl_PublicNotify.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PublicNotify.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_PublicNotify.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_PublicNotify.Location = new System.Drawing.Point(35, 83);
            this.lbl_PublicNotify.Name = "lbl_PublicNotify";
            this.lbl_PublicNotify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_PublicNotify.Size = new System.Drawing.Size(30, 28);
            this.lbl_PublicNotify.TabIndex = 1;
            this.lbl_PublicNotify.Text = "---";
            this.lbl_PublicNotify.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_PublicNotify.TextChanged += new System.EventHandler(this.lbl_notifyFromAdmin_TextChanged);
            this.lbl_PublicNotify.Click += new System.EventHandler(this.lbl_PublicNotify_Click);
            // 
            // lbl_notifyFromAdminToUser
            // 
            this.lbl_notifyFromAdminToUser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_notifyFromAdminToUser.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_notifyFromAdminToUser.ForeColor = System.Drawing.Color.Blue;
            this.lbl_notifyFromAdminToUser.Location = new System.Drawing.Point(35, 48);
            this.lbl_notifyFromAdminToUser.Name = "lbl_notifyFromAdminToUser";
            this.lbl_notifyFromAdminToUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_notifyFromAdminToUser.Size = new System.Drawing.Size(30, 28);
            this.lbl_notifyFromAdminToUser.TabIndex = 1;
            this.lbl_notifyFromAdminToUser.Text = "---";
            this.lbl_notifyFromAdminToUser.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_notifyFromAdminToUser.TextChanged += new System.EventHandler(this.lbl_notifyFromAdmin_TextChanged);
            // 
            // lbl_notify
            // 
            this.lbl_notify.BackColor = System.Drawing.Color.Transparent;
            this.lbl_notify.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_notify.ForeColor = System.Drawing.Color.Red;
            this.lbl_notify.Location = new System.Drawing.Point(31, 11);
            this.lbl_notify.Name = "lbl_notify";
            this.lbl_notify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_notify.Size = new System.Drawing.Size(30, 28);
            this.lbl_notify.TabIndex = 0;
            this.lbl_notify.Text = "---";
            this.lbl_notify.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_notify.TextChanged += new System.EventHandler(this.lbl_notify_TextChanged);
            this.lbl_notify.Click += new System.EventHandler(this.lbl_notify_Click);
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar7.ContainerControlProcessDialogKey = true;
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_TestIp});
            this.ribbonBar7.Location = new System.Drawing.Point(119, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(110, 87);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar7.TabIndex = 2;
            this.ribbonBar7.Text = "مدیریت شبکه";
            // 
            // 
            // 
            this.ribbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btn_TestIp
            // 
            this.btn_TestIp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TestIp.FixedSize = new System.Drawing.Size(105, 60);
            this.btn_TestIp.Image = global::KaryabiWindows.Properties.Resources.Wireless_Network_Setup_Bangor_Newtownards_Belfast;
            this.btn_TestIp.ImageFixedSize = new System.Drawing.Size(50, 40);
            this.btn_TestIp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_TestIp.Name = "btn_TestIp";
            this.btn_TestIp.SubItemsExpandWidth = 14;
            this.btn_TestIp.Text = "بررسی اتصال";
            this.btn_TestIp.Click += new System.EventHandler(this.btn_TestIp_Click);
            // 
            // btn_Mcustomers
            // 
            this.btn_Mcustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Mcustomers.FixedSize = new System.Drawing.Size(105, 60);
            this.btn_Mcustomers.Image = global::KaryabiWindows.Properties.Resources._1328282962_userconfig;
            this.btn_Mcustomers.ImageFixedSize = new System.Drawing.Size(65, 40);
            this.btn_Mcustomers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Mcustomers.Name = "btn_Mcustomers";
            this.btn_Mcustomers.SubItemsExpandWidth = 14;
            this.btn_Mcustomers.Text = "مشتریان";
            this.btn_Mcustomers.Click += new System.EventHandler(this.btn_Mcustomers_Click);
            // 
            // btn_sendNotify
            // 
            this.btn_sendNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sendNotify.FixedSize = new System.Drawing.Size(105, 60);
            this.btn_sendNotify.Image = global::KaryabiWindows.Properties.Resources.notify_icon;
            this.btn_sendNotify.ImageFixedSize = new System.Drawing.Size(65, 40);
            this.btn_sendNotify.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_sendNotify.Name = "btn_sendNotify";
            this.btn_sendNotify.SubItemsExpandWidth = 14;
            this.btn_sendNotify.Text = "ارسال درخواست";
            this.btn_sendNotify.Click += new System.EventHandler(this.btn_sendNotify_Click);
            // 
            // btn_viewNotify
            // 
            this.btn_viewNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_viewNotify.FixedSize = new System.Drawing.Size(105, 60);
            this.btn_viewNotify.Image = global::KaryabiWindows.Properties.Resources.Messages_Android_R;
            this.btn_viewNotify.ImageFixedSize = new System.Drawing.Size(65, 40);
            this.btn_viewNotify.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_viewNotify.Name = "btn_viewNotify";
            this.btn_viewNotify.SubItemsExpandWidth = 14;
            this.btn_viewNotify.Text = "مشاهده اعلانیه ها";
            this.btn_viewNotify.Click += new System.EventHandler(this.btn_viewNotify_Click);
            // 
            // frm_MainOfficers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 436);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frm_MainOfficers";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "پنل کاربری کارمندان";
            this.Activated += new System.EventHandler(this.frm_MainOfficers_Activated);
            this.Load += new System.EventHandler(this.frm_MainOfficers_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_ip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_ServerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Fullname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_PublicNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_notifyFromAdminToUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_notify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonItem btn_Mcustomers;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        public Telerik.WinControls.UI.RadLabel lbl_username;
        private Telerik.WinControls.UI.RadLabel lbl_ip;
        private Telerik.WinControls.UI.RadLabel lbl_ServerName;
        public Telerik.WinControls.UI.RadLabel lbl_Fullname;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel lbl_type;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadLabelElement lbl_time;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement2;
        private Telerik.WinControls.UI.RadLabelElement lbl_date;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement3;
        private Telerik.WinControls.UI.RadLabelElement lbl_currentDate;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btn_sendNotify;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private Telerik.WinControls.UI.RadLabel lbl_notify;
        private Telerik.WinControls.UI.RadLabel lbl_notifyFromAdminToUser;
        private Telerik.WinControls.UI.RadLabel lbl_PublicNotify;
        private DevComponents.DotNetBar.ButtonItem btn_viewNotify;
        private DevComponents.DotNetBar.RibbonBar ribbonBar7;
        private DevComponents.DotNetBar.ButtonItem btn_TestIp;

    }
}