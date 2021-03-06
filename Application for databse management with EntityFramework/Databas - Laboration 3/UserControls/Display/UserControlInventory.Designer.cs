
namespace DatabasLaboration3
{
    partial class UserControlInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInventoryInfo = new System.Windows.Forms.Panel();
            this.labelInventory = new System.Windows.Forms.Label();
            this.panelInventoryButtons = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonInventoryRemove = new System.Windows.Forms.Button();
            this.buttonInventoryAdd = new System.Windows.Forms.Button();
            this.buttonInventoryEdit = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.userControlBooks = new DatabasLaboration3.UserControlBooks();
            this.tabPageAuthors = new System.Windows.Forms.TabPage();
            this.userControlAuthors = new DatabasLaboration3.UserControlAuthors();
            this.tabPagePublishers = new System.Windows.Forms.TabPage();
            this.userControlPublishers = new DatabasLaboration3.UserControlPublishers();
            this.panelInventoryInfo.SuspendLayout();
            this.panelInventoryButtons.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            this.tabPageAuthors.SuspendLayout();
            this.tabPagePublishers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInventoryInfo
            // 
            this.panelInventoryInfo.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelInventoryInfo.Controls.Add(this.labelInventory);
            this.panelInventoryInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventoryInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInventoryInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelInventoryInfo.Name = "panelInventoryInfo";
            this.panelInventoryInfo.Size = new System.Drawing.Size(800, 25);
            this.panelInventoryInfo.TabIndex = 3;
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.ForeColor = System.Drawing.SystemColors.Window;
            this.labelInventory.Location = new System.Drawing.Point(5, 5);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(62, 15);
            this.labelInventory.TabIndex = 9;
            this.labelInventory.Text = "Sortiment:";
            // 
            // panelInventoryButtons
            // 
            this.panelInventoryButtons.Controls.Add(this.buttonAdd);
            this.panelInventoryButtons.Controls.Add(this.buttonEdit);
            this.panelInventoryButtons.Controls.Add(this.buttonRemove);
            this.panelInventoryButtons.Controls.Add(this.buttonInventoryRemove);
            this.panelInventoryButtons.Controls.Add(this.buttonInventoryAdd);
            this.panelInventoryButtons.Controls.Add(this.buttonInventoryEdit);
            this.panelInventoryButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInventoryButtons.Location = new System.Drawing.Point(0, 470);
            this.panelInventoryButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelInventoryButtons.Name = "panelInventoryButtons";
            this.panelInventoryButtons.Size = new System.Drawing.Size(800, 30);
            this.panelInventoryButtons.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(642, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Lägg till";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(723, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Ändra";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(2, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(69, 23);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Ta bort";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonInventoryRemove
            // 
            this.buttonInventoryRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInventoryRemove.Location = new System.Drawing.Point(4, -67);
            this.buttonInventoryRemove.Name = "buttonInventoryRemove";
            this.buttonInventoryRemove.Size = new System.Drawing.Size(69, 23);
            this.buttonInventoryRemove.TabIndex = 6;
            this.buttonInventoryRemove.Text = "Ta bort";
            this.buttonInventoryRemove.UseVisualStyleBackColor = true;
            // 
            // buttonInventoryAdd
            // 
            this.buttonInventoryAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInventoryAdd.Location = new System.Drawing.Point(1542, -67);
            this.buttonInventoryAdd.Name = "buttonInventoryAdd";
            this.buttonInventoryAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonInventoryAdd.TabIndex = 5;
            this.buttonInventoryAdd.Text = "Lägg till";
            this.buttonInventoryAdd.UseVisualStyleBackColor = true;
            // 
            // buttonInventoryEdit
            // 
            this.buttonInventoryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInventoryEdit.Location = new System.Drawing.Point(1623, -67);
            this.buttonInventoryEdit.Name = "buttonInventoryEdit";
            this.buttonInventoryEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonInventoryEdit.TabIndex = 4;
            this.buttonInventoryEdit.Text = "Ändra";
            this.buttonInventoryEdit.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageBooks);
            this.tabControl.Controls.Add(this.tabPageAuthors);
            this.tabControl.Controls.Add(this.tabPagePublishers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 445);
            this.tabControl.TabIndex = 6;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.userControlBooks);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 24);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(792, 417);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Böcker";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // userControlBooks
            // 
            this.userControlBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBooks.Location = new System.Drawing.Point(3, 3);
            this.userControlBooks.Margin = new System.Windows.Forms.Padding(0);
            this.userControlBooks.Name = "userControlBooks";
            this.userControlBooks.Size = new System.Drawing.Size(786, 411);
            this.userControlBooks.TabIndex = 0;
            this.userControlBooks.SelectionChanged += new System.EventHandler(this.userControlBooks_SelectionChanged);
            // 
            // tabPageAuthors
            // 
            this.tabPageAuthors.Controls.Add(this.userControlAuthors);
            this.tabPageAuthors.Location = new System.Drawing.Point(4, 24);
            this.tabPageAuthors.Name = "tabPageAuthors";
            this.tabPageAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthors.Size = new System.Drawing.Size(792, 417);
            this.tabPageAuthors.TabIndex = 1;
            this.tabPageAuthors.Text = "Författare";
            this.tabPageAuthors.UseVisualStyleBackColor = true;
            // 
            // userControlAuthors
            // 
            this.userControlAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAuthors.Location = new System.Drawing.Point(3, 3);
            this.userControlAuthors.Margin = new System.Windows.Forms.Padding(0);
            this.userControlAuthors.Name = "userControlAuthors";
            this.userControlAuthors.Size = new System.Drawing.Size(786, 411);
            this.userControlAuthors.TabIndex = 0;
            this.userControlAuthors.SelectionChanged += new System.EventHandler(this.userControlAuthors_SelectionChanged);
            // 
            // tabPagePublishers
            // 
            this.tabPagePublishers.Controls.Add(this.userControlPublishers);
            this.tabPagePublishers.Location = new System.Drawing.Point(4, 24);
            this.tabPagePublishers.Name = "tabPagePublishers";
            this.tabPagePublishers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePublishers.Size = new System.Drawing.Size(792, 417);
            this.tabPagePublishers.TabIndex = 2;
            this.tabPagePublishers.Text = "Förlag";
            this.tabPagePublishers.UseVisualStyleBackColor = true;
            // 
            // userControlPublishers
            // 
            this.userControlPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPublishers.Location = new System.Drawing.Point(3, 3);
            this.userControlPublishers.Margin = new System.Windows.Forms.Padding(0);
            this.userControlPublishers.Name = "userControlPublishers";
            this.userControlPublishers.Size = new System.Drawing.Size(786, 411);
            this.userControlPublishers.TabIndex = 0;
            this.userControlPublishers.SelectionChanged += new System.EventHandler(this.userControlPublishers_SelectionChanged);
            // 
            // UserControlInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelInventoryButtons);
            this.Controls.Add(this.panelInventoryInfo);
            this.Name = "UserControlInventory";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.UserControlInventory_Load);
            this.panelInventoryInfo.ResumeLayout(false);
            this.panelInventoryInfo.PerformLayout();
            this.panelInventoryButtons.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageAuthors.ResumeLayout(false);
            this.tabPagePublishers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInventoryInfo;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Panel panelInventoryButtons;
        private System.Windows.Forms.Button buttonInventoryRemove;
        private System.Windows.Forms.Button buttonInventoryAdd;
        private System.Windows.Forms.Button buttonInventoryEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageBooks;
        private UserControlBooks userControlBooks;
        private System.Windows.Forms.TabPage tabPageAuthors;
        private UserControlAuthors userControlAuthors;
        private System.Windows.Forms.TabPage tabPagePublishers;
        private UserControlPublishers userControlPublishers;
    }
}
