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
    public partial class ShipperUpdateForm : Form
    {
        private int _shipperID;
        private readonly ShipperRepository _shipperRepository = new ShipperRepository();
        public ShipperUpdateForm(int shipperID)
        {
            _shipperID = shipperID;
            InitializeComponent();
        }

        private void btnShipperUpdate_Click(object sender, EventArgs e)
        {
            var shipper = new Shipper()
            {
                ShipperID = _shipperID,
                CompanyName = txtCompanyName.Text,
                Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text,
            };
            var result = _shipperRepository.Update(shipper);
            MessageBox.Show(result ? "Update Success" : "Error");
            RefreshOpenListForm();
        }

        private void RefreshOpenListForm()
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

        private void ShipperUpdateForm_Load(object sender, EventArgs e)
        {
            var shipper = _shipperRepository.Find(_shipperID);
            if (shipper != null)
            {
                txtCompanyName.Text = shipper.CompanyName;
                txtPhone.Text = shipper.Phone;
            }
        }
    }
}
