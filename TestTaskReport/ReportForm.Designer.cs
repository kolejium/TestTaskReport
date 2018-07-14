namespace TestTaskReport
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TestTaskReportDataSet = new TestTaskReport.TestTaskReportDataSet();
            this.EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeesTableAdapter = new TestTaskReport.TestTaskReportDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TestTaskReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewer
            // 
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.EmployeesBindingSource;
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer.LocalReport.ReportEmbeddedResource = "TestTaskReport.Report.rdlc";
            this.ReportViewer.Location = new System.Drawing.Point(12, 12);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.ServerReport.BearerToken = null;
            this.ReportViewer.Size = new System.Drawing.Size(880, 486);
            this.ReportViewer.TabIndex = 0;
            // 
            // TestTaskReportDataSet
            // 
            this.TestTaskReportDataSet.DataSetName = "TestTaskReportDataSet";
            this.TestTaskReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeesBindingSource
            // 
            this.EmployeesBindingSource.DataMember = "Employees";
            this.EmployeesBindingSource.DataSource = this.TestTaskReportDataSet;
            // 
            // EmployeesTableAdapter
            // 
            this.EmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 510);
            this.Controls.Add(this.ReportViewer);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TestTaskReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        private System.Windows.Forms.BindingSource EmployeesBindingSource;
        private TestTaskReportDataSet TestTaskReportDataSet;
        private TestTaskReportDataSetTableAdapters.EmployeesTableAdapter EmployeesTableAdapter;
    }
}