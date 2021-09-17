namespace KaryabiWindows
{
    partial class frm_Login
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
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.btn_login = new Telerik.WinControls.UI.RadButton();
            this.btn_exit = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_username = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txt_password = new Telerik.WinControls.UI.RadTextBox();
            this.chk_loginManager = new Telerik.WinControls.UI.RadCheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.lbl_loginAdmin = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.lbl_State = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_loginManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_loginAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_State)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_login.Location = new System.Drawing.Point(237, 134);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(70, 32);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "ورود";
            this.btn_login.ThemeName = "VisualStudio2012Dark";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("B Homa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_exit.Location = new System.Drawing.Point(157, 134);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(70, 32);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "خروج";
            this.btn_exit.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(315, 26);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(63, 27);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "نام کاربری : ";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(157, 28);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(150, 21);
            this.txt_username.TabIndex = 0;
            this.txt_username.TabStop = false;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_username.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.Location = new System.Drawing.Point(315, 71);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(53, 27);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "رمز عبور : ";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(157, 71);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(150, 21);
            this.txt_password.TabIndex = 1;
            this.txt_password.TabStop = false;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.ThemeName = "VisualStudio2012Dark";
            // 
            // chk_loginManager
            // 
            this.chk_loginManager.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_loginManager.Location = new System.Drawing.Point(237, 98);
            this.chk_loginManager.Name = "chk_loginManager";
            this.chk_loginManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_loginManager.Size = new System.Drawing.Size(67, 27);
            this.chk_loginManager.TabIndex = 4;
            this.chk_loginManager.Text = "ورود مدیر";
            this.chk_loginManager.ThemeName = "VisualStudio2012Dark";
            this.chk_loginManager.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chk_loginManager_ToggleStateChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.Location = new System.Drawing.Point(278, 182);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(91, 27);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "بررسی ورود مدیر : ";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            // 
            // lbl_loginAdmin
            // 
            this.lbl_loginAdmin.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_loginAdmin.Location = new System.Drawing.Point(232, 181);
            this.lbl_loginAdmin.Name = "lbl_loginAdmin";
            this.lbl_loginAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_loginAdmin.Size = new System.Drawing.Size(26, 27);
            this.lbl_loginAdmin.TabIndex = 1;
            this.lbl_loginAdmin.Text = "---";
            this.lbl_loginAdmin.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_loginAdmin.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel4.Location = new System.Drawing.Point(101, 181);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel4.Size = new System.Drawing.Size(80, 27);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "ورود کارمندان : ";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel4.ThemeName = "VisualStudio2012Dark";
            // 
            // lbl_State
            // 
            this.lbl_State.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_State.Location = new System.Drawing.Point(38, 182);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_State.Size = new System.Drawing.Size(49, 27);
            this.lbl_State.TabIndex = 1;
            this.lbl_State.Text = "غیر فعال";
            this.lbl_State.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_State.ThemeName = "VisualStudio2012Dark";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::KaryabiWindows.Properties.Resources.admin_login_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 221);
            this.Controls.Add(this.chk_loginManager);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_loginAdmin);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Name = "frm_Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به نرم افزار";
            this.ThemeName = "VisualStudio2012Dark";
            this.Activated += new System.EventHandler(this.frm_Login_Activated);
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_loginManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_loginAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_State)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadButton btn_login;
        private Telerik.WinControls.UI.RadButton btn_exit;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadCheckBox chk_loginManager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Telerik.WinControls.UI.RadLabel lbl_loginAdmin;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        public Telerik.WinControls.UI.RadTextBox txt_username;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel lbl_State;

    }
}