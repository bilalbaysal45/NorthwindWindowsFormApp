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
    public partial class CustomerUpdateForm : Form
    {
        private string _customerID;
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        public CustomerUpdateForm(string customerID)
        {
            InitializeComponent();
            _customerID = customerID;
        }

        private void CustomerUpdateForm_Load(object sender, EventArgs e)
        {
            var customer = _customerRepository.Find(_customerID);
            if (customer != null)
            {
                txtCompanyName.Text = customer.CompanyName;
                txtContactName.Text = customer.ContactName;
                txtContactTitle.Text = customer.ContactTitle;
                txtAddress.Text = customer.Address;
                txtCity.Text = customer.City;
                txtRegion.Text = customer.Region;
                txtPostalCode.Text = customer.PostalCode;
                txtCountry.Text = customer.Country;
                txtPhone.Text = customer.Phone;
                txtFax.Text = customer.Fax;
            }
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.CustomerID = _customerID;
            customer.CompanyName = txtCompanyName.Text;
            customer.ContactName = string.IsNullOrWhiteSpace(txtContactName.Text) ? null : txtContactName.Text;
            customer.ContactTitle = string.IsNullOrWhiteSpace(txtContactTitle.Text) ? null : txtContactTitle.Text;
            customer.Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text;
            customer.City = string.IsNullOrWhiteSpace(txtCity.Text) ? null : txtCity.Text;
            customer.Region = string.IsNullOrWhiteSpace(txtRegion.Text) ? null : txtRegion.Text;
            customer.PostalCode = string.IsNullOrWhiteSpace(txtPostalCode.Text) ? null : txtPostalCode.Text;
            customer.Country = string.IsNullOrWhiteSpace(txtCountry.Text) ? null : txtCountry.Text;
            customer.Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text;
            customer.Fax = string.IsNullOrWhiteSpace(txtFax.Text) ? null : txtFax.Text;

            var result = _customerRepository.Update(customer);
            if (result)
            {
                MessageBox.Show("Update is Successfull");
                RefreshCustomerListForm();
            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void RefreshCustomerListForm()
        {
            foreach (var form in MdiParent.MdiChildren)
            {
                if (form is CustomerListForm)
                {
                    var customerListForm = form as CustomerListForm;
                    customerListForm.RefreshCustomerList();
                }
            }
        }
    }
}
