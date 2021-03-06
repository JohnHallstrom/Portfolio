
namespace DatabasLaboration3
{
    partial class UserControlBooks
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Språk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utgivningsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Författare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Förlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Titel,
            this.Språk,
            this.Pris,
            this.Utgivningsdatum,
            this.Författare,
            this.Förlag});
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersVisible = false;
            this.dataGridViewBooks.RowTemplate.Height = 25;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(800, 500);
            this.dataGridViewBooks.TabIndex = 1;
            this.dataGridViewBooks.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewBooks_RowsAdded);
            this.dataGridViewBooks.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewBooks_RowsRemoved);
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ISBN.FillWeight = 69.51871F;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MaxInputLength = 13;
            this.ISBN.MinimumWidth = 50;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Titel
            // 
            this.Titel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titel.FillWeight = 115.2406F;
            this.Titel.HeaderText = "Titel";
            this.Titel.MaxInputLength = 100;
            this.Titel.MinimumWidth = 50;
            this.Titel.Name = "Titel";
            this.Titel.ReadOnly = true;
            // 
            // Språk
            // 
            this.Språk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Språk.HeaderText = "Språk";
            this.Språk.MinimumWidth = 50;
            this.Språk.Name = "Språk";
            this.Språk.ReadOnly = true;
            // 
            // Pris
            // 
            this.Pris.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pris.HeaderText = "Pris (SEK)";
            this.Pris.MinimumWidth = 50;
            this.Pris.Name = "Pris";
            this.Pris.ReadOnly = true;
            // 
            // Utgivningsdatum
            // 
            this.Utgivningsdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Utgivningsdatum.HeaderText = "Utgivningsdatum";
            this.Utgivningsdatum.MinimumWidth = 50;
            this.Utgivningsdatum.Name = "Utgivningsdatum";
            this.Utgivningsdatum.ReadOnly = true;
            // 
            // Författare
            // 
            this.Författare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Författare.HeaderText = "Författare";
            this.Författare.MinimumWidth = 50;
            this.Författare.Name = "Författare";
            this.Författare.ReadOnly = true;
            // 
            // Förlag
            // 
            this.Förlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Förlag.FillWeight = 115.2406F;
            this.Förlag.HeaderText = "Förlag";
            this.Förlag.MinimumWidth = 50;
            this.Förlag.Name = "Förlag";
            this.Förlag.ReadOnly = true;
            this.Förlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UserControlBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBooks);
            this.Name = "UserControlBooks";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Språk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utgivningsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Författare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Förlag;
    }
}
