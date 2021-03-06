namespace DatabasLaboration3
{
    partial class FormBookstoreManager
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
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.userControlBookstores = new DatabasLaboration3.UserControlBookstores();
            this.userControlStockBalances = new DatabasLaboration3.UserControlStockBalances();
            this.userControlInventory = new DatabasLaboration3.UserControlInventory();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.splitContainerLeft);
            this.splitContainerRight.Panel1MinSize = 200;
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.userControlInventory);
            this.splitContainerRight.Panel2MinSize = 200;
            this.splitContainerRight.Size = new System.Drawing.Size(1184, 561);
            this.splitContainerRight.SplitterDistance = 385;
            this.splitContainerRight.TabIndex = 1;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLeft.IsSplitterFixed = true;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.userControlBookstores);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.userControlStockBalances);
            this.splitContainerLeft.Size = new System.Drawing.Size(385, 561);
            this.splitContainerLeft.SplitterDistance = 156;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // userControlBookstores
            // 
            this.userControlBookstores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBookstores.Location = new System.Drawing.Point(0, 0);
            this.userControlBookstores.Margin = new System.Windows.Forms.Padding(0);
            this.userControlBookstores.Name = "userControlBookstores";
            this.userControlBookstores.Size = new System.Drawing.Size(385, 156);
            this.userControlBookstores.TabIndex = 0;
            this.userControlBookstores.BookstoreSelectionChanged += new System.EventHandler(this.userControlBookstores_BookstoreSelectionChanged);
            // 
            // userControlStockBalances
            // 
            this.userControlStockBalances.BackColor = System.Drawing.SystemColors.WindowText;
            this.userControlStockBalances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStockBalances.Location = new System.Drawing.Point(0, 0);
            this.userControlStockBalances.Margin = new System.Windows.Forms.Padding(0);
            this.userControlStockBalances.Name = "userControlStockBalances";
            this.userControlStockBalances.Size = new System.Drawing.Size(385, 401);
            this.userControlStockBalances.TabIndex = 0;
            // 
            // userControlInventory
            // 
            this.userControlInventory.BackColor = System.Drawing.SystemColors.WindowText;
            this.userControlInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlInventory.Location = new System.Drawing.Point(0, 0);
            this.userControlInventory.Name = "userControlInventory";
            this.userControlInventory.Size = new System.Drawing.Size(795, 561);
            this.userControlInventory.TabIndex = 0;
            this.userControlInventory.BookSelectionChanged += new System.EventHandler(this.userControlInventory_BookSelectionChanged);
            this.userControlInventory.AuthorSelectionChanged += new System.EventHandler(this.userControlInventory_AuthorSelectionChanged);
            this.userControlInventory.PublisherSelectionChanged += new System.EventHandler(this.userControlInventory_PublisherSelectionChanged);
            // 
            // FormBookstoreManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.splitContainerRight);
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "FormBookstoreManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookstore Manager";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private UserControlStockBalances userControlStockBalances;
        private UserControlBookstores userControlBookstores;
        private UserControlInventory userControlInventory;
    }
}

