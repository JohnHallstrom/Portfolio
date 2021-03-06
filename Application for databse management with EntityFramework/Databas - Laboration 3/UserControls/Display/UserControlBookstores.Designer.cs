
namespace DatabasLaboration3
{
    partial class UserControlBookstores
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
            this.dataGridViewBookstores = new System.Windows.Forms.DataGridView();
            this.panelBookstoreInfo = new System.Windows.Forms.Panel();
            this.labelBookstoreInfo = new System.Windows.Forms.Label();
            this.comboBoxBookstores = new System.Windows.Forms.ComboBox();
            this.panelIChosenBookstore = new System.Windows.Forms.Panel();
            this.labelChosenBookstore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookstores)).BeginInit();
            this.panelBookstoreInfo.SuspendLayout();
            this.panelIChosenBookstore.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBookstores
            // 
            this.dataGridViewBookstores.AllowUserToAddRows = false;
            this.dataGridViewBookstores.AllowUserToDeleteRows = false;
            this.dataGridViewBookstores.AllowUserToResizeRows = false;
            this.dataGridViewBookstores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookstores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBookstores.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBookstores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookstores.ColumnHeadersVisible = false;
            this.dataGridViewBookstores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBookstores.Location = new System.Drawing.Point(0, 73);
            this.dataGridViewBookstores.MultiSelect = false;
            this.dataGridViewBookstores.Name = "dataGridViewBookstores";
            this.dataGridViewBookstores.ReadOnly = true;
            this.dataGridViewBookstores.RowHeadersWidth = 120;
            this.dataGridViewBookstores.RowTemplate.Height = 25;
            this.dataGridViewBookstores.Size = new System.Drawing.Size(800, 427);
            this.dataGridViewBookstores.TabIndex = 1;
            // 
            // panelBookstoreInfo
            // 
            this.panelBookstoreInfo.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelBookstoreInfo.Controls.Add(this.labelBookstoreInfo);
            this.panelBookstoreInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookstoreInfo.Location = new System.Drawing.Point(0, 48);
            this.panelBookstoreInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelBookstoreInfo.Name = "panelBookstoreInfo";
            this.panelBookstoreInfo.Size = new System.Drawing.Size(800, 25);
            this.panelBookstoreInfo.TabIndex = 14;
            // 
            // labelBookstoreInfo
            // 
            this.labelBookstoreInfo.AutoSize = true;
            this.labelBookstoreInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelBookstoreInfo.Location = new System.Drawing.Point(5, 5);
            this.labelBookstoreInfo.Name = "labelBookstoreInfo";
            this.labelBookstoreInfo.Size = new System.Drawing.Size(73, 15);
            this.labelBookstoreInfo.TabIndex = 9;
            this.labelBookstoreInfo.Text = "Information:";
            // 
            // comboBoxBookstores
            // 
            this.comboBoxBookstores.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxBookstores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBookstores.FormattingEnabled = true;
            this.comboBoxBookstores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxBookstores.Location = new System.Drawing.Point(0, 25);
            this.comboBoxBookstores.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxBookstores.Name = "comboBoxBookstores";
            this.comboBoxBookstores.Size = new System.Drawing.Size(800, 23);
            this.comboBoxBookstores.TabIndex = 12;
            this.comboBoxBookstores.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookstores_SelectedIndexChanged);
            // 
            // panelIChosenBookstore
            // 
            this.panelIChosenBookstore.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelIChosenBookstore.Controls.Add(this.labelChosenBookstore);
            this.panelIChosenBookstore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIChosenBookstore.Location = new System.Drawing.Point(0, 0);
            this.panelIChosenBookstore.Margin = new System.Windows.Forms.Padding(0);
            this.panelIChosenBookstore.Name = "panelIChosenBookstore";
            this.panelIChosenBookstore.Size = new System.Drawing.Size(800, 25);
            this.panelIChosenBookstore.TabIndex = 13;
            // 
            // labelChosenBookstore
            // 
            this.labelChosenBookstore.AutoSize = true;
            this.labelChosenBookstore.ForeColor = System.Drawing.SystemColors.Window;
            this.labelChosenBookstore.Location = new System.Drawing.Point(5, 5);
            this.labelChosenBookstore.Name = "labelChosenBookstore";
            this.labelChosenBookstore.Size = new System.Drawing.Size(91, 15);
            this.labelChosenBookstore.TabIndex = 9;
            this.labelChosenBookstore.Text = "Vald bokhandel:";
            // 
            // UserControlBookstores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBookstores);
            this.Controls.Add(this.panelBookstoreInfo);
            this.Controls.Add(this.comboBoxBookstores);
            this.Controls.Add(this.panelIChosenBookstore);
            this.Name = "UserControlBookstores";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookstores)).EndInit();
            this.panelBookstoreInfo.ResumeLayout(false);
            this.panelBookstoreInfo.PerformLayout();
            this.panelIChosenBookstore.ResumeLayout(false);
            this.panelIChosenBookstore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBookstores;
        private System.Windows.Forms.Panel panelBookstoreInfo;
        private System.Windows.Forms.Label labelBookstoreInfo;
        private System.Windows.Forms.ComboBox comboBoxBookstores;
        private System.Windows.Forms.Panel panelIChosenBookstore;
        private System.Windows.Forms.Label labelChosenBookstore;
    }
}
