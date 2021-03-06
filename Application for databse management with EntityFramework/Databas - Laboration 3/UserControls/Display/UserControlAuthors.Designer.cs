
namespace DatabasLaboration3
{
    partial class UserControlAuthors
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
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Förnamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efternamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Födelsedatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.AllowUserToAddRows = false;
            this.dataGridViewAuthors.AllowUserToDeleteRows = false;
            this.dataGridViewAuthors.AllowUserToResizeRows = false;
            this.dataGridViewAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAuthors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAuthors.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Förnamn,
            this.Efternamn,
            this.Födelsedatum});
            this.dataGridViewAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAuthors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAuthors.MultiSelect = false;
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.ReadOnly = true;
            this.dataGridViewAuthors.RowHeadersVisible = false;
            this.dataGridViewAuthors.RowTemplate.Height = 25;
            this.dataGridViewAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(800, 500);
            this.dataGridViewAuthors.TabIndex = 2;
            this.dataGridViewAuthors.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewAuthors_RowsAdded);
            this.dataGridViewAuthors.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewAuthors_RowsRemoved);
            this.dataGridViewAuthors.SelectionChanged += new System.EventHandler(this.dataGridViewAuthors_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Förnamn
            // 
            this.Förnamn.HeaderText = "Förnamn";
            this.Förnamn.MinimumWidth = 50;
            this.Förnamn.Name = "Förnamn";
            this.Förnamn.ReadOnly = true;
            // 
            // Efternamn
            // 
            this.Efternamn.HeaderText = "Efternamn";
            this.Efternamn.MinimumWidth = 50;
            this.Efternamn.Name = "Efternamn";
            this.Efternamn.ReadOnly = true;
            // 
            // Födelsedatum
            // 
            this.Födelsedatum.HeaderText = "Födelsedatum";
            this.Födelsedatum.MinimumWidth = 50;
            this.Födelsedatum.Name = "Födelsedatum";
            this.Födelsedatum.ReadOnly = true;
            // 
            // UserControlAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAuthors);
            this.Name = "UserControlAuthors";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Förnamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efternamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Födelsedatum;
    }
}
