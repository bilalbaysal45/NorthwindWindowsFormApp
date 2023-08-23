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
    public partial class SupplierListForm : Form
    {
        private readonly SupplierRepository _supplierRepository = new SupplierRepository();
        public SupplierListForm()
        {
            InitializeComponent();
        }

        private void SupplierListForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }
        public void LoadSuppliers()
        {
            dataGridSuppliers.DataSource = null;
            dataGridSuppliers.DataSource = _supplierRepository.GetAll();
        }

        private void dataGridSuppliers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridSuppliers.Rows[e.RowIndex].Selected = true;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var supplier = (Supplier)dataGridSuppliers.SelectedRows[0].DataBoundItem;
            var supplierUpdateForm = new SupplierUpdateForm(supplier.SupplierID);
            supplierUpdateForm.MdiParent = MdiParent;
            supplierUpdateForm.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Test","Warning",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var supplier = (Supplier)dataGridSuppliers.SelectedRows[0].DataBoundItem;
                var result = _supplierRepository.Remove(supplier);
                if (result)
                {
                    MessageBox.Show("Item Deleted");
                    LoadSuppliers();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Remove Cancelled");
            }
        }
    }
}
