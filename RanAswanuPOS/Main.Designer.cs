namespace RanAswanuPOS
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullDetailsOrderWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullDetailOrderWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullDetailsOrderWindowsToolStripMenuItem,
            this.fullDetailOrderWindowToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // fullDetailsOrderWindowsToolStripMenuItem
            // 
            this.fullDetailsOrderWindowsToolStripMenuItem.Name = "fullDetailsOrderWindowsToolStripMenuItem";
            this.fullDetailsOrderWindowsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.fullDetailsOrderWindowsToolStripMenuItem.Text = "Less Details Order Window";
            this.fullDetailsOrderWindowsToolStripMenuItem.Click += new System.EventHandler(this.fullDetailsOrderWindowsToolStripMenuItem_Click);
            // 
            // fullDetailOrderWindowToolStripMenuItem
            // 
            this.fullDetailOrderWindowToolStripMenuItem.Name = "fullDetailOrderWindowToolStripMenuItem";
            this.fullDetailOrderWindowToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.fullDetailOrderWindowToolStripMenuItem.Text = "Full Detail Order Window";
            this.fullDetailOrderWindowToolStripMenuItem.Click += new System.EventHandler(this.fullDetailOrderWindowToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailySalesToolStripMenuItem,
            this.cashCountToolStripMenuItem,
            this.cashBalanceToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // dailySalesToolStripMenuItem
            // 
            this.dailySalesToolStripMenuItem.Name = "dailySalesToolStripMenuItem";
            this.dailySalesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.dailySalesToolStripMenuItem.Text = "Sales Report";
            // 
            // cashCountToolStripMenuItem
            // 
            this.cashCountToolStripMenuItem.Name = "cashCountToolStripMenuItem";
            this.cashCountToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cashCountToolStripMenuItem.Text = "Cash Count";
            // 
            // cashBalanceToolStripMenuItem
            // 
            this.cashBalanceToolStripMenuItem.Name = "cashBalanceToolStripMenuItem";
            this.cashBalanceToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cashBalanceToolStripMenuItem.Text = "Cash Balance";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 486);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailySalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullDetailsOrderWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullDetailOrderWindowToolStripMenuItem;
    }
}