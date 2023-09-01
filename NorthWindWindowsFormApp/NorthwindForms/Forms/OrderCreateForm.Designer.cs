namespace Northwind.Forms.Forms
{
    partial class OrderCreateForm
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
            btnSaveOrder = new Button();
            label14 = new Label();
            gridOrderDetails = new DataGridView();
            numFreight = new NumericUpDown();
            OrderCreatebtn = new Button();
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
            ((System.ComponentModel.ISupportInitialize)gridOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFreight).BeginInit();
            SuspendLayout();
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(1033, 624);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(104, 29);
            btnSaveOrder.TabIndex = 60;
            btnSaveOrder.Text = "Save";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(50, 378);
            label14.Name = "label14";
            label14.Size = new Size(69, 20);
            label14.TabIndex = 59;
            label14.Text = "Products:";
            // 
            // gridOrderDetails
            // 
            gridOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrderDetails.Location = new Point(50, 409);
            gridOrderDetails.Name = "gridOrderDetails";
            gridOrderDetails.RowHeadersWidth = 51;
            gridOrderDetails.RowTemplate.Height = 29;
            gridOrderDetails.Size = new Size(1087, 188);
            gridOrderDetails.TabIndex = 58;
            // 
            // numFreight
            // 
            numFreight.Location = new Point(647, 91);
            numFreight.Name = "numFreight";
            numFreight.Size = new Size(250, 27);
            numFreight.TabIndex = 57;
            // 
            // OrderCreatebtn
            // 
            OrderCreatebtn.Location = new Point(1033, 374);
            OrderCreatebtn.Name = "OrderCreatebtn";
            OrderCreatebtn.Size = new Size(104, 29);
            OrderCreatebtn.TabIndex = 56;
            OrderCreatebtn.Text = "Add Product";
            OrderCreatebtn.UseVisualStyleBackColor = true;
            OrderCreatebtn.Click += OrderCreatebtn_Click;
            // 
            // txtShipCountry
            // 
            txtShipCountry.Location = new Point(647, 287);
            txtShipCountry.Name = "txtShipCountry";
            txtShipCountry.Size = new Size(250, 27);
            txtShipCountry.TabIndex = 55;
            // 
            // txtShipPostalCode
            // 
            txtShipPostalCode.Location = new Point(647, 254);
            txtShipPostalCode.Name = "txtShipPostalCode";
            txtShipPostalCode.Size = new Size(250, 27);
            txtShipPostalCode.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(486, 290);
            label13.Name = "label13";
            label13.Size = new Size(92, 20);
            label13.TabIndex = 53;
            label13.Text = "ShipCountry:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(463, 257);
            label12.Name = "label12";
            label12.Size = new Size(115, 20);
            label12.TabIndex = 52;
            label12.Text = "ShipPostalCode:";
            // 
            // txtShipRegion
            // 
            txtShipRegion.Location = new Point(647, 221);
            txtShipRegion.Name = "txtShipRegion";
            txtShipRegion.Size = new Size(250, 27);
            txtShipRegion.TabIndex = 51;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(490, 224);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 50;
            label11.Text = "ShipRegion:";
            // 
            // txtShipCity
            // 
            txtShipCity.Location = new Point(647, 190);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(250, 27);
            txtShipCity.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(512, 193);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 48;
            label10.Text = "ShipCity:";
            // 
            // txtShipAddress
            // 
            txtShipAddress.Location = new Point(647, 157);
            txtShipAddress.Name = "txtShipAddress";
            txtShipAddress.Size = new Size(250, 27);
            txtShipAddress.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(484, 160);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 46;
            label9.Text = "ShipAddress:";
            // 
            // txtShipName
            // 
            txtShipName.Location = new Point(647, 124);
            txtShipName.Name = "txtShipName";
            txtShipName.Size = new Size(250, 27);
            txtShipName.TabIndex = 45;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(647, 58);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(250, 27);
            dtpShippedDate.TabIndex = 44;
            // 
            // cmbShipper
            // 
            cmbShipper.FormattingEnabled = true;
            cmbShipper.Location = new Point(647, 23);
            cmbShipper.Name = "cmbShipper";
            cmbShipper.Size = new Size(250, 28);
            cmbShipper.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(497, 127);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 42;
            label8.Text = "ShipName:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(520, 93);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 41;
            label7.Text = "Freight:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 26);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 40;
            label6.Text = "Shipper:";
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(208, 171);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(250, 27);
            dtpRequiredDate.TabIndex = 39;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(208, 126);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 63);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 37;
            label5.Text = "ShippedDate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 176);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 36;
            label4.Text = "RequiredDate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 131);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 35;
            label3.Text = "OrderDate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 81);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 34;
            label2.Text = "Employee:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 26);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 33;
            label1.Text = "Customer:";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(208, 78);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(250, 28);
            cmbEmployee.TabIndex = 32;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(208, 23);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(250, 28);
            cmbCustomer.TabIndex = 31;
            // 
            // OrderCreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 677);
            Controls.Add(btnSaveOrder);
            Controls.Add(label14);
            Controls.Add(gridOrderDetails);
            Controls.Add(numFreight);
            Controls.Add(OrderCreatebtn);
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
            Name = "OrderCreateForm";
            Text = "OrderCreateForm";
            Load += OrderCreateForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFreight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveOrder;
        private Label label14;
        private DataGridView gridOrderDetails;
        private NumericUpDown numFreight;
        private Button OrderCreatebtn;
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
    }
}