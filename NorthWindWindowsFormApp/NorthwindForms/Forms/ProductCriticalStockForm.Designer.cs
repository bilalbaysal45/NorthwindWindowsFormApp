namespace Northwind.Forms.Forms
{
    partial class ProductCriticalStockForm
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
            label2 = new Label();
            label1 = new Label();
            listUnitsOnOrder = new ListBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(559, 11);
            label2.Name = "label2";
            label2.Size = new Size(293, 20);
            label2.TabIndex = 7;
            label2.Text = "Critical and Products That Not Ordered Yet:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 6;
            label1.Text = "Critical Stock:";
            // 
            // listUnitsOnOrder
            // 
            listUnitsOnOrder.FormattingEnabled = true;
            listUnitsOnOrder.ItemHeight = 20;
            listUnitsOnOrder.Location = new Point(559, 39);
            listUnitsOnOrder.Name = "listUnitsOnOrder";
            listUnitsOnOrder.Size = new Size(293, 304);
            listUnitsOnOrder.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(541, 306);
            dataGridView1.TabIndex = 4;
            // 
            // ProductCriticalStockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 438);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listUnitsOnOrder);
            Controls.Add(dataGridView1);
            Name = "ProductCriticalStockForm";
            Text = "ProductCriticalStockForm";
            Load += ProductCriticalStockForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ListBox listUnitsOnOrder;
        private DataGridView dataGridView1;
    }
}