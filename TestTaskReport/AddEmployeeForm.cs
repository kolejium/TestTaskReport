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
    public partial class AddEmployeeForm : Form
    {
        private EmployeesForm _ownerForm;

        public AddEmployeeForm(EmployeesForm form)
        {
            _ownerForm = form;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Employee GetByForm()
        {
            return new Employee(NameTextBox.Text,
    SurnameTextBox.Text,
    PositionTextBox.Text,
    BirthdayDatePicker.Value,
    Convert.ToInt32(SalaryTextBox.Text));
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                _ownerForm.AddToDataBase(GetByForm());

            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
