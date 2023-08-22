using NorthwindProject.DataAccess;
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
            dataGridSuppliers.DataSource = _supplierRepository.GetAll();
        }
    }
}
