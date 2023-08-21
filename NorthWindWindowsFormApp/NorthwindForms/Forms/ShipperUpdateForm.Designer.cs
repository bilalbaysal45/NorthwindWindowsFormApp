namespace Northwind.Forms.Forms
{
    partial class ShipperUpdateForm
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
            btnShipperUpdate = new Button();
            label9 = new Label();
            txtPhone = new TextBox();
            label1 = new Label();
            txtCompanyName = new TextBox();
            SuspendLayout();
            // 
            // btnShipperUpdate
            // 
            btnShipperUpdate.Location = new Point(156, 108);
            btnShipperUpdate.Name = "btnShipperUpdate";
            btnShipperUpdate.Size = new Size(94, 29);
            btnShipperUpdate.TabIndex = 67;
            btnShipperUpdate.Text = "Update";
            btnShipperUpdate.UseVisualStyleBackColor = true;
            btnShipperUpdate.Click += btnShipperUpdate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(78, 53);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 66;
            label9.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(137, 50);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 64;
            label1.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(137, 17);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(125, 27);
            txtCompanyName.TabIndex = 63;
            // 
            // ShipperUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 428);
            Controls.Add(btnShipperUpdate);
            Controls.Add(label9);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Controls.Add(txtCompanyName);
            Name = "ShipperUpdateForm";
            Text = "ShipperUpdateForm";
            Load += ShipperUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShipperUpdate;
        private Label label9;
        private TextBox txtPhone;
        private Label label1;
        private TextBox txtCompanyName;
    }
}