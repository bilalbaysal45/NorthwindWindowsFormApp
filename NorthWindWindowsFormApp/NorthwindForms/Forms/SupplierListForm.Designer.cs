namespace Northwind.Forms.Forms
{
    partial class SupplierListForm
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
            dataGridSuppliers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dataGridSuppliers
            // 
            dataGridSuppliers.AllowUserToAddRows = false;
            dataGridSuppliers.AllowUserToDeleteRows = false;
            dataGridSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSuppliers.Dock = DockStyle.Fill;
            dataGridSuppliers.Location = new Point(0, 0);
            dataGridSuppliers.Name = "dataGridSuppliers";
            dataGridSuppliers.ReadOnly = true;
            dataGridSuppliers.RowHeadersWidth = 51;
            dataGridSuppliers.RowTemplate.Height = 29;
            dataGridSuppliers.Size = new Size(800, 450);
            dataGridSuppliers.TabIndex = 0;
            // 
            // SupplierListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridSuppliers);
            Name = "SupplierListForm";
            Text = "SupplierListForm";
            Load += SupplierListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridSuppliers;
    }
}