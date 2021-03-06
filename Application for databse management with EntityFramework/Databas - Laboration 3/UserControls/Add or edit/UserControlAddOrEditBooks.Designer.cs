
namespace DatabasLaboration3
{
    partial class UserControlAddOrEditBooks
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
            this.labelISBN = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.comboBoxPublishers = new System.Windows.Forms.ComboBox();
            this.labelPublishingDate = new System.Windows.Forms.Label();
            this.dateTimePickerPublishingDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.listBoxAuthors = new System.Windows.Forms.ListBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonRemoveAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelISBN
            // 
            this.labelISBN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelISBN.AutoSize = true;
            this.labelISBN.ForeColor = System.Drawing.SystemColors.Window;
            this.labelISBN.Location = new System.Drawing.Point(23, 10);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 15);
            this.labelISBN.TabIndex = 0;
            this.labelISBN.Text = "ISBN";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxISBN.Location = new System.Drawing.Point(23, 28);
            this.textBoxISBN.MaxLength = 13;
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(180, 23);
            this.textBoxISBN.TabIndex = 1;
            this.textBoxISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxISBN_KeyPress);
            this.textBoxISBN.Leave += new System.EventHandler(this.textBoxISBN_Leave);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTitle.Location = new System.Drawing.Point(23, 72);
            this.textBoxTitle.MaxLength = 100;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(180, 23);
            this.textBoxTitle.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTitle.Location = new System.Drawing.Point(23, 54);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(29, 15);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Titel";
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLanguage.Location = new System.Drawing.Point(23, 116);
            this.textBoxLanguage.MaxLength = 20;
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(180, 23);
            this.textBoxLanguage.TabIndex = 3;
            // 
            // labelLanguage
            // 
            this.labelLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLanguage.Location = new System.Drawing.Point(23, 98);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(36, 15);
            this.labelLanguage.TabIndex = 4;
            this.labelLanguage.Text = "Språk";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPrice.Location = new System.Drawing.Point(23, 160);
            this.textBoxPrice.MaxLength = 1000000;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(180, 23);
            this.textBoxPrice.TabIndex = 4;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPrice.AutoSize = true;
            this.labelPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPrice.Location = new System.Drawing.Point(23, 142);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(56, 15);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Pris (SEK)";
            // 
            // labelPublisher
            // 
            this.labelPublisher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPublisher.Location = new System.Drawing.Point(23, 300);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(40, 15);
            this.labelPublisher.TabIndex = 8;
            this.labelPublisher.Text = "Förlag";
            // 
            // comboBoxPublishers
            // 
            this.comboBoxPublishers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxPublishers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublishers.FormattingEnabled = true;
            this.comboBoxPublishers.Location = new System.Drawing.Point(23, 318);
            this.comboBoxPublishers.Name = "comboBoxPublishers";
            this.comboBoxPublishers.Size = new System.Drawing.Size(180, 23);
            this.comboBoxPublishers.TabIndex = 8;
            // 
            // labelPublishingDate
            // 
            this.labelPublishingDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPublishingDate.AutoSize = true;
            this.labelPublishingDate.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPublishingDate.Location = new System.Drawing.Point(23, 344);
            this.labelPublishingDate.Name = "labelPublishingDate";
            this.labelPublishingDate.Size = new System.Drawing.Size(99, 15);
            this.labelPublishingDate.TabIndex = 10;
            this.labelPublishingDate.Text = "Utgivningsdatum";
            // 
            // dateTimePickerPublishingDate
            // 
            this.dateTimePickerPublishingDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerPublishingDate.Location = new System.Drawing.Point(23, 362);
            this.dateTimePickerPublishingDate.Name = "dateTimePickerPublishingDate";
            this.dateTimePickerPublishingDate.Size = new System.Drawing.Size(180, 23);
            this.dateTimePickerPublishingDate.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.Location = new System.Drawing.Point(23, 411);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Lägg till";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(128, 411);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Avbryt";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(23, 204);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(180, 23);
            this.comboBoxAuthors.TabIndex = 5;
            this.comboBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthors_SelectedIndexChanged);
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAuthor.Location = new System.Drawing.Point(23, 186);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(58, 15);
            this.labelAuthor.TabIndex = 14;
            this.labelAuthor.Text = "Författare";
            // 
            // listBoxAuthors
            // 
            this.listBoxAuthors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxAuthors.FormattingEnabled = true;
            this.listBoxAuthors.ItemHeight = 15;
            this.listBoxAuthors.Location = new System.Drawing.Point(23, 233);
            this.listBoxAuthors.Name = "listBoxAuthors";
            this.listBoxAuthors.Size = new System.Drawing.Size(180, 64);
            this.listBoxAuthors.TabIndex = 7;
            this.listBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.listBoxAuthors_SelectedIndexChanged);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddAuthor.Enabled = false;
            this.buttonAddAuthor.Location = new System.Drawing.Point(209, 204);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAuthor.TabIndex = 6;
            this.buttonAddAuthor.Text = "Lägg till";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonRemoveAuthor
            // 
            this.buttonRemoveAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRemoveAuthor.Enabled = false;
            this.buttonRemoveAuthor.Location = new System.Drawing.Point(209, 233);
            this.buttonRemoveAuthor.Name = "buttonRemoveAuthor";
            this.buttonRemoveAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAuthor.TabIndex = 7;
            this.buttonRemoveAuthor.Text = "Ta bort";
            this.buttonRemoveAuthor.UseVisualStyleBackColor = true;
            this.buttonRemoveAuthor.Click += new System.EventHandler(this.buttonRemoveAuthor_Click);
            // 
            // UserControlAddOrEditBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.buttonRemoveAuthor);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.listBoxAuthors);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickerPublishingDate);
            this.Controls.Add(this.labelPublishingDate);
            this.Controls.Add(this.comboBoxPublishers);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxLanguage);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.labelISBN);
            this.Name = "UserControlAddOrEditBooks";
            this.Size = new System.Drawing.Size(307, 488);
            this.Load += new System.EventHandler(this.UserControlAddBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.ComboBox comboBoxPublishers;
        private System.Windows.Forms.Label labelPublishingDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPublishingDate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.ListBox listBoxAuthors;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonRemoveAuthor;
    }
}
