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
    public partial class CustomerAddForm : Form
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        public CustomerAddForm()
        {
            InitializeComponent();
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            var result = _customerRepository.Add(GetCustomerInfoFromUser());

            if (result)
            {
                MessageBox.Show("Adding New Customer is Successfull.");
                RefreshCustomerList();
            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void RefreshCustomerList()
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

        private Customer GetCustomerInfoFromUser()
        {
            var customer = new Customer();
            customer.CustomerID = _customerRepository.CreateID(txtCompanyName.Text);
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
            return customer;
        }

    }
}
