namespace NorthwindForms.Forms
{
    partial class CategoryListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridCategory = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            updateToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridCategory).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCategory
            // 
            dataGridCategory.AllowUserToAddRows = false;
            dataGridCategory.AllowUserToDeleteRows = false;
            dataGridCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCategory.Dock = DockStyle.Fill;
            dataGridCategory.Location = new Point(0, 0);
            dataGridCategory.MultiSelect = false;
            dataGridCategory.Name = "dataGridCategory";
            dataGridCategory.ReadOnly = true;
            dataGridCategory.RowHeadersWidth = 51;
            dataGridCategory.RowTemplate.ContextMenuStrip = contextMenuStrip1;
            dataGridCategory.RowTemplate.Height = 29;
            dataGridCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCategory.Size = new Size(800, 450);
            dataGridCategory.TabIndex = 0;
            dataGridCategory.CellMouseDown += dataGridCategory_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { updateToolStripMenuItem, removeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 80);
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(210, 24);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(210, 24);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // CategoryListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridCategory);
            Name = "CategoryListForm";
            Text = "CategoryListForm";
            Load += CategoryListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCategory).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridCategory;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}