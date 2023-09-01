﻿using NorthwindProject.DataAccess;
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
    public partial class OrderCreateForm : Form
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();
        private readonly ShipperRepository _shipperRepository = new ShipperRepository();
        public OrderCreateForm()
        {
            InitializeComponent();
        }

        private void OrderCreateForm_Load(object sender, EventArgs e)
        {
            LoadCustomerComboBox();
            LoadEmployeeComboBox();
            LoadShipperComboBox();
        }

        private void LoadShipperComboBox()
        {
            cmbShipper.DataSource = _shipperRepository.GetAll();
            cmbShipper.DisplayMember = "CompanyName";
            cmbShipper.ValueMember = "ShipperID";
            cmbShipper.SelectedIndex = -1;
            cmbShipper.Text = "Please Select...";
        }

        private void LoadEmployeeComboBox()
        {
            cmbEmployee.DataSource = _employeeRepository.GetAll();
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "EmployeeID";
            cmbEmployee.SelectedIndex = -1;
            cmbEmployee.Text = "Please Select...";
        }

        private void LoadCustomerComboBox()
        {
            cmbCustomer.DataSource = _customerRepository.GetAll();
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "CustomerId";
            cmbCustomer.SelectedIndex = -1;
            cmbCustomer.Text = "Please Select...";
        }

        private void OrderCreatebtn_Click(object sender, EventArgs e)
        {
            var orderDetailEditForm = new OrderDetailEditForm();
            orderDetailEditForm.ShowDialog();
        }
    }
}