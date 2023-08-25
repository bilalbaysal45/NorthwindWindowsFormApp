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
    public partial class EmployeeListForm : Form
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            RefreshEmployeeList();
        }

        public void RefreshEmployeeList()
        {
            dataGridEmployee.DataSource = null;
            dataGridEmployee.DataSource = _employeeRepository.GetAll();
        }

        private void dataGridEmployee_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridEmployee.Rows[e.RowIndex].Selected = true;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employee = (Employee)dataGridEmployee.SelectedRows[0].DataBoundItem;
            var employeeUpdateForm = new EmployeeUpdateForm(employee.EmployeeID);
            employeeUpdateForm.MdiParent = MdiParent;
            employeeUpdateForm.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Want To Remove ?","Warning",MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var employee = (Employee)dataGridEmployee.SelectedRows[0].DataBoundItem;
                var result = _employeeRepository.Remove(employee);
                if (result)
                {
                    MessageBox.Show("Remove is Successfull");
                    RefreshEmployeeList();
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
