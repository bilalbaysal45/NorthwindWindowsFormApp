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
    public partial class EmployeeUpdateForm : Form
    {
        private int _employeeID;
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();
        public EmployeeUpdateForm(int employeeID)
        {
            InitializeComponent();
            _employeeID = employeeID;
        }

        private void EmployeeUpdateForm_Load(object sender, EventArgs e)
        {
            LoadReportsToComboBox();
            LoadEmployeeToForm();
        }

        private void LoadEmployeeToForm()
        {
            var employee = _employeeRepository.Find(_employeeID);
            if (employee != null)
            {
                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtTitle.Text = employee.Title;
                cmbTitleOfCourtesy.Text = employee.TitleOfCourtesy;
                txtBirthDate.Text = employee.BirthDate?.ToString(("dd/MM/yyyy"));
                txtHireDate.Text = employee.HireDate?.ToString(("dd/MM/yyyy"));
                txtAddress.Text = employee.Address;
                txtCity.Text = employee.City;
                txtRegion.Text = employee.Region;
                txtPostalCode.Text = employee.PostalCode;
                txtCountry.Text = employee.Country;
                txtHomePhone.Text = employee.HomePhone;
                txtExtension.Text = employee.Extension;
                txtNotes.Text = employee.Notes;
                if (employee.ReportsTo != null)
                {
                    cmbReportsTo.SelectedValue = employee.ReportsTo;
                }
                else
                {
                    cmbReportsTo.SelectedIndex = -1;
                }

            }
        }

        private void LoadReportsToComboBox()
        {
            cmbReportsTo.DataSource = _employeeRepository.GetAll();
            cmbReportsTo.DisplayMember = "FullName";
            cmbReportsTo.ValueMember = "EmployeeID";
            cmbReportsTo.SelectedIndex = -1;
            cmbReportsTo.Text = "Please Select...";
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            var employee = GetEmployeeFromForm();
            var result = _employeeRepository.Update(employee);

            if (result)
            {
                MessageBox.Show("Update is Successfull");
                RefreshEmployeeList();
            }
            else
            {
                MessageBox.Show("Error");
            }

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

        private Employee GetEmployeeFromForm()
        {
            var employee = new Employee();
            employee.EmployeeID = _employeeID;
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Title = string.IsNullOrWhiteSpace(txtTitle.Text) ? null : txtTitle.Text;
            employee.TitleOfCourtesy = string.IsNullOrWhiteSpace(cmbTitleOfCourtesy.SelectedText)
                                                        ? null
                                                        : cmbTitleOfCourtesy.SelectedText;
            employee.BirthDate = DateTime.TryParse(txtBirthDate.Text, out DateTime birthDate) ? birthDate : null;
            employee.HireDate = DateTime.TryParse(txtHireDate.Text, out DateTime hireDate) ? hireDate : null;
            employee.Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text;
            employee.City = string.IsNullOrWhiteSpace(txtCity.Text) ? null : txtCity.Text;
            employee.Region = string.IsNullOrWhiteSpace(txtRegion.Text) ? null : txtRegion.Text;
            employee.PostalCode = string.IsNullOrWhiteSpace(txtPostalCode.Text) ? null : txtPostalCode.Text;
            employee.Country = string.IsNullOrWhiteSpace(txtCountry.Text) ? null : txtCountry.Text;
            employee.HomePhone = string.IsNullOrWhiteSpace(txtHomePhone.Text) ? null : txtHomePhone.Text;
            employee.Extension = string.IsNullOrWhiteSpace(txtExtension.Text) ? null : txtExtension.Text;
            employee.Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text;
            if ((int?)cmbReportsTo.SelectedValue != -1)
            {
                employee.ReportsTo = (int?)cmbReportsTo.SelectedValue;
            }
            else { employee.ReportsTo = null; }
            return employee;
        }
    }
}
