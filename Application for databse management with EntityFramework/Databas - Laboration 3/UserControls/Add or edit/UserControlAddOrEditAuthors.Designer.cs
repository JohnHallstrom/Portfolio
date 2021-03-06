
namespace DatabasLaboration3
{
    partial class UserControlAddOrEditAuthors
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
            this.labelFirstname = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstname
            // 
            this.labelFirstname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.ForeColor = System.Drawing.SystemColors.Window;
            this.labelFirstname.Location = new System.Drawing.Point(29, 10);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(55, 15);
            this.labelFirstname.TabIndex = 0;
            this.labelFirstname.Text = "Förnamn";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFirstname.Location = new System.Drawing.Point(29, 28);
            this.textBoxFirstname.MaxLength = 50;
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(180, 23);
            this.textBoxFirstname.TabIndex = 1;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLastname.Location = new System.Drawing.Point(29, 72);
            this.textBoxLastname.MaxLength = 50;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(180, 23);
            this.textBoxLastname.TabIndex = 2;
            // 
            // labelLastname
            // 
            this.labelLastname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLastname.AutoSize = true;
            this.labelLastname.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLastname.Location = new System.Drawing.Point(29, 54);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(62, 15);
            this.labelLastname.TabIndex = 2;
            this.labelLastname.Text = "Efternamn";
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.ForeColor = System.Drawing.SystemColors.Window;
            this.labelBirthdate.Location = new System.Drawing.Point(29, 98);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(82, 15);
            this.labelBirthdate.TabIndex = 4;
            this.labelBirthdate.Text = "Födelsedatum";
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(29, 116);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(180, 23);
            this.dateTimePickerBirthdate.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOk.Location = new System.Drawing.Point(29, 165);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancel.Location = new System.Drawing.Point(134, 165);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Avbryt";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // UserControlAddOrEditAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dateTimePickerBirthdate);
            this.Controls.Add(this.labelBirthdate);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.labelFirstname);
            this.Name = "UserControlAddOrEditAuthors";
            this.Size = new System.Drawing.Size(238, 242);
            this.Load += new System.EventHandler(this.UserControlAddOrEditAuthors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}
