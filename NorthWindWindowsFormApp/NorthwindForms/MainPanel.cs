using Northwind.Forms.Forms;
using NorthwindForms.Forms;

namespace NorthwindForms
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoryAddForm = new CategoryAddForm();
            categoryAddForm.MdiParent = this;
            categoryAddForm.Show();
        }

        private void categoryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoryListForm = new CategoryListForm();
            categoryListForm.MdiParent = this;
            categoryListForm.Show();
        }

        private void newShipperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var shipperAddForm = new ShipperAddForm();
            shipperAddForm.MdiParent = this;
            shipperAddForm.Show();
        }

        private void shipperListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var shipperListForm = new ShipperListForm();
            shipperListForm.MdiParent = this;
            shipperListForm.Show();
        }

        private void supplierListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var supplierListForm = new SupplierListForm();
            supplierListForm.MdiParent = this;
            supplierListForm.Show();
        }

        private void newSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var supplierAddForm = new SupplierAddForm();
            supplierAddForm.MdiParent = this;
            supplierAddForm.Show();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productListForm = new ProductListForm();
            productListForm.MdiParent = this;
            productListForm.Show();
        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productAddForm = new ProductAddForm();
            productAddForm.MdiParent = this;
            productAddForm.Show();
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeeAddForm = new EmployeeAddForm();
            employeeAddForm.MdiParent = this;
            employeeAddForm.Show();
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeeListForm = new EmployeeListForm();
            employeeListForm.MdiParent = this;
            employeeListForm.Show();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerAddForm = new CustomerAddForm();
            customerAddForm.MdiParent = this;
            customerAddForm.Show();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerListForm = new CustomerListForm();
            customerListForm.MdiParent = this;
            customerListForm.Show();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orderCreateForm = new OrderCreateForm();
            orderCreateForm.MdiParent = this;
            orderCreateForm.Show();
        }

        private void orderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ordersListForm = new OrderListForm();
            ordersListForm.MdiParent = this;
            ordersListForm.Show();
        }

        private void criticalStockListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productCriticalStockForm = new ProductCriticalStockForm();
            productCriticalStockForm.MdiParent = this;
            productCriticalStockForm.Show();
        }
    }
}