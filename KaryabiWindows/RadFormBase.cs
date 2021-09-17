namespace Telerik
{
    public abstract class RadFormBase
    {
        public Telerik.WinControls.UI.RadTextBox txt_to;
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

        protected abstract override void Dispose(bool disposing);

        private override void btn_send_Click(object sender, EventArgs e) => throw new NotImplementedException();

                #region Windows Form Designer generated code

                /// <summary>
                /// Required method for Designer support - do not modify
                /// the contents of this method with the code editor.
                /// </summary>
                private override void InitializeComponent()
        {
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txt_to = new Telerik.WinControls.UI.RadTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_attach = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.txt_cc = new Telerik.WinControls.UI.RadTextBox();
            this.txt_bcc = new Telerik.WinControls.UI.RadTextBox();
            this.txt_subject = new Telerik.WinControls.UI.RadTextBox();
            this.txt_name = new Telerik.WinControls.UI.RadTextBox();
            this.txt_body = new Telerik.WinControls.UI.RadTextBox();
            this.btn_send = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_attach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_subject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(14, 180);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "نام شما : ";
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(73, 22);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(500, 20);
            this.txt_to.TabIndex = 0;
            this.txt_to.TabStop = false;
            this.txt_to.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_to_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(415, 233);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 173);
            this.listBox1.TabIndex = 2;
            // 
            // btn_attach
            // 
            this.btn_attach.Location = new System.Drawing.Point(553, 421);
            this.btn_attach.Name = "btn_attach";
            this.btn_attach.Size = new System.Drawing.Size(110, 24);
            this.btn_attach.TabIndex = 6;
            this.btn_attach.Text = "Attach";
            this.btn_attach.Click += new System.EventHandler(this.btn_attach_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(26, 22);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(29, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "TO : ";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(26, 59);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(29, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "CC : ";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(26, 96);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(32, 18);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "BCC :";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(12, 136);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(52, 18);
            this.radLabel5.TabIndex = 0;
            this.radLabel5.Text = "Subject : ";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(598, 209);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(60, 18);
            this.radLabel6.TabIndex = 0;
            this.radLabel6.Text = "افزودن فایل";
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(73, 59);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(500, 20);
            this.txt_cc.TabIndex = 1;
            this.txt_cc.TabStop = false;
            // 
            // txt_bcc
            // 
            this.txt_bcc.Location = new System.Drawing.Point(73, 96);
            this.txt_bcc.Name = "txt_bcc";
            this.txt_bcc.Size = new System.Drawing.Size(500, 20);
            this.txt_bcc.TabIndex = 2;
            this.txt_bcc.TabStop = false;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(73, 136);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(500, 20);
            this.txt_subject.TabIndex = 3;
            this.txt_subject.TabStop = false;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(73, 178);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(500, 20);
            this.txt_name.TabIndex = 4;
            this.txt_name.TabStop = false;
            // 
            // txt_body
            // 
            this.txt_body.AutoSize = false;
            this.txt_body.Location = new System.Drawing.Point(14, 233);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.Size = new System.Drawing.Size(395, 229);
            this.txt_body.TabIndex = 5;
            this.txt_body.TabStop = false;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(415, 421);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(110, 24);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "Send";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // frm_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 469);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_body);
            this.Controls.Add(this.btn_attach);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_bcc);
            this.Controls.Add(this.txt_cc);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "frm_Email";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ارسال ایمیل";
            this.Activated += new System.EventHandler(this.frm_Email_Activated);
            this.Load += new System.EventHandler(this.frm_Email_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_attach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_subject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}