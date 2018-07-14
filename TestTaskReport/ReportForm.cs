using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskReport
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TestTaskReportDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.EmployeesTableAdapter.Fill(this.TestTaskReportDataSet.Employees);

            this.ReportViewer.RefreshReport();
        }
    }
}
