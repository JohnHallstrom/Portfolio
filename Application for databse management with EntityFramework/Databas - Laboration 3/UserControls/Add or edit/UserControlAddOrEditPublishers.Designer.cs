
namespace DatabasLaboration3
{
    partial class UserControlAddOrEditPublishers
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxPostcode = new System.Windows.Forms.TextBox();
            this.labelPostcode = new System.Windows.Forms.Label();
            this.textBoxContactPerson = new System.Windows.Forms.TextBox();
            this.labelContactPerson = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelName.Location = new System.Drawing.Point(29, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Namn";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxName.Location = new System.Drawing.Point(29, 28);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAdress.Location = new System.Drawing.Point(30, 73);
            this.textBoxAdress.MaxLength = 50;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(180, 23);
            this.textBoxAdress.TabIndex = 2;
            // 
            // labelAdress
            // 
            this.labelAdress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAdress.AutoSize = true;
            this.labelAdress.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAdress.Location = new System.Drawing.Point(30, 55);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(42, 15);
            this.labelAdress.TabIndex = 2;
            this.labelAdress.Text = "Adress";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCity.Location = new System.Drawing.Point(30, 117);
            this.textBoxCity.MaxLength = 85;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(180, 23);
            this.textBoxCity.TabIndex = 3;
            // 
            // labelCity
            // 
            this.labelCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCity.AutoSize = true;
            this.labelCity.ForeColor = System.Drawing.SystemColors.Window;
            this.labelCity.Location = new System.Drawing.Point(30, 99);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(30, 15);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "Stad";
            // 
            // textBoxPostcode
            // 
            this.textBoxPostcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPostcode.Location = new System.Drawing.Point(30, 161);
            this.textBoxPostcode.MaxLength = 5;
            this.textBoxPostcode.Name = "textBoxPostcode";
            this.textBoxPostcode.Size = new System.Drawing.Size(180, 23);
            this.textBoxPostcode.TabIndex = 4;
            this.textBoxPostcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPostcode_KeyPress);
            this.textBoxPostcode.Leave += new System.EventHandler(this.textBoxPostcode_Leave);
            // 
            // labelPostcode
            // 
            this.labelPostcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPostcode.AutoSize = true;
            this.labelPostcode.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPostcode.Location = new System.Drawing.Point(30, 143);
            this.labelPostcode.Name = "labelPostcode";
            this.labelPostcode.Size = new System.Drawing.Size(76, 15);
            this.labelPostcode.TabIndex = 4;
            this.labelPostcode.Text = "Postnummer";
            // 
            // textBoxContactPerson
            // 
            this.textBoxContactPerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxContactPerson.Location = new System.Drawing.Point(30, 205);
            this.textBoxContactPerson.MaxLength = 100;
            this.textBoxContactPerson.Name = "textBoxContactPerson";
            this.textBoxContactPerson.Size = new System.Drawing.Size(180, 23);
            this.textBoxContactPerson.TabIndex = 5;
            // 
            // labelContactPerson
            // 
            this.labelContactPerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelContactPerson.AutoSize = true;
            this.labelContactPerson.ForeColor = System.Drawing.SystemColors.Window;
            this.labelContactPerson.Location = new System.Drawing.Point(30, 187);
            this.labelContactPerson.Name = "labelContactPerson";
            this.labelContactPerson.Size = new System.Drawing.Size(84, 15);
            this.labelContactPerson.TabIndex = 10;
            this.labelContactPerson.Text = "Kontaktperson";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(30, 249);
            this.textBoxPhoneNumber.MaxLength = 15;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(180, 23);
            this.textBoxPhoneNumber.TabIndex = 6;
            this.textBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNumber_KeyPress);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPhoneNumber.Location = new System.Drawing.Point(30, 231);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(91, 15);
            this.labelPhoneNumber.TabIndex = 8;
            this.labelPhoneNumber.Text = "Telefonnummer";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOk.Location = new System.Drawing.Point(29, 298);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancel.Location = new System.Drawing.Point(135, 298);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Avbryt";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // UserControlAddOrEditPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxContactPerson);
            this.Controls.Add(this.labelContactPerson);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxPostcode);
            this.Controls.Add(this.labelPostcode);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "UserControlAddOrEditPublishers";
            this.Size = new System.Drawing.Size(241, 376);
            this.Load += new System.EventHandler(this.UserControlAddOrEditPublishers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxPostcode;
        private System.Windows.Forms.Label labelPostcode;
        private System.Windows.Forms.TextBox textBoxContactPerson;
        private System.Windows.Forms.Label labelContactPerson;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}
