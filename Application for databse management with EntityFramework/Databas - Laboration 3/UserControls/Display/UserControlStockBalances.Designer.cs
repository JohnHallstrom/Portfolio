
namespace DatabasLaboration3
{
    partial class UserControlStockBalances
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
            this.dataGridViewStockBalances = new System.Windows.Forms.DataGridView();
            this.ButikerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelStockBalanceButtons = new System.Windows.Forms.Panel();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonEditBalance = new System.Windows.Forms.Button();
            this.buttonStockBalanceRemove = new System.Windows.Forms.Button();
            this.buttonStockBalanceAddBook = new System.Windows.Forms.Button();
            this.buttonStockBalanceEditBalance = new System.Windows.Forms.Button();
            this.panelEditStockBalance = new System.Windows.Forms.Panel();
            this.labelEditStockBalanceTitle = new System.Windows.Forms.Label();
            this.buttonStockBalanceEditConfirm = new System.Windows.Forms.Button();
            this.numericUpDownStockBalance = new System.Windows.Forms.NumericUpDown();
            this.labelStockBalance = new System.Windows.Forms.Label();
            this.panelStockBalanceInfo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockBalances)).BeginInit();
            this.panelStockBalanceButtons.SuspendLayout();
            this.panelEditStockBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockBalance)).BeginInit();
            this.panelStockBalanceInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStockBalances
            // 
            this.dataGridViewStockBalances.AllowUserToAddRows = false;
            this.dataGridViewStockBalances.AllowUserToDeleteRows = false;
            this.dataGridViewStockBalances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStockBalances.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStockBalances.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewStockBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockBalances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ButikerID,
            this.ISBN,
            this.Titel,
            this.Antal});
            this.dataGridViewStockBalances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStockBalances.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewStockBalances.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewStockBalances.MultiSelect = false;
            this.dataGridViewStockBalances.Name = "dataGridViewStockBalances";
            this.dataGridViewStockBalances.ReadOnly = true;
            this.dataGridViewStockBalances.RowHeadersVisible = false;
            this.dataGridViewStockBalances.RowTemplate.Height = 25;
            this.dataGridViewStockBalances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStockBalances.Size = new System.Drawing.Size(800, 445);
            this.dataGridViewStockBalances.TabIndex = 1;
            this.dataGridViewStockBalances.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewStockBalances_RowsAdded);
            this.dataGridViewStockBalances.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewStockBalances_RowsRemoved);
            this.dataGridViewStockBalances.SelectionChanged += new System.EventHandler(this.dataGridViewStockBalances_SelectionChanged);
            // 
            // ButikerID
            // 
            this.ButikerID.HeaderText = "ButikerID";
            this.ButikerID.MinimumWidth = 50;
            this.ButikerID.Name = "ButikerID";
            this.ButikerID.ReadOnly = true;
            this.ButikerID.Visible = false;
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ISBN.FillWeight = 95F;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 50;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Titel
            // 
            this.Titel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titel.FillWeight = 153.9823F;
            this.Titel.HeaderText = "Titel";
            this.Titel.MinimumWidth = 50;
            this.Titel.Name = "Titel";
            this.Titel.ReadOnly = true;
            // 
            // Antal
            // 
            this.Antal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Antal.FillWeight = 53.77509F;
            this.Antal.HeaderText = "Antal";
            this.Antal.MinimumWidth = 50;
            this.Antal.Name = "Antal";
            this.Antal.ReadOnly = true;
            // 
            // panelStockBalanceButtons
            // 
            this.panelStockBalanceButtons.Controls.Add(this.buttonRemoveBook);
            this.panelStockBalanceButtons.Controls.Add(this.buttonAddBook);
            this.panelStockBalanceButtons.Controls.Add(this.buttonEditBalance);
            this.panelStockBalanceButtons.Controls.Add(this.buttonStockBalanceRemove);
            this.panelStockBalanceButtons.Controls.Add(this.buttonStockBalanceAddBook);
            this.panelStockBalanceButtons.Controls.Add(this.buttonStockBalanceEditBalance);
            this.panelStockBalanceButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStockBalanceButtons.Location = new System.Drawing.Point(0, 470);
            this.panelStockBalanceButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelStockBalanceButtons.Name = "panelStockBalanceButtons";
            this.panelStockBalanceButtons.Size = new System.Drawing.Size(800, 30);
            this.panelStockBalanceButtons.TabIndex = 3;
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveBook.Enabled = false;
            this.buttonRemoveBook.Location = new System.Drawing.Point(2, 2);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(93, 23);
            this.buttonRemoveBook.TabIndex = 8;
            this.buttonRemoveBook.Text = "Ta bort bok";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBook.Enabled = false;
            this.buttonAddBook.Location = new System.Drawing.Point(618, 2);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(83, 23);
            this.buttonAddBook.TabIndex = 7;
            this.buttonAddBook.Text = "Lägg till bok";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonEditBalance
            // 
            this.buttonEditBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditBalance.Enabled = false;
            this.buttonEditBalance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonEditBalance.Location = new System.Drawing.Point(707, 2);
            this.buttonEditBalance.Name = "buttonEditBalance";
            this.buttonEditBalance.Size = new System.Drawing.Size(91, 23);
            this.buttonEditBalance.TabIndex = 6;
            this.buttonEditBalance.Text = "Ändra saldo";
            this.buttonEditBalance.UseVisualStyleBackColor = true;
            this.buttonEditBalance.Click += new System.EventHandler(this.buttonEditBalance_Click);
            // 
            // buttonStockBalanceRemove
            // 
            this.buttonStockBalanceRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStockBalanceRemove.Enabled = false;
            this.buttonStockBalanceRemove.Location = new System.Drawing.Point(3, -67);
            this.buttonStockBalanceRemove.Name = "buttonStockBalanceRemove";
            this.buttonStockBalanceRemove.Size = new System.Drawing.Size(93, 23);
            this.buttonStockBalanceRemove.TabIndex = 5;
            this.buttonStockBalanceRemove.Text = "Ta bort bok";
            this.buttonStockBalanceRemove.UseVisualStyleBackColor = true;
            // 
            // buttonStockBalanceAddBook
            // 
            this.buttonStockBalanceAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStockBalanceAddBook.Location = new System.Drawing.Point(854, -67);
            this.buttonStockBalanceAddBook.Name = "buttonStockBalanceAddBook";
            this.buttonStockBalanceAddBook.Size = new System.Drawing.Size(83, 23);
            this.buttonStockBalanceAddBook.TabIndex = 4;
            this.buttonStockBalanceAddBook.Text = "Lägg till bok";
            this.buttonStockBalanceAddBook.UseVisualStyleBackColor = true;
            // 
            // buttonStockBalanceEditBalance
            // 
            this.buttonStockBalanceEditBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStockBalanceEditBalance.Location = new System.Drawing.Point(943, -67);
            this.buttonStockBalanceEditBalance.Name = "buttonStockBalanceEditBalance";
            this.buttonStockBalanceEditBalance.Size = new System.Drawing.Size(91, 23);
            this.buttonStockBalanceEditBalance.TabIndex = 3;
            this.buttonStockBalanceEditBalance.Text = "Ändra saldo";
            this.buttonStockBalanceEditBalance.UseVisualStyleBackColor = true;
            // 
            // panelEditStockBalance
            // 
            this.panelEditStockBalance.Controls.Add(this.labelEditStockBalanceTitle);
            this.panelEditStockBalance.Controls.Add(this.buttonStockBalanceEditConfirm);
            this.panelEditStockBalance.Controls.Add(this.numericUpDownStockBalance);
            this.panelEditStockBalance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEditStockBalance.Location = new System.Drawing.Point(0, 370);
            this.panelEditStockBalance.Margin = new System.Windows.Forms.Padding(0);
            this.panelEditStockBalance.Name = "panelEditStockBalance";
            this.panelEditStockBalance.Size = new System.Drawing.Size(800, 100);
            this.panelEditStockBalance.TabIndex = 4;
            this.panelEditStockBalance.Visible = false;
            // 
            // labelEditStockBalanceTitle
            // 
            this.labelEditStockBalanceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEditStockBalanceTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.labelEditStockBalanceTitle.Location = new System.Drawing.Point(0, 0);
            this.labelEditStockBalanceTitle.Name = "labelEditStockBalanceTitle";
            this.labelEditStockBalanceTitle.Size = new System.Drawing.Size(800, 50);
            this.labelEditStockBalanceTitle.TabIndex = 2;
            this.labelEditStockBalanceTitle.Text = "labelEditStockBalanceTitle";
            this.labelEditStockBalanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStockBalanceEditConfirm
            // 
            this.buttonStockBalanceEditConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonStockBalanceEditConfirm.Location = new System.Drawing.Point(431, 53);
            this.buttonStockBalanceEditConfirm.Name = "buttonStockBalanceEditConfirm";
            this.buttonStockBalanceEditConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonStockBalanceEditConfirm.TabIndex = 1;
            this.buttonStockBalanceEditConfirm.Text = "Bekräfta";
            this.buttonStockBalanceEditConfirm.UseVisualStyleBackColor = true;
            this.buttonStockBalanceEditConfirm.Click += new System.EventHandler(this.buttonStockBalanceEditConfirm_Click);
            // 
            // numericUpDownStockBalance
            // 
            this.numericUpDownStockBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownStockBalance.Location = new System.Drawing.Point(305, 53);
            this.numericUpDownStockBalance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStockBalance.Name = "numericUpDownStockBalance";
            this.numericUpDownStockBalance.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownStockBalance.TabIndex = 0;
            this.numericUpDownStockBalance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelStockBalance
            // 
            this.labelStockBalance.AutoSize = true;
            this.labelStockBalance.ForeColor = System.Drawing.SystemColors.Window;
            this.labelStockBalance.Location = new System.Drawing.Point(5, 5);
            this.labelStockBalance.Name = "labelStockBalance";
            this.labelStockBalance.Size = new System.Drawing.Size(67, 15);
            this.labelStockBalance.TabIndex = 9;
            this.labelStockBalance.Text = "Lagersaldo:";
            // 
            // panelStockBalanceInfo
            // 
            this.panelStockBalanceInfo.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelStockBalanceInfo.Controls.Add(this.labelStockBalance);
            this.panelStockBalanceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStockBalanceInfo.Location = new System.Drawing.Point(0, 0);
            this.panelStockBalanceInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelStockBalanceInfo.Name = "panelStockBalanceInfo";
            this.panelStockBalanceInfo.Size = new System.Drawing.Size(800, 25);
            this.panelStockBalanceInfo.TabIndex = 5;
            // 
            // UserControlStockBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.panelEditStockBalance);
            this.Controls.Add(this.dataGridViewStockBalances);
            this.Controls.Add(this.panelStockBalanceInfo);
            this.Controls.Add(this.panelStockBalanceButtons);
            this.Name = "UserControlStockBalances";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.UserControlStockBalances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockBalances)).EndInit();
            this.panelStockBalanceButtons.ResumeLayout(false);
            this.panelEditStockBalance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockBalance)).EndInit();
            this.panelStockBalanceInfo.ResumeLayout(false);
            this.panelStockBalanceInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStockBalances;
        private System.Windows.Forms.Panel panelStockBalanceButtons;
        private System.Windows.Forms.Button buttonStockBalanceRemove;
        private System.Windows.Forms.Button buttonStockBalanceAddBook;
        private System.Windows.Forms.Button buttonStockBalanceEditBalance;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonEditBalance;
        private System.Windows.Forms.Panel panelEditStockBalance;
        private System.Windows.Forms.Label labelEditStockBalanceTitle;
        private System.Windows.Forms.Button buttonStockBalanceEditConfirm;
        private System.Windows.Forms.NumericUpDown numericUpDownStockBalance;
        private System.Windows.Forms.Label labelStockBalance;
        private System.Windows.Forms.Panel panelStockBalanceInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ButikerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antal;
    }
}
