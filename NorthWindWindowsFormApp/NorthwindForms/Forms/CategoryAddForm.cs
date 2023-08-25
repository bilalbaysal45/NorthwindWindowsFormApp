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

namespace NorthwindForms.Forms
{
    public partial class CategoryAddForm : Form
    {
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();
        public CategoryAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var category = new Category()
            {
                CategoryName = txtCategoryName.Text,
                Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text,
            };
            var result = _categoryRepository.Add(category);
            //MessageBox.Show(result ? "New Category Added" : "Error!");
            if (result)
            {
                MessageBox.Show("New Category Added");
                ReloadCategories();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
        private void ReloadCategories()
        {
            foreach (var form in MdiParent.MdiChildren)
            {
                if (form is CategoryListForm)
                {
                    var categoryUpdateForm = form as CategoryListForm;
                    categoryUpdateForm.LoadCategories();
                }
            }

        }
    }
}
