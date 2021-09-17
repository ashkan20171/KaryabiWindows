namespace KaryabiWindows
{
    partial class frm_ReportOfficers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReportOfficers));
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.officerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeMelliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madrakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOfficersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new KaryabiWindows.DataSet1();
            this.tbl_OfficersTableAdapter = new KaryabiWindows.DataSet1TableAdapters.tbl_OfficersTableAdapter();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.stiReportDataSource1 = new Stimulsoft.Report.Design.StiReportDataSource("tblOfficersBindingSource", this.tblOfficersBindingSource);
            this.btn_report = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOfficersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.officerIdDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.theWorkDataGridViewTextBoxColumn,
            this.codeMelliDataGridViewTextBoxColumn,
            this.tellDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.dateInCompanyDataGridViewTextBoxColumn,
            this.madrakDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.tblOfficersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.EnableHeadersVisualStyles = false;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewX1.Name = "dataGridViewX1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.Size = new System.Drawing.Size(678, 150);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // officerIdDataGridViewTextBoxColumn
            // 
            this.officerIdDataGridViewTextBoxColumn.DataPropertyName = "OfficerId";
            this.officerIdDataGridViewTextBoxColumn.HeaderText = "OfficerId";
            this.officerIdDataGridViewTextBoxColumn.Name = "officerIdDataGridViewTextBoxColumn";
            this.officerIdDataGridViewTextBoxColumn.Width = 77;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 66;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.Width = 65;
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "Birth";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            this.birthDataGridViewTextBoxColumn.Width = 57;
            // 
            // theWorkDataGridViewTextBoxColumn
            // 
            this.theWorkDataGridViewTextBoxColumn.DataPropertyName = "TheWork";
            this.theWorkDataGridViewTextBoxColumn.HeaderText = "TheWork";
            this.theWorkDataGridViewTextBoxColumn.Name = "theWorkDataGridViewTextBoxColumn";
            this.theWorkDataGridViewTextBoxColumn.Width = 78;
            // 
            // codeMelliDataGridViewTextBoxColumn
            // 
            this.codeMelliDataGridViewTextBoxColumn.DataPropertyName = "CodeMelli";
            this.codeMelliDataGridViewTextBoxColumn.HeaderText = "CodeMelli";
            this.codeMelliDataGridViewTextBoxColumn.Name = "codeMelliDataGridViewTextBoxColumn";
            this.codeMelliDataGridViewTextBoxColumn.Width = 84;
            // 
            // tellDataGridViewTextBoxColumn
            // 
            this.tellDataGridViewTextBoxColumn.DataPropertyName = "Tell";
            this.tellDataGridViewTextBoxColumn.HeaderText = "Tell";
            this.tellDataGridViewTextBoxColumn.Name = "tellDataGridViewTextBoxColumn";
            this.tellDataGridViewTextBoxColumn.Width = 49;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.Width = 68;
            // 
            // dateInCompanyDataGridViewTextBoxColumn
            // 
            this.dateInCompanyDataGridViewTextBoxColumn.DataPropertyName = "DateInCompany";
            this.dateInCompanyDataGridViewTextBoxColumn.HeaderText = "DateInCompany";
            this.dateInCompanyDataGridViewTextBoxColumn.Name = "dateInCompanyDataGridViewTextBoxColumn";
            this.dateInCompanyDataGridViewTextBoxColumn.Width = 114;
            // 
            // madrakDataGridViewTextBoxColumn
            // 
            this.madrakDataGridViewTextBoxColumn.DataPropertyName = "Madrak";
            this.madrakDataGridViewTextBoxColumn.HeaderText = "Madrak";
            this.madrakDataGridViewTextBoxColumn.Name = "madrakDataGridViewTextBoxColumn";
            this.madrakDataGridViewTextBoxColumn.Width = 71;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 44;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 73;
            // 
            // tblOfficersBindingSource
            // 
            this.tblOfficersBindingSource.DataMember = "tbl_Officers";
            this.tblOfficersBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_OfficersTableAdapter
            // 
            this.tbl_OfficersTableAdapter.ClearBeforeFill = true;
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportDataSources.Add(this.stiReportDataSource1);
            this.stiReport1.ReportGuid = "d31fcf458e0340e5b828f368c141f360";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.tblOfficersBindingSource;
            this.stiReportDataSource1.Name = "tblOfficersBindingSource";
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(470, 341);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(110, 38);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "radButton1";
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // frm_ReportOfficers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 418);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.dataGridViewX1);
            this.Name = "frm_ReportOfficers";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ReportOfficers";
            this.Load += new System.EventHandler(this.frn_ReportOfficers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOfficersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblOfficersBindingSource;
        private DataSet1TableAdapters.tbl_OfficersTableAdapter tbl_OfficersTableAdapter;
        private Stimulsoft.Report.StiReport stiReport1;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource1;
        private Telerik.WinControls.UI.RadButton btn_report;
        private System.Windows.Forms.DataGridViewTextBoxColumn officerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeMelliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madrakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;

    }
}