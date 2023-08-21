using NorthwindProject.DataAccess;
using NorthwindProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindForms.Forms
{
    public partial class CategoryListForm : Form
    {
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();
        public CategoryListForm()
        {
            InitializeComponent();
        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        public void LoadCategories()
        {
            dataGridCategory.DataSource = null;
            dataGridCategory.DataSource = _categoryRepository.GetAll();
        }

        private void dataGridCategory_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridCategory.Rows[e.RowIndex].Selected = true;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var category = (Category)dataGridCategory.SelectedRows[0].DataBoundItem;
            var categoryUpdateForm = new CategoryUpdateForm(category.CategoryID);
            categoryUpdateForm.MdiParent = MdiParent;
            categoryUpdateForm.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var category = (Category)dataGridCategory.SelectedRows[0].DataBoundItem;

            DialogResult dialogResult = MessageBox.Show("Do You Want To Remove this Line"
                                                        ,"Warning"
                                                        ,MessageBoxButtons.YesNo);;
            if(dialogResult == DialogResult.Yes)
            {
                _categoryRepository.Remove(category);
                LoadCategories();
                MessageBox.Show("Successfully Removed");
            }
            else if(dialogResult == DialogResult.No)
            {
                MessageBox.Show("Cancelled Remove");
            }
        }
    }
}
