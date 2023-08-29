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
    public partial class CustomerListForm : Form
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void dataGridCustomers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridCustomers.Rows[e.RowIndex].Selected = true;
            }
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            RefreshCustomerList();
        }

        public void RefreshCustomerList()
        {
            dataGridCustomers.DataSource = null;
            dataGridCustomers.DataSource = _customerRepository.GetAll();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customer = (Customer)dataGridCustomers.SelectedRows[0].DataBoundItem;
            var customerUpdateForm = new CustomerUpdateForm(customer.CustomerID);
            customerUpdateForm.MdiParent = MdiParent;
            customerUpdateForm.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customer = (Customer)dataGridCustomers.SelectedRows[0].DataBoundItem;
            DialogResult dialogResult = MessageBox.Show("Do you want to Remove ?"
                                            ,"Warning"
                                            ,MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var result = _customerRepository.Remove(customer);
                if (result)
                {
                    MessageBox.Show("Remove is Successfull...");
                    RefreshCustomerList();
                }
                else
                {
                    MessageBox.Show("Error!!!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Remove Cancelled...");
            }
        }
    }
}
