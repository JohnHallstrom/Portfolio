namespace CSharpLaborationFourWinFormsApplication
{
    partial class FormNewList
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
            this.textBoxListName = new System.Windows.Forms.TextBox();
            this.labelListName = new System.Windows.Forms.Label();
            this.labelLanguages = new System.Windows.Forms.Label();
            this.textBoxListLanguages = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelListNameInvalidInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxListName
            // 
            this.textBoxListName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxListName.Location = new System.Drawing.Point(15, 28);
            this.textBoxListName.Name = "textBoxListName";
            this.textBoxListName.Size = new System.Drawing.Size(227, 20);
            this.textBoxListName.TabIndex = 0;
            this.textBoxListName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxListName_KeyPress);
            // 
            // labelListName
            // 
            this.labelListName.AutoSize = true;
            this.labelListName.Location = new System.Drawing.Point(12, 12);
            this.labelListName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelListName.Name = "labelListName";
            this.labelListName.Size = new System.Drawing.Size(55, 13);
            this.labelListName.TabIndex = 1;
            this.labelListName.Text = "List name:";
            // 
            // labelLanguages
            // 
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Location = new System.Drawing.Point(12, 54);
            this.labelLanguages.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(63, 13);
            this.labelLanguages.TabIndex = 2;
            this.labelLanguages.Text = "Languages:";
            // 
            // textBoxListLanguages
            // 
            this.textBoxListLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxListLanguages.Location = new System.Drawing.Point(15, 70);
            this.textBoxListLanguages.Multiline = true;
            this.textBoxListLanguages.Name = "textBoxListLanguages";
            this.textBoxListLanguages.Size = new System.Drawing.Size(227, 140);
            this.textBoxListLanguages.TabIndex = 3;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Location = new System.Drawing.Point(167, 216);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "&Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(86, 216);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelListNameInvalidInput
            // 
            this.labelListNameInvalidInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelListNameInvalidInput.AutoSize = true;
            this.labelListNameInvalidInput.Location = new System.Drawing.Point(79, 12);
            this.labelListNameInvalidInput.Name = "labelListNameInvalidInput";
            this.labelListNameInvalidInput.Size = new System.Drawing.Size(163, 13);
            this.labelListNameInvalidInput.TabIndex = 6;
            this.labelListNameInvalidInput.Text = "Invalid characters: \\ / : * ? \" < > |";
            this.labelListNameInvalidInput.Visible = false;
            // 
            // FormNewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(254, 251);
            this.Controls.Add(this.labelListNameInvalidInput);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxListLanguages);
            this.Controls.Add(this.labelLanguages);
            this.Controls.Add(this.labelListName);
            this.Controls.Add(this.textBoxListName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 290);
            this.Name = "FormNewList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxListName;
        private System.Windows.Forms.Label labelListName;
        private System.Windows.Forms.Label labelLanguages;
        private System.Windows.Forms.TextBox textBoxListLanguages;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelListNameInvalidInput;
    }
}