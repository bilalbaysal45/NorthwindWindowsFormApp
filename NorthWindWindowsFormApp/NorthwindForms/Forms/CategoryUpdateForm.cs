using NorthwindProject.DataAccess;
using NorthwindProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindForms.Forms
{
    public partial class CategoryUpdateForm : Form
    {
        private int _categoryID;
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();
        public CategoryUpdateForm(int categoryID)
        {
            _categoryID = categoryID;
            InitializeComponent();
        }

        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {
            var category = _categoryRepository.Find(_categoryID);
            if (category != null)
            {
                txtCategoryName.Text = category.CategoryName;
                txtDescription.Text = category.Description;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var category = new Category()
            {
                CategoryID = _categoryID,
                CategoryName = txtCategoryName.Text,
                Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text
            };
            var result = _categoryRepository.Update(category);
            MessageBox.Show(result ? "Update Success" : "Error");
            ReloadCategories();
        }
        private void ReloadCategories()
        {
            foreach (var form in MdiParent.MdiChildren)
            {
                if(form is CategoryListForm)
                {
                    var categoryUpdateForm = form as CategoryListForm;
                    categoryUpdateForm.LoadCategories();
                }
            }
            
        }
    }
}
