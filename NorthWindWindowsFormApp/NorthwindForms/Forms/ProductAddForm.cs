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
    public partial class ProductAddForm : Form
    {
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();
        private readonly SupplierRepository _supplierRepository = new SupplierRepository();
        private readonly ProductRepository _productRepository = new ProductRepository();
        public ProductAddForm()
        {
            InitializeComponent();
        }
        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            LoadCategoryComboBox();
            LoadSupplierComboBox();
        }

        private void LoadCategoryComboBox()
        {
            var categoryList = _categoryRepository.GetAll();
            cmbCategories.DataSource = categoryList;
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.SelectedIndex = -1;
            cmbCategories.Text = "Please Select...";
        }

        private void LoadSupplierComboBox()
        {
            var supplierList = _supplierRepository.GetAll();
            cmbSuppliers.DataSource = supplierList;
            cmbSuppliers.DisplayMember = "CompanyName";
            cmbSuppliers.ValueMember = "SupplierID";
            cmbSuppliers.SelectedIndex = -1;
            cmbSuppliers.Text = "Please Select...";
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.ProductName = txtProductName.Text;
            if (cmbCategories.SelectedIndex != -1)
            {
                product.CategoryID = (int)cmbCategories.SelectedValue;
            }
            else
            {
                product.CategoryID = null;
            }
            if (cmbSuppliers.SelectedIndex != -1)
            {
                product.SupplierID = (int)cmbSuppliers.SelectedValue;
            }
            else
            {
                product.SupplierID = null;
            }
            product.UnitPrice = numUnitprice.Value;
            product.QuantityPerUnit = string.IsNullOrWhiteSpace(txtQuantityPerUnit.Text) 
                                                                ? null
                                                                : txtQuantityPerUnit.Text;
            product.UnitsInStock = short.TryParse(txtUnitsInStock.Text,out short unitsInStock)
                                                    ? unitsInStock 
                                                    : null;
            product.UnitsOnOrder = short.TryParse(txtUnitsOnOrder.Text,out short unitsOnOrder)
                                                    ? unitsOnOrder
                                                    : null;
            product.ReorderLevel = short.TryParse(txtReorderLevel.Text,out short reorderLevel)
                                                    ? reorderLevel
                                                    : null;
            product.Discontinued = !chkActive.Checked;
            var result = _productRepository.Add(product);
            if (result)
            {
                MessageBox.Show("Successfully Added");
                ReloadProductList();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void ReloadProductList()
        {
            foreach (var form in MdiParent.MdiChildren)
            {
                if (form is ProductListForm)
                {
                    var productListForm = form as ProductListForm;
                    productListForm.ReloadList();
                }
            }
        }

    }
}
