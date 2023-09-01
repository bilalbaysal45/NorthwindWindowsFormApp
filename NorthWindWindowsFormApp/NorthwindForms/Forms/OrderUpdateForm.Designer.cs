namespace Northwind.Forms.Forms
{
    partial class OrderUpdateForm
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
            numFreight = new NumericUpDown();
            txtShipCountry = new TextBox();
            txtShipPostalCode = new TextBox();
            label13 = new Label();
            label12 = new Label();
            txtShipRegion = new TextBox();
            label11 = new Label();
            txtShipCity = new TextBox();
            label10 = new Label();
            txtShipAddress = new TextBox();
            label9 = new Label();
            txtShipName = new TextBox();
            dtpShippedDate = new DateTimePicker();
            cmbShipper = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dtpRequiredDate = new DateTimePicker();
            dtpOrderDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbEmployee = new ComboBox();
            cmbCustomer = new ComboBox();
            btnUpdateOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)numFreight).BeginInit();
            SuspendLayout();
            // 
            // numFreight
            // 
            numFreight.Location = new Point(628, 98);
            numFreight.Name = "numFreight";
            numFreight.Size = new Size(250, 27);
            numFreight.TabIndex = 83;
            // 
            // txtShipCountry
            // 
            txtShipCountry.Location = new Point(628, 294);
            txtShipCountry.Name = "txtShipCountry";
            txtShipCountry.Size = new Size(250, 27);
            txtShipCountry.TabIndex = 82;
            // 
            // txtShipPostalCode
            // 
            txtShipPostalCode.Location = new Point(628, 261);
            txtShipPostalCode.Name = "txtShipPostalCode";
            txtShipPostalCode.Size = new Size(250, 27);
            txtShipPostalCode.TabIndex = 81;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(467, 297);
            label13.Name = "label13";
            label13.Size = new Size(92, 20);
            label13.TabIndex = 80;
            label13.Text = "ShipCountry:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(444, 264);
            label12.Name = "label12";
            label12.Size = new Size(115, 20);
            label12.TabIndex = 79;
            label12.Text = "ShipPostalCode:";
            // 
            // txtShipRegion
            // 
            txtShipRegion.Location = new Point(628, 228);
            txtShipRegion.Name = "txtShipRegion";
            txtShipRegion.Size = new Size(250, 27);
            txtShipRegion.TabIndex = 78;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(471, 231);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 77;
            label11.Text = "ShipRegion:";
            // 
            // txtShipCity
            // 
            txtShipCity.Location = new Point(628, 197);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(250, 27);
            txtShipCity.TabIndex = 76;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(493, 200);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 75;
            label10.Text = "ShipCity:";
            // 
            // txtShipAddress
            // 
            txtShipAddress.Location = new Point(628, 164);
            txtShipAddress.Name = "txtShipAddress";
            txtShipAddress.Size = new Size(250, 27);
            txtShipAddress.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(465, 167);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 73;
            label9.Text = "ShipAddress:";
            // 
            // txtShipName
            // 
            txtShipName.Location = new Point(628, 131);
            txtShipName.Name = "txtShipName";
            txtShipName.Size = new Size(250, 27);
            txtShipName.TabIndex = 72;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(628, 65);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(250, 27);
            dtpShippedDate.TabIndex = 71;
            // 
            // cmbShipper
            // 
            cmbShipper.FormattingEnabled = true;
            cmbShipper.Location = new Point(628, 30);
            cmbShipper.Name = "cmbShipper";
            cmbShipper.Size = new Size(250, 28);
            cmbShipper.TabIndex = 70;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(478, 134);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 69;
            label8.Text = "ShipName:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(501, 100);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 68;
            label7.Text = "Freight:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(496, 33);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 67;
            label6.Text = "Shipper:";
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(189, 178);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(250, 27);
            dtpRequiredDate.TabIndex = 66;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(189, 133);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 70);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 64;
            label5.Text = "ShippedDate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 183);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 63;
            label4.Text = "RequiredDate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 138);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 62;
            label3.Text = "OrderDate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 88);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 61;
            label2.Text = "Employee:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 60;
            label1.Text = "Customer:";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(189, 85);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(250, 28);
            cmbEmployee.TabIndex = 59;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(189, 30);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(250, 28);
            cmbCustomer.TabIndex = 58;
            // 
            // btnUpdateOrder
            // 
            btnUpdateOrder.Location = new Point(784, 381);
            btnUpdateOrder.Name = "btnUpdateOrder";
            btnUpdateOrder.Size = new Size(94, 29);
            btnUpdateOrder.TabIndex = 84;
            btnUpdateOrder.Text = "Update";
            btnUpdateOrder.UseVisualStyleBackColor = true;
            btnUpdateOrder.Click += btnUpdateOrder_Click;
            // 
            // OrderUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 500);
            Controls.Add(btnUpdateOrder);
            Controls.Add(numFreight);
            Controls.Add(txtShipCountry);
            Controls.Add(txtShipPostalCode);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtShipRegion);
            Controls.Add(label11);
            Controls.Add(txtShipCity);
            Controls.Add(label10);
            Controls.Add(txtShipAddress);
            Controls.Add(label9);
            Controls.Add(txtShipName);
            Controls.Add(dtpShippedDate);
            Controls.Add(cmbShipper);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpRequiredDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbEmployee);
            Controls.Add(cmbCustomer);
            Name = "OrderUpdateForm";
            Text = "OrderUpdateForm";
            Load += OrderUpdateForm_Load;
            ((System.ComponentModel.ISupportInitialize)numFreight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numFreight;
        private TextBox txtShipCountry;
        private TextBox txtShipPostalCode;
        private Label label13;
        private Label label12;
        private TextBox txtShipRegion;
        private Label label11;
        private TextBox txtShipCity;
        private Label label10;
        private TextBox txtShipAddress;
        private Label label9;
        private TextBox txtShipName;
        private DateTimePicker dtpShippedDate;
        private ComboBox cmbShipper;
        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpOrderDate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbEmployee;
        private ComboBox cmbCustomer;
        private Button btnUpdateOrder;
    }
}