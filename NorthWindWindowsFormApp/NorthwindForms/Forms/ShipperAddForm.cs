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
    public partial class ShipperAddForm : Form
    {
        private readonly ShipperRepository _shipperRepository = new ShipperRepository();
        public ShipperAddForm()
        {
            InitializeComponent();
        }

        private void btnShipperAdd_Click(object sender, EventArgs e)
        {
            var shipper = new Shipper()
            {
                CompanyName = txtCompanyName.Text,
                Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text,
            };
            var result = _shipperRepository.Add(shipper);

            //MessageBox.Show(result ? "Adding New Shipper is Success" : "Error");
            if (result)
            {
                MessageBox.Show("Adding New Shipper is Success");
                RefreshListForm();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
        private void RefreshListForm()
        {
            foreach (var form in MdiParent.MdiChildren)
            {
                if (form is ShipperListForm)
                {
                    var shipperListForm = form as ShipperListForm;
                    shipperListForm.LoadShippersToGrid();
                }
            }
        }
    }
}
