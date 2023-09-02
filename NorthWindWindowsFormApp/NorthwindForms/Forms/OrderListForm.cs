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
    public partial class OrderListForm : Form
    {
        private readonly OrderRepository _orderRepository = new OrderRepository();
        public OrderListForm()
        {
            InitializeComponent();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            RefreshOrderList();
        }

        public void RefreshOrderList()
        {
            dataGridOrder.DataSource = null;
            dataGridOrder.DataSource = _orderRepository.GetAll();
        }

        private void dataGridOrder_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridOrder.Rows[e.RowIndex].Selected = true;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var order = (Order)dataGridOrder.SelectedRows[0].DataBoundItem;
            var orderUpdateForm = new OrderUpdateForm(order.OrderID);
            orderUpdateForm.MdiParent = MdiParent;
            orderUpdateForm.Show();
        }
    }
}
