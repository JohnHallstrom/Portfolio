namespace CSharpLaborationFourWinFormsApplication
{
    partial class FormLoadList
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
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.listBoxLanguage = new System.Windows.Forms.ListBox();
            this.labelWordCount = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.buttonLoadList = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxWord = new System.Windows.Forms.ListBox();
            this.labelWords = new System.Windows.Forms.Label();
            this.buttonNewList = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.buttonDeleteList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxList
            // 
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.Location = new System.Drawing.Point(12, 38);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(220, 238);
            this.listBoxList.TabIndex = 0;
            this.listBoxList.SelectedIndexChanged += new System.EventHandler(this.listBoxLists_SelectedIndexChanged);
            this.listBoxList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxList_KeyDown);
            this.listBoxList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxList_MouseDoubleClick);
            // 
            // listBoxLanguage
            // 
            this.listBoxLanguage.FormattingEnabled = true;
            this.listBoxLanguage.Location = new System.Drawing.Point(252, 38);
            this.listBoxLanguage.Name = "listBoxLanguage";
            this.listBoxLanguage.Size = new System.Drawing.Size(220, 108);
            this.listBoxLanguage.TabIndex = 1;
            this.listBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.listBoxLanguages_SelectedIndexChanged);
            // 
            // labelWordCount
            // 
            this.labelWordCount.AutoSize = true;
            this.labelWordCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWordCount.Location = new System.Drawing.Point(154, 22);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(75, 13);
            this.labelWordCount.TabIndex = 2;
            this.labelWordCount.Text = "Word count: 0";
            this.labelWordCount.Visible = false;
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(249, 22);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(58, 13);
            this.labelLanguage.TabIndex = 3;
            this.labelLanguage.Text = "Language:";
            // 
            // buttonLoadList
            // 
            this.buttonLoadList.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLoadList.Enabled = false;
            this.buttonLoadList.Location = new System.Drawing.Point(397, 282);
            this.buttonLoadList.Name = "buttonLoadList";
            this.buttonLoadList.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadList.TabIndex = 4;
            this.buttonLoadList.Text = "&Load";
            this.buttonLoadList.UseVisualStyleBackColor = true;
            this.buttonLoadList.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(316, 282);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listBoxWord
            // 
            this.listBoxWord.FormattingEnabled = true;
            this.listBoxWord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxWord.Location = new System.Drawing.Point(252, 168);
            this.listBoxWord.Name = "listBoxWord";
            this.listBoxWord.Size = new System.Drawing.Size(220, 108);
            this.listBoxWord.TabIndex = 6;
            // 
            // labelWords
            // 
            this.labelWords.AutoSize = true;
            this.labelWords.Location = new System.Drawing.Point(249, 152);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(36, 13);
            this.labelWords.TabIndex = 7;
            this.labelWords.Text = "Word:";
            // 
            // buttonNewList
            // 
            this.buttonNewList.Location = new System.Drawing.Point(12, 282);
            this.buttonNewList.Name = "buttonNewList";
            this.buttonNewList.Size = new System.Drawing.Size(75, 23);
            this.buttonNewList.TabIndex = 8;
            this.buttonNewList.Text = "&New list";
            this.buttonNewList.UseVisualStyleBackColor = true;
            this.buttonNewList.Click += new System.EventHandler(this.buttonNewList_Click);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(10, 22);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(26, 13);
            this.labelList.TabIndex = 9;
            this.labelList.Text = "List:";
            // 
            // buttonDeleteList
            // 
            this.buttonDeleteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteList.Enabled = false;
            this.buttonDeleteList.Location = new System.Drawing.Point(157, 282);
            this.buttonDeleteList.Name = "buttonDeleteList";
            this.buttonDeleteList.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteList.TabIndex = 10;
            this.buttonDeleteList.Text = "&Delete list";
            this.buttonDeleteList.UseVisualStyleBackColor = true;
            this.buttonDeleteList.Click += new System.EventHandler(this.buttonDeleteList_Click);
            // 
            // FormLoadList
            // 
            this.AcceptButton = this.buttonLoadList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.buttonDeleteList);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.buttonNewList);
            this.Controls.Add(this.labelWords);
            this.Controls.Add(this.listBoxWord);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLoadList);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.labelWordCount);
            this.Controls.Add(this.listBoxLanguage);
            this.Controls.Add(this.listBoxList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "FormLoadList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load word list";
            this.Shown += new System.EventHandler(this.FormLoadList_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.ListBox listBoxLanguage;
        private System.Windows.Forms.Label labelWordCount;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Button buttonLoadList;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListBox listBoxWord;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.Button buttonNewList;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Button buttonDeleteList;
    }
}