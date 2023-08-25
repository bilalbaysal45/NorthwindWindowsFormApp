namespace NorthwindForms
{
    partial class MainPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            categoryManagementToolStripMenuItem = new ToolStripMenuItem();
            newCategoryToolStripMenuItem = new ToolStripMenuItem();
            categoryListToolStripMenuItem = new ToolStripMenuItem();
            shipperManagementToolStripMenuItem = new ToolStripMenuItem();
            newShipperToolStripMenuItem = new ToolStripMenuItem();
            shipperListToolStripMenuItem = new ToolStripMenuItem();
            supplierManagementToolStripMenuItem = new ToolStripMenuItem();
            newSupplierToolStripMenuItem = new ToolStripMenuItem();
            supplierListToolStripMenuItem = new ToolStripMenuItem();
            productManagementToolStripMenuItem = new ToolStripMenuItem();
            newProductToolStripMenuItem = new ToolStripMenuItem();
            productListToolStripMenuItem = new ToolStripMenuItem();
            employeeManagementToolStripMenuItem = new ToolStripMenuItem();
            newEmployeeToolStripMenuItem = new ToolStripMenuItem();
            employeeListToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { categoryManagementToolStripMenuItem, shipperManagementToolStripMenuItem, supplierManagementToolStripMenuItem, productManagementToolStripMenuItem, employeeManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1168, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // categoryManagementToolStripMenuItem
            // 
            categoryManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newCategoryToolStripMenuItem, categoryListToolStripMenuItem });
            categoryManagementToolStripMenuItem.Name = "categoryManagementToolStripMenuItem";
            categoryManagementToolStripMenuItem.Size = new Size(175, 24);
            categoryManagementToolStripMenuItem.Text = "Category Management";
            // 
            // newCategoryToolStripMenuItem
            // 
            newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            newCategoryToolStripMenuItem.Size = new Size(186, 26);
            newCategoryToolStripMenuItem.Text = "New Category";
            newCategoryToolStripMenuItem.Click += newCategoryToolStripMenuItem_Click;
            // 
            // categoryListToolStripMenuItem
            // 
            categoryListToolStripMenuItem.Name = "categoryListToolStripMenuItem";
            categoryListToolStripMenuItem.Size = new Size(186, 26);
            categoryListToolStripMenuItem.Text = "Category List";
            categoryListToolStripMenuItem.Click += categoryListToolStripMenuItem_Click;
            // 
            // shipperManagementToolStripMenuItem
            // 
            shipperManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newShipperToolStripMenuItem, shipperListToolStripMenuItem });
            shipperManagementToolStripMenuItem.Name = "shipperManagementToolStripMenuItem";
            shipperManagementToolStripMenuItem.Size = new Size(166, 24);
            shipperManagementToolStripMenuItem.Text = "Shipper Management";
            // 
            // newShipperToolStripMenuItem
            // 
            newShipperToolStripMenuItem.Name = "newShipperToolStripMenuItem";
            newShipperToolStripMenuItem.Size = new Size(177, 26);
            newShipperToolStripMenuItem.Text = "New Shipper";
            newShipperToolStripMenuItem.Click += newShipperToolStripMenuItem_Click;
            // 
            // shipperListToolStripMenuItem
            // 
            shipperListToolStripMenuItem.Name = "shipperListToolStripMenuItem";
            shipperListToolStripMenuItem.Size = new Size(177, 26);
            shipperListToolStripMenuItem.Text = "Shipper List";
            shipperListToolStripMenuItem.Click += shipperListToolStripMenuItem_Click;
            // 
            // supplierManagementToolStripMenuItem
            // 
            supplierManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newSupplierToolStripMenuItem, supplierListToolStripMenuItem });
            supplierManagementToolStripMenuItem.Name = "supplierManagementToolStripMenuItem";
            supplierManagementToolStripMenuItem.Size = new Size(170, 24);
            supplierManagementToolStripMenuItem.Text = "Supplier Management";
            // 
            // newSupplierToolStripMenuItem
            // 
            newSupplierToolStripMenuItem.Name = "newSupplierToolStripMenuItem";
            newSupplierToolStripMenuItem.Size = new Size(181, 26);
            newSupplierToolStripMenuItem.Text = "New Supplier";
            newSupplierToolStripMenuItem.Click += newSupplierToolStripMenuItem_Click;
            // 
            // supplierListToolStripMenuItem
            // 
            supplierListToolStripMenuItem.Name = "supplierListToolStripMenuItem";
            supplierListToolStripMenuItem.Size = new Size(181, 26);
            supplierListToolStripMenuItem.Text = "Supplier List";
            supplierListToolStripMenuItem.Click += supplierListToolStripMenuItem_Click;
            // 
            // productManagementToolStripMenuItem
            // 
            productManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newProductToolStripMenuItem, productListToolStripMenuItem });
            productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            productManagementToolStripMenuItem.Size = new Size(166, 24);
            productManagementToolStripMenuItem.Text = "Product Management";
            // 
            // newProductToolStripMenuItem
            // 
            newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            newProductToolStripMenuItem.Size = new Size(177, 26);
            newProductToolStripMenuItem.Text = "New Product";
            newProductToolStripMenuItem.Click += newProductToolStripMenuItem_Click;
            // 
            // productListToolStripMenuItem
            // 
            productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            productListToolStripMenuItem.Size = new Size(177, 26);
            productListToolStripMenuItem.Text = "Product List";
            productListToolStripMenuItem.Click += productListToolStripMenuItem_Click;
            // 
            // employeeManagementToolStripMenuItem
            // 
            employeeManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newEmployeeToolStripMenuItem, employeeListToolStripMenuItem });
            employeeManagementToolStripMenuItem.Name = "employeeManagementToolStripMenuItem";
            employeeManagementToolStripMenuItem.Size = new Size(181, 24);
            employeeManagementToolStripMenuItem.Text = "Employee Management";
            // 
            // newEmployeeToolStripMenuItem
            // 
            newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            newEmployeeToolStripMenuItem.Size = new Size(224, 26);
            newEmployeeToolStripMenuItem.Text = "New Employee";
            newEmployeeToolStripMenuItem.Click += newEmployeeToolStripMenuItem_Click;
            // 
            // employeeListToolStripMenuItem
            // 
            employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            employeeListToolStripMenuItem.Size = new Size(224, 26);
            employeeListToolStripMenuItem.Text = "Employee List";
            employeeListToolStripMenuItem.Click += employeeListToolStripMenuItem_Click;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainPanel";
            Text = "Main Panel";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem categoryManagementToolStripMenuItem;
        private ToolStripMenuItem newCategoryToolStripMenuItem;
        private ToolStripMenuItem categoryListToolStripMenuItem;
        private ToolStripMenuItem shipperManagementToolStripMenuItem;
        private ToolStripMenuItem newShipperToolStripMenuItem;
        private ToolStripMenuItem shipperListToolStripMenuItem;
        private ToolStripMenuItem supplierManagementToolStripMenuItem;
        private ToolStripMenuItem newSupplierToolStripMenuItem;
        private ToolStripMenuItem supplierListToolStripMenuItem;
        private ToolStripMenuItem productManagementToolStripMenuItem;
        private ToolStripMenuItem newProductToolStripMenuItem;
        private ToolStripMenuItem productListToolStripMenuItem;
        private ToolStripMenuItem employeeManagementToolStripMenuItem;
        private ToolStripMenuItem newEmployeeToolStripMenuItem;
        private ToolStripMenuItem employeeListToolStripMenuItem;
    }
}