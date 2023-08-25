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
    public partial class ProductListForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            ReloadList();
        }
        public void ReloadList()
        {
            dataGridProductList.DataSource = null;
            dataGridProductList.DataSource = _productRepository.GetAll();
        }

        private void dataGridProductList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridProductList.Rows[e.RowIndex].Selected = true;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var product = (Product)dataGridProductList.SelectedRows[0].DataBoundItem;
            var productUpdateForm = new ProductUpdateForm(product.ProductID);
            productUpdateForm.MdiParent = MdiParent;
            productUpdateForm.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Want To Remove?"
                                                        ,"Warning"
                                                        ,MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                var product = (Product)dataGridProductList.SelectedRows[0].DataBoundItem;
                var result = _productRepository.Remove(product);
                if (result)
                {
                    MessageBox.Show("Successfully Removed");
                    ReloadList();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else if(dialogResult == DialogResult.No)
            {
                MessageBox.Show("Remove Cancelled");
            }

        }
    }
}
