using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace TestTaskReport
{
    public partial class EmployeesForm : Form
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;

        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Filter(this.testTaskReportDataSet.Employees, FilterTextBox.Text);
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            using (var window = new AddEmployeeForm(this))
            {
                window.ShowDialog();
            }
        }

        public void AddToDataBase(Employee employee)
        {
            this.employeesTableAdapter.Insert(employee.Id, employee.Name,
                employee.Surname, employee.Position, employee.Birthday,
                employee.Salary);
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            this.employeesTableAdapter.Fill(this.testTaskReportDataSet.Employees);
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();            
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection collection = DataGridView.SelectedRows;
            for (int i = 0; i < collection.Count; i++)
            {
                this.employeesTableAdapter.Delete1(
                    (Guid)DataGridView[0, collection[i].Index].Value
                    );
            }
            RefreshDataGridView();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.ShowDialog();
        }
    }
}
