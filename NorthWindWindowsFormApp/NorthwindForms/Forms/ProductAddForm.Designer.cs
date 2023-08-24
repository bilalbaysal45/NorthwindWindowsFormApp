namespace Northwind.Forms.Forms
{
    partial class ProductAddForm
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
            txtQuantityPerUnit = new TextBox();
            btnProductSave = new Button();
            chkActive = new CheckBox();
            txtReorderLevel = new MaskedTextBox();
            txtUnitsOnOrder = new MaskedTextBox();
            txtUnitsInStock = new MaskedTextBox();
            numUnitprice = new NumericUpDown();
            cmbSuppliers = new ComboBox();
            cmbCategoryName = new ComboBox();
            txtProductName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUnitprice).BeginInit();
            SuspendLayout();
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.Location = new Point(135, 147);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new Size(165, 27);
            txtQuantityPerUnit.TabIndex = 78;
            // 
            // btnProductSave
            // 
            btnProductSave.Location = new Point(206, 345);
            btnProductSave.Name = "btnProductSave";
            btnProductSave.Size = new Size(94, 29);
            btnProductSave.TabIndex = 77;
            btnProductSave.Text = "Save";
            btnProductSave.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(135, 304);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(72, 24);
            chkActive.TabIndex = 76;
            chkActive.Text = "Active";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Location = new Point(135, 256);
            txtReorderLevel.Mask = "00000";
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(165, 27);
            txtReorderLevel.TabIndex = 75;
            txtReorderLevel.ValidatingType = typeof(int);
            // 
            // txtUnitsOnOrder
            // 
            txtUnitsOnOrder.Location = new Point(135, 218);
            txtUnitsOnOrder.Mask = "00000";
            txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            txtUnitsOnOrder.Size = new Size(165, 27);
            txtUnitsOnOrder.TabIndex = 74;
            txtUnitsOnOrder.ValidatingType = typeof(int);
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(135, 183);
            txtUnitsInStock.Mask = "00000";
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(165, 27);
            txtUnitsInStock.TabIndex = 73;
            txtUnitsInStock.ValidatingType = typeof(int);
            // 
            // numUnitprice
            // 
            numUnitprice.Location = new Point(135, 114);
            numUnitprice.Name = "numUnitprice";
            numUnitprice.Size = new Size(165, 27);
            numUnitprice.TabIndex = 72;
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(135, 83);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(165, 28);
            cmbSuppliers.TabIndex = 71;
            // 
            // cmbCategoryName
            // 
            cmbCategoryName.FormattingEnabled = true;
            cmbCategoryName.Location = new Point(135, 51);
            cmbCategoryName.Name = "cmbCategoryName";
            cmbCategoryName.Size = new Size(165, 28);
            cmbCategoryName.TabIndex = 70;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(135, 16);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(165, 27);
            txtProductName.TabIndex = 69;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 305);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 68;
            label10.Text = "Discontinued:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 190);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 67;
            label9.Text = "UnitsInStock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 221);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 66;
            label8.Text = "UnitsOnOrder:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 152);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 65;
            label7.Text = "QuantityPerUnit:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 263);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 64;
            label6.Text = "ReorderLevel:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 116);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 63;
            label5.Text = "Unit Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 86);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 62;
            label4.Text = "Suppliers:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 54);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 61;
            label3.Text = "Categories:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 19);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 60;
            label2.Text = "ProductName:";
            // 
            // ProductAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtQuantityPerUnit);
            Controls.Add(btnProductSave);
            Controls.Add(chkActive);
            Controls.Add(txtReorderLevel);
            Controls.Add(txtUnitsOnOrder);
            Controls.Add(txtUnitsInStock);
            Controls.Add(numUnitprice);
            Controls.Add(cmbSuppliers);
            Controls.Add(cmbCategoryName);
            Controls.Add(txtProductName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ProductAddForm";
            Text = "ProductAddForm";
            ((System.ComponentModel.ISupportInitialize)numUnitprice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuantityPerUnit;
        private Button btnProductSave;
        private CheckBox chkActive;
        private MaskedTextBox txtReorderLevel;
        private MaskedTextBox txtUnitsOnOrder;
        private MaskedTextBox txtUnitsInStock;
        private NumericUpDown numUnitprice;
        private ComboBox cmbSuppliers;
        private ComboBox cmbCategoryName;
        private TextBox txtProductName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}