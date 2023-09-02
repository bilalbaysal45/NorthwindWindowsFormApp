namespace Northwind.Forms.Forms
{
    partial class OrderListForm
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
            dataGridOrder = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            updateToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridOrder).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridOrder
            // 
            dataGridOrder.AllowUserToAddRows = false;
            dataGridOrder.AllowUserToDeleteRows = false;
            dataGridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrder.Dock = DockStyle.Fill;
            dataGridOrder.Location = new Point(0, 0);
            dataGridOrder.MultiSelect = false;
            dataGridOrder.Name = "dataGridOrder";
            dataGridOrder.ReadOnly = true;
            dataGridOrder.RowHeadersWidth = 51;
            dataGridOrder.RowTemplate.ContextMenuStrip = contextMenuStrip1;
            dataGridOrder.RowTemplate.Height = 29;
            dataGridOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridOrder.Size = new Size(800, 450);
            dataGridOrder.TabIndex = 0;
            dataGridOrder.CellMouseDown += dataGridOrder_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { updateToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(128, 28);
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(127, 24);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // OrderListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridOrder);
            Name = "OrderListForm";
            Text = "OrderListForm";
            Load += OrderListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridOrder).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridOrder;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem updateToolStripMenuItem;
    }
}