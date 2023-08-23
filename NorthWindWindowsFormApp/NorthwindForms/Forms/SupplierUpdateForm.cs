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
    public partial class SupplierUpdateForm : Form
    {
        private readonly SupplierRepository _supplierRepository = new SupplierRepository();
        private int _supplierID;
        public SupplierUpdateForm(int supplierId)
        {
            InitializeComponent();
            _supplierID = supplierId;
        }
        private void SupplierUpdateForm_Load(object sender, EventArgs e)
        {
            var supplier = _supplierRepository.Find(_supplierID);
            if (supplier != null)
            {
                txtCompanyName.Text = supplier.CompanyName;
                txtContactName.Text = supplier.ContactName;
                txtContactTitle.Text = supplier.ContactTitle;
                txtAddress.Text = supplier.Address;
                txtCity.Text = supplier.City;
                txtRegion.Text = supplier.Region;
                txtPostalCode.Text = supplier.PostalCode;
                txtCountry.Text = supplier.Country;
                txtPhone.Text = supplier.Phone;
                txtFax.Text = supplier.Fax;
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier()
            {
                SupplierID  = _supplierID,
                CompanyName = txtCompanyName.Text,
                ContactName = string.IsNullOrWhiteSpace(txtContactName.Text) ? null : txtContactName.Text,
                ContactTitle = string.IsNullOrWhiteSpace(txtContactTitle.Text) ? null : txtContactTitle.Text,
                Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text,
                City = string.IsNullOrWhiteSpace(txtCity.Text) ? null : txtCity.Text,
                Region = string.IsNullOrWhiteSpace(txtRegion.Text) ? null : txtRegion.Text,
                PostalCode = string.IsNullOrWhiteSpace(txtPostalCode.Text) ? null : txtPostalCode.Text,
                Country = string.IsNullOrWhiteSpace(txtCountry.Text) ? null : txtCountry.Text,
                Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text,
                Fax = string.IsNullOrWhiteSpace(txtFax.Text) ? null : txtFax.Text
            };
            var result = _supplierRepository.Update(supplier);
            if (result)
            {
                MessageBox.Show("Update Success");
                RefreshSuppliersList();
            }
            else
            {
                MessageBox.Show("Error");
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
