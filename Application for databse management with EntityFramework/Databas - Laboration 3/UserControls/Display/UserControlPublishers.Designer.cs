
namespace DatabasLaboration3
{
    partial class UserControlPublishers
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
            this.dataGridViewPublishers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontaktperson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPublishers
            // 
            this.dataGridViewPublishers.AllowUserToAddRows = false;
            this.dataGridViewPublishers.AllowUserToDeleteRows = false;
            this.dataGridViewPublishers.AllowUserToResizeRows = false;
            this.dataGridViewPublishers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPublishers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPublishers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublishers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namn,
            this.Adress,
            this.Stad,
            this.Postnummer,
            this.Kontaktperson,
            this.Telefonnummer});
            this.dataGridViewPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPublishers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPublishers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPublishers.MultiSelect = false;
            this.dataGridViewPublishers.Name = "dataGridViewPublishers";
            this.dataGridViewPublishers.ReadOnly = true;
            this.dataGridViewPublishers.RowHeadersVisible = false;
            this.dataGridViewPublishers.RowTemplate.Height = 25;
            this.dataGridViewPublishers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPublishers.Size = new System.Drawing.Size(800, 500);
            this.dataGridViewPublishers.TabIndex = 3;
            this.dataGridViewPublishers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewPublishers_RowsAdded);
            this.dataGridViewPublishers.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewPublishers_RowsRemoved);
            this.dataGridViewPublishers.SelectionChanged += new System.EventHandler(this.dataGridViewPublishers_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Namn
            // 
            this.Namn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Namn.FillWeight = 150F;
            this.Namn.HeaderText = "Namn";
            this.Namn.MinimumWidth = 50;
            this.Namn.Name = "Namn";
            this.Namn.ReadOnly = true;
            // 
            // Adress
            // 
            this.Adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adress.FillWeight = 90.05823F;
            this.Adress.HeaderText = "Adress";
            this.Adress.MinimumWidth = 50;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            // 
            // Stad
            // 
            this.Stad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stad.FillWeight = 90.05823F;
            this.Stad.HeaderText = "Stad";
            this.Stad.MinimumWidth = 50;
            this.Stad.Name = "Stad";
            this.Stad.ReadOnly = true;
            // 
            // Postnummer
            // 
            this.Postnummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Postnummer.FillWeight = 90.05823F;
            this.Postnummer.HeaderText = "Postnummer";
            this.Postnummer.MinimumWidth = 50;
            this.Postnummer.Name = "Postnummer";
            this.Postnummer.ReadOnly = true;
            // 
            // Kontaktperson
            // 
            this.Kontaktperson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kontaktperson.FillWeight = 90.05823F;
            this.Kontaktperson.HeaderText = "Kontaktperson";
            this.Kontaktperson.MinimumWidth = 50;
            this.Kontaktperson.Name = "Kontaktperson";
            this.Kontaktperson.ReadOnly = true;
            // 
            // Telefonnummer
            // 
            this.Telefonnummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefonnummer.FillWeight = 90.05823F;
            this.Telefonnummer.HeaderText = "Telefonnummer";
            this.Telefonnummer.MinimumWidth = 50;
            this.Telefonnummer.Name = "Telefonnummer";
            this.Telefonnummer.ReadOnly = true;
            // 
            // UserControlPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewPublishers);
            this.Name = "UserControlPublishers";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPublishers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontaktperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonnummer;
    }
}
