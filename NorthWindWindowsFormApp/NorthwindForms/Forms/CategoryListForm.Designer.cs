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
            dataGridCategory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridCategory).BeginInit();
            SuspendLayout();
            // 
            // dataGridCategory
            // 
            dataGridCategory.AllowUserToAddRows = false;
            dataGridCategory.AllowUserToDeleteRows = false;
            dataGridCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCategory.Dock = DockStyle.Fill;
            dataGridCategory.Location = new Point(0, 0);
            dataGridCategory.Name = "dataGridCategory";
            dataGridCategory.ReadOnly = true;
            dataGridCategory.RowHeadersWidth = 51;
            dataGridCategory.RowTemplate.Height = 29;
            dataGridCategory.Size = new Size(800, 450);
            dataGridCategory.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridCategory;
    }
}