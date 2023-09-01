using Northwind.Forms.ViewModels;
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
    public partial class OrderDetailEditForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();

        public delegate void OrderDetailCreatedHandler(OrderDetailInputModel orderDetailInput);
        public event OrderDetailCreatedHandler OrderDetailCreated;
        public OrderDetailEditForm()
        {
            InitializeComponent();
        }

        private void OrderDetailEditForm_Load(object sender, EventArgs e)
        {
            LoadProductsComboBox();
        }

        private void LoadProductsComboBox()
        {
            cmbProducts.DataSource = _productRepository.GetAll();
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.ValueMember = "ProductID";
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = new Product();
            if (cmbProducts.SelectedIndex > -1)
            {
                product = (Product)cmbProducts.SelectedItem;
                txtPrice.Text = product.UnitPrice != null ? product.UnitPrice.ToString() : default(decimal).ToString();
            }
            else
            {
                txtPrice.Text = string.Empty;
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            var orderDetailInput = new OrderDetailInputModel();
            orderDetailInput.ProductID = (int)cmbProducts.SelectedValue;
            orderDetailInput.ProductName = cmbProducts.Text;
            orderDetailInput.UnitPrice = decimal.TryParse(txtPrice.Text,out decimal price) ? price : default;
            orderDetailInput.Quantity = (short)numQuantity.Value;
            orderDetailInput.Discount = (float)numDiscount.Value / 100;

            OrderDetailCreated?.Invoke(orderDetailInput);
        }
    }
}
