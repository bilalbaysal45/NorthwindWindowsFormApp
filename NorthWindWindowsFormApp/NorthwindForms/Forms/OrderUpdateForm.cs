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
    public partial class OrderUpdateForm : Form
    {
        private int _orderID;
        private readonly OrderRepository _orderRepository = new OrderRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();
        private readonly ShipperRepository _shipperRepository = new ShipperRepository();
        public OrderUpdateForm(int orderID)
        {
            InitializeComponent();
            _orderID = orderID;
        }

        private void OrderUpdateForm_Load(object sender, EventArgs e)
        {
            LoadCustomerComboBox();
            LoadEmployeeComboBox();
            LoadShipperCombobox();
            var order = _orderRepository.Find(_orderID);
            if (order != null)
            {
                LoadOrderAreasInForm(order);
            }
        }

        private void LoadOrderAreasInForm(Order order)
        {
            cmbCustomer.SelectedValue = order.CustomerID;
            cmbEmployee.SelectedValue = order.EmployeeID;
            dtpOrderDate.Value = order.OrderDate != null ? (DateTime)order.OrderDate : default;
            dtpRequiredDate.Value = order.RequiredDate != null ? (DateTime)order.RequiredDate : default;
            cmbShipper.SelectedValue = order.ShipVia;
            dtpShippedDate.Value = order.ShippedDate != null ? (DateTime)order.ShippedDate : default;
            numFreight.Value = order.Freight != null ? (decimal)order.Freight : default;
            txtShipName.Text = order.ShipName;
            txtShipAddress.Text = order.ShipAddress;
            txtShipCity.Text = order.ShipCity;
            txtShipRegion.Text = order.ShipRegion;
            txtShipPostalCode.Text = order.ShipPostalCode;
            txtShipCountry.Text = order.ShipCountry;
        }

        private void LoadShipperCombobox()
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
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.SelectedIndex = -1;
            cmbCustomer.Text = "Please Select...";
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            var order = GetUpdatedOrder();
            var result = _orderRepository.Update(order);
            if (result)
            {
                MessageBox.Show("Update is Successfull");
                RefreshOrderListGrid();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void RefreshOrderListGrid()
        {
            foreach (var form in MdiParent.MdiChildren)
            {
                if (form is OrderListForm)
                {
                    var orderListForm = form as OrderListForm;
                    orderListForm?.RefreshOrderList();
                }
            }
        }

        private Order GetUpdatedOrder()
        {
            var order = new Order();
            order.OrderID = _orderID;
            order.CustomerID = string.IsNullOrWhiteSpace((string)cmbCustomer.SelectedValue)
                                                        ? null
                                                        : (string)cmbCustomer.SelectedValue;
            order.EmployeeID = (int?)cmbEmployee.SelectedValue != null ? (int)cmbEmployee.SelectedValue : null;
            order.OrderDate = dtpOrderDate.Value;
            order.RequiredDate = dtpRequiredDate.Value;
            order.ShipVia = (int?)cmbShipper.SelectedValue != null ? (int)cmbShipper.SelectedValue : null;
            order.Freight = numFreight.Value;
            order.ShipName = string.IsNullOrWhiteSpace(txtShipName.Text)
                                                        ? null
                                                        : txtShipName.Text;
            order.ShipAddress = string.IsNullOrWhiteSpace(txtShipAddress.Text)
                                                        ? null
                                                        : txtShipAddress.Text;
            order.ShipCity = string.IsNullOrWhiteSpace(txtShipCity.Text)
                                                        ? null
                                                        : txtShipCity.Text;
            order.ShipRegion = string.IsNullOrWhiteSpace(txtShipRegion.Text)
                                                        ? null
                                                        : txtShipRegion.Text;
            order.ShipPostalCode = string.IsNullOrWhiteSpace(txtShipPostalCode.Text)
                                                        ? null
                                                        : txtShipPostalCode.Text;
            order.ShipCountry = string.IsNullOrWhiteSpace(txtShipCountry.Text) ? null : txtShipCountry.Text;
            return order;
        }
    }
}
