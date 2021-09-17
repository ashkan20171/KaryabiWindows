namespace KaryabiWindows
{
    partial class frm_LoginEmail
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
            this.btn_loginEmail = new Telerik.WinControls.UI.RadButton();
            this.txt_username = new Telerik.WinControls.UI.RadTextBox();
            this.txt_pass = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_loginEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loginEmail
            // 
            this.btn_loginEmail.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_loginEmail.Location = new System.Drawing.Point(209, 102);
            this.btn_loginEmail.Name = "btn_loginEmail";
            this.btn_loginEmail.Size = new System.Drawing.Size(74, 33);
            this.btn_loginEmail.TabIndex = 0;
            this.btn_loginEmail.Text = "ورود ";
            this.btn_loginEmail.Click += new System.EventHandler(this.btn_loginEmail_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(124, 31);
            this.txt_username.Name = "txt_username";
            this.txt_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_username.Size = new System.Drawing.Size(159, 20);
            this.txt_username.TabIndex = 1;
            this.txt_username.TabStop = false;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(124, 66);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pass.Size = new System.Drawing.Size(159, 20);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(305, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(63, 27);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "نام کاربری : ";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.Location = new System.Drawing.Point(305, 68);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(53, 27);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "رمز عبور : ";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // frm_LoginEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 158);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_loginEmail);
            this.Name = "frm_LoginEmail";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ورود به سرور ایمیل";
            ((System.ComponentModel.ISupportInitialize)(this.btn_loginEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_loginEmail;
        private Telerik.WinControls.UI.RadTextBox txt_username;
        private Telerik.WinControls.UI.RadTextBox txt_pass;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;

    }
}