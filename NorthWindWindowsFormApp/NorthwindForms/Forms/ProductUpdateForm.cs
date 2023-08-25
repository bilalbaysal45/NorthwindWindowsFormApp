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
    public partial class ProductUpdateForm : Form
    {
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();
        private readonly SupplierRepository _supplierRepository = new SupplierRepository();
        private readonly ProductRepository _productRepository = new ProductRepository();
        private int _productID;
        public ProductUpdateForm(int productID)
        {
            InitializeComponent();
            _productID = productID;
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesComboBox();
            LoadSuppliersComboBox();
            LoadProduct();
        }

        private void LoadProduct()
        {
            var product = _productRepository.Find(_productID);
            if (product != null)
            {
                txtProductName.Text = product.ProductName;
                cmbCategories.SelectedValue = product.CategoryID != null ? product.CategoryID : -1;
                cmbSuppliers.SelectedValue = product.SupplierID != null ? product.SupplierID : -1;
                numUnitprice.Value = product.UnitPrice != null ? (decimal)product.UnitPrice : (decimal)default;
                txtQuantityPerUnit.Text = product.QuantityPerUnit;
                txtUnitsInStock.Text = product.UnitsInStock.ToString();
                txtUnitsOnOrder.Text = product.UnitsOnOrder.ToString();
                txtReorderLevel.Text = product.ReorderLevel.ToString();
                chkActive.Checked = !product.Discontinued;
            }
        }

        private void LoadSuppliersComboBox()
        {
            cmbSuppliers.DataSource = _supplierRepository.GetAll();
            cmbSuppliers.DisplayMember = "CompanyName";
            cmbSuppliers.ValueMember = "SupplierID";
            cmbSuppliers.SelectedIndex = -1;
            cmbSuppliers.Text = "Please Select...";
        }

        private void LoadCategoriesComboBox()
        {
            cmbCategories.DataSource = _categoryRepository.GetAll();
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.SelectedIndex = -1;
            cmbCategories.Text = "Please Select...";
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.ProductID = _productID;
            product.ProductName = txtProductName.Text;
            product.CategoryID = (int?)cmbCategories.SelectedValue;
            product.SupplierID = (int?)cmbSuppliers.SelectedValue;
            product.UnitPrice = numUnitprice.Value;
            product.QuantityPerUnit = txtQuantityPerUnit.Text;
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

            var result = _productRepository.Update(product);

            if (result)
            {
                MessageBox.Show("Successfully Updated");
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
