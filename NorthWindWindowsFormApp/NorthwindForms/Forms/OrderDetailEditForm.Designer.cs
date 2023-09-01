namespace Northwind.Forms.Forms
{
    partial class OrderDetailEditForm
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
            numDiscount = new NumericUpDown();
            txtPrice = new TextBox();
            btnProductAdd = new Button();
            numQuantity = new NumericUpDown();
            cmbProducts = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // numDiscount
            // 
            numDiscount.Location = new Point(147, 140);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(150, 27);
            numDiscount.TabIndex = 19;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(147, 60);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(151, 27);
            txtPrice.TabIndex = 18;
            // 
            // btnProductAdd
            // 
            btnProductAdd.Location = new Point(204, 196);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(94, 29);
            btnProductAdd.TabIndex = 17;
            btnProductAdd.Text = "Add";
            btnProductAdd.UseVisualStyleBackColor = true;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(147, 102);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 27);
            numQuantity.TabIndex = 16;
            // 
            // cmbProducts
            // 
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(147, 21);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(151, 28);
            cmbProducts.TabIndex = 15;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 142);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 14;
            label4.Text = "Discount(%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 104);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 13;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 63);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 12;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 24);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 11;
            label1.Text = "Product:";
            // 
            // OrderDetailEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numDiscount);
            Controls.Add(txtPrice);
            Controls.Add(btnProductAdd);
            Controls.Add(numQuantity);
            Controls.Add(cmbProducts);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderDetailEditForm";
            Text = "OrderDetailEditForm";
            Load += OrderDetailEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numDiscount;
        private TextBox txtPrice;
        private Button btnProductAdd;
        private NumericUpDown numQuantity;
        private ComboBox cmbProducts;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}