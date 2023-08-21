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
    public partial class ShipperListForm : Form
    {
        private readonly ShipperRepository _shipperRepository = new ShipperRepository();
        public ShipperListForm()
        {
            InitializeComponent();
        }

        private void ShipperListForm_Load(object sender, EventArgs e)
        {
            LoadShippersToGrid();
        }

        public void LoadShippersToGrid()
        {
            dataGridShipper.DataSource = null;
            dataGridShipper.DataSource = _shipperRepository.GetAll();
        }

        private void dataGridShipper_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridShipper.Rows[e.RowIndex].Selected = true;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var shipper = (Shipper)dataGridShipper.SelectedRows[0].DataBoundItem;
            var shipperUpdateForm = new ShipperUpdateForm(shipper.ShipperID);
            shipperUpdateForm.MdiParent = MdiParent;
            shipperUpdateForm.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var shipper = (Shipper)dataGridShipper.SelectedRows[0].DataBoundItem;
            DialogResult dialogResult = MessageBox.Show("Do You Want To Remove this Line"
                                                   , "Warning"
                                                   , MessageBoxButtons.YesNo); ;
            if (dialogResult == DialogResult.Yes)
            {
                _shipperRepository.Remove(shipper);
                LoadShippersToGrid();
                MessageBox.Show("Successfully Removed");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Cancelled Remove");
            }
        }
    }
}
