namespace Northwind.Forms.Forms
{
    partial class ShipperListForm
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
            components = new System.ComponentModel.Container();
            dataGridShipper = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            updateToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridShipper).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridShipper
            // 
            dataGridShipper.AllowUserToAddRows = false;
            dataGridShipper.AllowUserToDeleteRows = false;
            dataGridShipper.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridShipper.Dock = DockStyle.Fill;
            dataGridShipper.Location = new Point(0, 0);
            dataGridShipper.MultiSelect = false;
            dataGridShipper.Name = "dataGridShipper";
            dataGridShipper.ReadOnly = true;
            dataGridShipper.RowHeadersWidth = 51;
            dataGridShipper.RowTemplate.ContextMenuStrip = contextMenuStrip1;
            dataGridShipper.RowTemplate.Height = 29;
            dataGridShipper.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridShipper.Size = new Size(800, 450);
            dataGridShipper.TabIndex = 0;
            dataGridShipper.CellMouseDown += dataGridShipper_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { updateToolStripMenuItem, removeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(133, 52);
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(132, 24);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(132, 24);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // ShipperListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridShipper);
            Name = "ShipperListForm";
            Text = "ShipperListForm";
            Load += ShipperListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridShipper).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridShipper;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}