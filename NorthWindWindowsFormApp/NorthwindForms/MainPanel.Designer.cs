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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { categoryManagementToolStripMenuItem, shipperManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
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
            newShipperToolStripMenuItem.Size = new Size(224, 26);
            newShipperToolStripMenuItem.Text = "New Shipper";
            newShipperToolStripMenuItem.Click += newShipperToolStripMenuItem_Click;
            // 
            // shipperListToolStripMenuItem
            // 
            shipperListToolStripMenuItem.Name = "shipperListToolStripMenuItem";
            shipperListToolStripMenuItem.Size = new Size(224, 26);
            shipperListToolStripMenuItem.Text = "Shipper List";
            shipperListToolStripMenuItem.Click += shipperListToolStripMenuItem_Click;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}