namespace KaryabiWindows
{
    partial class frm_SendNotifyUsers
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
            this.btn_send = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_id = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txt_description = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(317, 126);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(81, 33);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "ارسال";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(578, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel1.Size = new System.Drawing.Size(75, 27);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "کد درخواست : ";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_id.Location = new System.Drawing.Point(497, 22);
            this.txt_id.Name = "txt_id";
            this.txt_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_id.Size = new System.Drawing.Size(75, 24);
            this.txt_id.TabIndex = 2;
            this.txt_id.TabStop = false;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Homa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.Location = new System.Drawing.Point(395, 19);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(87, 27);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "متن در خواست : ";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_description
            // 
            this.txt_description.AutoSize = false;
            this.txt_description.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_description.Location = new System.Drawing.Point(24, 19);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_description.Size = new System.Drawing.Size(374, 101);
            this.txt_description.TabIndex = 2;
            this.txt_description.TabStop = false;
            // 
            // frm_SendNotifyUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 177);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btn_send);
            this.Name = "frm_SendNotifyUsers";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "فرم ارسال درخواست";
            this.Load += new System.EventHandler(this.frm_SendNotifyUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_send;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txt_id;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txt_description;

    }
}