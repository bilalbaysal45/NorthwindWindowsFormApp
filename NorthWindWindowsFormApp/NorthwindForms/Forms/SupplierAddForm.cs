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
    public partial class SupplierAddForm : Form
    {
        private readonly SupplierRepository _supplierRepository = new SupplierRepository();
        public SupplierAddForm()
        {
            InitializeComponent();
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier()
            {
                CompanyName = txtCompanyName.Text,
                ContactName = string.IsNullOrWhiteSpace(txtContactName.Text) ? null : txtContactName.Text,
                ContactTitle = string.IsNullOrWhiteSpace(txtContactTitle.Text) ? null : txtContactTitle.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text
            };
            var result = _supplierRepository.Add(supplier);
            if (result)
            {
                MessageBox.Show("New Supplier is Added");
                RefreshSuppliersList();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
        private void RefreshSuppliersList()
        {
            foreach (var form in MdiParent.MdiChildren)
            {
                if (form is SupplierListForm)
                {
                    var supplierListForm = form as SupplierListForm;
                    supplierListForm.LoadSuppliers();
                }
            }
        }
    }
}
