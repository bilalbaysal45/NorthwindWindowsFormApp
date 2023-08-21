namespace Northwind.Forms.Forms
{
    partial class ShipperAddForm
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
            btnShipperAdd = new Button();
            label9 = new Label();
            txtPhone = new TextBox();
            label1 = new Label();
            txtCompanyName = new TextBox();
            SuspendLayout();
            // 
            // btnShipperAdd
            // 
            btnShipperAdd.Location = new Point(158, 151);
            btnShipperAdd.Name = "btnShipperAdd";
            btnShipperAdd.Size = new Size(94, 29);
            btnShipperAdd.TabIndex = 62;
            btnShipperAdd.Text = "Add";
            btnShipperAdd.UseVisualStyleBackColor = true;
            btnShipperAdd.Click += btnShipperAdd_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 96);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 60;
            label9.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(139, 93);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 63);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 47;
            label1.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(139, 60);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(125, 27);
            txtCompanyName.TabIndex = 42;
            // 
            // ShipperAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 346);
            Controls.Add(btnShipperAdd);
            Controls.Add(label9);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Controls.Add(txtCompanyName);
            Name = "ShipperAddForm";
            Text = "ShipperAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShipperAdd;
        private Label label9;
        private TextBox txtPhone;
        private Label label1;
        private TextBox txtCompanyName;
    }
}