using NorthwindProject.DataAccess;
using NorthWindProject.WinForms.ViewModels;
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
    public partial class ProductCriticalStockForm : Form
    {
        private readonly List<ProductReorderModel> _reorderModelsList = new List<ProductReorderModel>();
        private readonly ProductRepository _productRepository = new ProductRepository();
        public ProductCriticalStockForm()
        {
            InitializeComponent();
        }

        private void ProductCriticalStockForm_Load(object sender, EventArgs e)
        {
            var productList = _productRepository.GetAll();
            foreach (var product in productList)
            {
                var productReorderModel = new ProductReorderModel();
                if (product.UnitsInStock < product.ReorderLevel)
                {
                    productReorderModel.ProductID = product.ProductID;
                    productReorderModel.ProductName = product.ProductName;
                    productReorderModel.UnitsInStock = product.UnitsInStock;
                    productReorderModel.UnitsOnOrder = product.UnitsOnOrder;
                    productReorderModel.ReorderLevel = product.ReorderLevel;

                    _reorderModelsList.Add(productReorderModel);
                    ListProductUnitsOnOrder(productReorderModel);
                }
            }
            dataGridView1.DataSource = _reorderModelsList;
        }
        private void ListProductUnitsOnOrder(ProductReorderModel productReorderModel)
        {
            if (productReorderModel.UnitsOnOrder == 0)
            {
                listUnitsOnOrder.Items.Add(productReorderModel);
                listUnitsOnOrder.DisplayMember = "ProductName";
            }
        }
    }
}
