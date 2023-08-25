using NorthwindProject.DataAccess;
using NorthwindProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.Forms.Forms
{
    public partial class EmployeeAddForm : Form
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();
        public EmployeeAddForm()
        {
            InitializeComponent();
        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            cmbReportsTo.DataSource = _employeeRepository.GetAll();
            cmbReportsTo.DisplayMember = "FullName";
            cmbReportsTo.ValueMember = "EmployeeID";
            cmbReportsTo.SelectedIndex = -1;
            cmbReportsTo.Text = "Please Select...";
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            var employee = GetEmployeeInformations();
            bool result;
            if (employee != null)
            {
                result = _employeeRepository.Add(employee);
                if (result)
                {
                    MessageBox.Show("Adding Employee is Successfull");
                    RefreshEmployeeList();

                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }

        }

        private Employee GetEmployeeInformations()
        {
            var employee = new Employee();
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Title = string.IsNullOrWhiteSpace(txtTitle.Text) ? null : txtTitle.Text;
            employee.TitleOfCourtesy = string.IsNullOrWhiteSpace(cmbTitleOfCourtesy.Text)
                                                                ? null
                                                                : cmbTitleOfCourtesy.Text;
            employee.BirthDate = DateTime.TryParse(txtBirthDate.Text, out DateTime birthDate)
                                                                ? birthDate
                                                                : null;
            employee.HireDate = DateTime.TryParse(txtHireDate.Text, out DateTime hireDate)
                                                                ? hireDate
                                                                : null;
            employee.Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text;
            employee.City = string.IsNullOrWhiteSpace(txtCity.Text) ? null : txtCity.Text;
            employee.Region = string.IsNullOrWhiteSpace(txtRegion.Text) ? null : txtRegion.Text;
            employee.PostalCode = string.IsNullOrWhiteSpace(txtPostalCode.Text) ? null : txtPostalCode.Text;
            employee.Country = string.IsNullOrWhiteSpace(txtCountry.Text) ? null : txtCountry.Text;
            employee.HomePhone = string.IsNullOrWhiteSpace(txtHomePhone.Text) ? null : txtHomePhone.Text;
            employee.Extension = string.IsNullOrWhiteSpace(txtExtension.Text) ? null : txtExtension.Text;
            employee.Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text;
            employee.ReportsTo = (int?)cmbReportsTo.SelectedValue;
            return employee;
        }
        private void RefreshEmployeeList()
        {
            foreach (var form in MdiParent.MdiChildren)
            {
                if (form is EmployeeListForm)
                {
                    var employeeListForm = form as EmployeeListForm;
                    employeeListForm.RefreshEmployeeList();
                }
            }
        }
    }
}
