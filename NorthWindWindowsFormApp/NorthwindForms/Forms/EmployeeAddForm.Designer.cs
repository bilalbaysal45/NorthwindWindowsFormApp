namespace Northwind.Forms.Forms
{
    partial class EmployeeAddForm
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
            label15 = new Label();
            txtNotes = new TextBox();
            btnSaveEmployee = new Button();
            cmbReportsTo = new ComboBox();
            txtExtension = new MaskedTextBox();
            txtHomePhone = new MaskedTextBox();
            txtCountry = new TextBox();
            txtPostalCode = new TextBox();
            txtRegion = new TextBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtHireDate = new MaskedTextBox();
            txtBirthDate = new MaskedTextBox();
            cmbTitleOfCourtesy = new ComboBox();
            txtTitle = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(80, 483);
            label15.Name = "label15";
            label15.Size = new Size(51, 20);
            label15.TabIndex = 61;
            label15.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(165, 480);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(125, 34);
            txtNotes.TabIndex = 60;
            // 
            // btnSaveEmployee
            // 
            btnSaveEmployee.Location = new Point(196, 574);
            btnSaveEmployee.Name = "btnSaveEmployee";
            btnSaveEmployee.Size = new Size(94, 29);
            btnSaveEmployee.TabIndex = 59;
            btnSaveEmployee.Text = "Save";
            btnSaveEmployee.UseVisualStyleBackColor = true;
            btnSaveEmployee.Click += btnSaveEmployee_Click;
            // 
            // cmbReportsTo
            // 
            cmbReportsTo.FormattingEnabled = true;
            cmbReportsTo.Location = new Point(165, 521);
            cmbReportsTo.Name = "cmbReportsTo";
            cmbReportsTo.Size = new Size(151, 28);
            cmbReportsTo.TabIndex = 58;
            // 
            // txtExtension
            // 
            txtExtension.Location = new Point(165, 441);
            txtExtension.Mask = "0000";
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(125, 27);
            txtExtension.TabIndex = 57;
            txtExtension.ValidatingType = typeof(int);
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(165, 398);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(125, 27);
            txtHomePhone.TabIndex = 56;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(165, 357);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(125, 27);
            txtCountry.TabIndex = 55;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(165, 320);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(125, 27);
            txtPostalCode.TabIndex = 54;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(165, 289);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(125, 27);
            txtRegion.TabIndex = 53;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(165, 256);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 52;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(165, 218);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 34);
            txtAddress.TabIndex = 51;
            // 
            // txtHireDate
            // 
            txtHireDate.Location = new Point(165, 187);
            txtHireDate.Mask = "00/00/0000";
            txtHireDate.Name = "txtHireDate";
            txtHireDate.Size = new Size(125, 27);
            txtHireDate.TabIndex = 50;
            txtHireDate.ValidatingType = typeof(DateTime);
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(165, 154);
            txtBirthDate.Mask = "00/00/0000";
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(125, 27);
            txtBirthDate.TabIndex = 49;
            txtBirthDate.ValidatingType = typeof(DateTime);
            // 
            // cmbTitleOfCourtesy
            // 
            cmbTitleOfCourtesy.FormattingEnabled = true;
            cmbTitleOfCourtesy.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs.", "Dr." });
            cmbTitleOfCourtesy.Location = new Point(165, 122);
            cmbTitleOfCourtesy.Name = "cmbTitleOfCourtesy";
            cmbTitleOfCourtesy.Size = new Size(151, 28);
            cmbTitleOfCourtesy.TabIndex = 48;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(165, 89);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 47;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(165, 59);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 46;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(165, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 45;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(52, 524);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 44;
            label14.Text = "ReportsTo:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(56, 444);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 43;
            label13.Text = "Extension:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 401);
            label12.Name = "label12";
            label12.Size = new Size(94, 20);
            label12.TabIndex = 42;
            label12.Text = "HomePhone:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(68, 360);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 41;
            label11.Text = "Country:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 323);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 40;
            label10.Text = "PostalCode:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 292);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 39;
            label9.Text = "Region:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(94, 259);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 38;
            label8.Text = "City:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 221);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 37;
            label7.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 190);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 36;
            label6.Text = "HireDate:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 157);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 35;
            label5.Text = "BirtDate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 125);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 34;
            label4.Text = "TitleOfCourtesy:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 92);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 33;
            label3.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 66);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 32;
            label2.Text = "LastName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 30);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 31;
            label1.Text = "FirstName:";
            // 
            // EmployeeAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 615);
            Controls.Add(label15);
            Controls.Add(txtNotes);
            Controls.Add(btnSaveEmployee);
            Controls.Add(cmbReportsTo);
            Controls.Add(txtExtension);
            Controls.Add(txtHomePhone);
            Controls.Add(txtCountry);
            Controls.Add(txtPostalCode);
            Controls.Add(txtRegion);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtHireDate);
            Controls.Add(txtBirthDate);
            Controls.Add(cmbTitleOfCourtesy);
            Controls.Add(txtTitle);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeAddForm";
            Text = "EmployeeAddForm";
            Load += EmployeeAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private TextBox txtNotes;
        private Button btnSaveEmployee;
        private ComboBox cmbReportsTo;
        private MaskedTextBox txtExtension;
        private MaskedTextBox txtHomePhone;
        private TextBox txtCountry;
        private TextBox txtPostalCode;
        private TextBox txtRegion;
        private TextBox txtCity;
        private TextBox txtAddress;
        private MaskedTextBox txtHireDate;
        private MaskedTextBox txtBirthDate;
        private ComboBox cmbTitleOfCourtesy;
        private TextBox txtTitle;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}