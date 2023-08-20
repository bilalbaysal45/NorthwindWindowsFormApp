using NorthwindForms.Forms;

namespace NorthwindForms
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoryAddForm = new CategoryAddForm();
            categoryAddForm.MdiParent = this;
            categoryAddForm.Show();
        }

        private void categoryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoryListForm = new CategoryListForm();
            categoryListForm.MdiParent = this;
            categoryListForm.Show();
        }
    }
}