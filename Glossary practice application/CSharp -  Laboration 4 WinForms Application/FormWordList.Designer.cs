namespace CSharpLaborationFourWinFormsApplication
{
    partial class FormWordList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWordList));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCurrentWordList = new System.Windows.Forms.Label();
            this.buttonAddWord = new System.Windows.Forms.Button();
            this.buttonRemoveWord = new System.Windows.Forms.Button();
            this.buttonPracticeMode = new System.Windows.Forms.Button();
            this.panelEditMode = new System.Windows.Forms.Panel();
            this.dataGridViewEdit = new System.Windows.Forms.DataGridView();
            this.panelPracticeMode = new System.Windows.Forms.Panel();
            this.buttonPracticeDone = new System.Windows.Forms.Button();
            this.panelPracticeControls = new System.Windows.Forms.Panel();
            this.textBoxPractice = new System.Windows.Forms.TextBox();
            this.buttonPracticeConfirm = new System.Windows.Forms.Button();
            this.labelPracticeText = new System.Windows.Forms.Label();
            this.buttonPracticeRestart = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panelEditMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).BeginInit();
            this.panelPracticeMode.SuspendLayout();
            this.panelPracticeControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuToolStripMenuItem,
            this.editMenuToolStripMenuItem,
            this.viewMenuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuToolStripMenuItem
            // 
            this.fileMenuToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileMenuToolStripMenuItem.Name = "fileMenuToolStripMenuItem";
            this.fileMenuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New list";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open list";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editMenuToolStripMenuItem
            // 
            this.editMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWordToolStripMenuItem,
            this.removeWordToolStripMenuItem});
            this.editMenuToolStripMenuItem.Name = "editMenuToolStripMenuItem";
            this.editMenuToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuToolStripMenuItem.Text = "&Edit";
            // 
            // addWordToolStripMenuItem
            // 
            this.addWordToolStripMenuItem.Enabled = false;
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addWordToolStripMenuItem.Text = "&Add word";
            this.addWordToolStripMenuItem.Click += new System.EventHandler(this.addWordToolStripMenuItem_Click);
            // 
            // removeWordToolStripMenuItem
            // 
            this.removeWordToolStripMenuItem.Enabled = false;
            this.removeWordToolStripMenuItem.Name = "removeWordToolStripMenuItem";
            this.removeWordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.removeWordToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.removeWordToolStripMenuItem.Text = "&Remove word";
            this.removeWordToolStripMenuItem.Click += new System.EventHandler(this.removeWordToolStripMenuItem_Click);
            // 
            // viewMenuToolStripMenuItem
            // 
            this.viewMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.practiceToolStripMenuItem});
            this.viewMenuToolStripMenuItem.Name = "viewMenuToolStripMenuItem";
            this.viewMenuToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewMenuToolStripMenuItem.Text = "&View";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editToolStripMenuItem.Text = "&Edit Mode";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.Enabled = false;
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.practiceToolStripMenuItem.Text = "&Practice Mode";
            this.practiceToolStripMenuItem.Click += new System.EventHandler(this.practiceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introductionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // introductionToolStripMenuItem
            // 
            this.introductionToolStripMenuItem.Name = "introductionToolStripMenuItem";
            this.introductionToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.introductionToolStripMenuItem.Text = "Introduction";
            this.introductionToolStripMenuItem.Click += new System.EventHandler(this.introductionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelCurrentWordList
            // 
            this.labelCurrentWordList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCurrentWordList.AutoSize = true;
            this.labelCurrentWordList.Location = new System.Drawing.Point(12, 431);
            this.labelCurrentWordList.Name = "labelCurrentWordList";
            this.labelCurrentWordList.Size = new System.Drawing.Size(114, 13);
            this.labelCurrentWordList.TabIndex = 5;
            this.labelCurrentWordList.Text = "Current word list: None";
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddWord.Enabled = false;
            this.buttonAddWord.Location = new System.Drawing.Point(535, 426);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.Size = new System.Drawing.Size(75, 23);
            this.buttonAddWord.TabIndex = 1;
            this.buttonAddWord.Text = "&Add word";
            this.buttonAddWord.UseVisualStyleBackColor = true;
            this.buttonAddWord.Click += new System.EventHandler(this.buttonAddWord_Click);
            // 
            // buttonRemoveWord
            // 
            this.buttonRemoveWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveWord.Enabled = false;
            this.buttonRemoveWord.Location = new System.Drawing.Point(616, 426);
            this.buttonRemoveWord.Name = "buttonRemoveWord";
            this.buttonRemoveWord.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveWord.TabIndex = 2;
            this.buttonRemoveWord.Text = "&Remove word";
            this.buttonRemoveWord.UseVisualStyleBackColor = true;
            this.buttonRemoveWord.Click += new System.EventHandler(this.buttonRemoveWord_Click);
            // 
            // buttonPracticeMode
            // 
            this.buttonPracticeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPracticeMode.Enabled = false;
            this.buttonPracticeMode.Location = new System.Drawing.Point(697, 426);
            this.buttonPracticeMode.Name = "buttonPracticeMode";
            this.buttonPracticeMode.Size = new System.Drawing.Size(75, 23);
            this.buttonPracticeMode.TabIndex = 3;
            this.buttonPracticeMode.Text = "&Practice";
            this.buttonPracticeMode.UseVisualStyleBackColor = true;
            this.buttonPracticeMode.Click += new System.EventHandler(this.buttonPractice_Click);
            // 
            // panelEditMode
            // 
            this.panelEditMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditMode.Controls.Add(this.dataGridViewEdit);
            this.panelEditMode.Location = new System.Drawing.Point(12, 27);
            this.panelEditMode.Name = "panelEditMode";
            this.panelEditMode.Size = new System.Drawing.Size(760, 393);
            this.panelEditMode.TabIndex = 7;
            // 
            // dataGridViewEdit
            // 
            this.dataGridViewEdit.AllowUserToAddRows = false;
            this.dataGridViewEdit.AllowUserToDeleteRows = false;
            this.dataGridViewEdit.AllowUserToOrderColumns = true;
            this.dataGridViewEdit.AllowUserToResizeRows = false;
            this.dataGridViewEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEdit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEdit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEdit.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEdit.Name = "dataGridViewEdit";
            this.dataGridViewEdit.RowHeadersVisible = false;
            this.dataGridViewEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEdit.Size = new System.Drawing.Size(760, 393);
            this.dataGridViewEdit.TabIndex = 0;
            // 
            // panelPracticeMode
            // 
            this.panelPracticeMode.Controls.Add(this.buttonPracticeDone);
            this.panelPracticeMode.Controls.Add(this.panelPracticeControls);
            this.panelPracticeMode.Controls.Add(this.labelPracticeText);
            this.panelPracticeMode.Controls.Add(this.buttonPracticeRestart);
            this.panelPracticeMode.Enabled = false;
            this.panelPracticeMode.Location = new System.Drawing.Point(12, 27);
            this.panelPracticeMode.Name = "panelPracticeMode";
            this.panelPracticeMode.Size = new System.Drawing.Size(760, 393);
            this.panelPracticeMode.TabIndex = 0;
            this.panelPracticeMode.Visible = false;
            // 
            // buttonPracticeDone
            // 
            this.buttonPracticeDone.Location = new System.Drawing.Point(332, 259);
            this.buttonPracticeDone.Name = "buttonPracticeDone";
            this.buttonPracticeDone.Size = new System.Drawing.Size(75, 23);
            this.buttonPracticeDone.TabIndex = 2;
            this.buttonPracticeDone.Text = "&Done";
            this.buttonPracticeDone.UseVisualStyleBackColor = true;
            this.buttonPracticeDone.Click += new System.EventHandler(this.buttonPracticeDone_Click);
            // 
            // panelPracticeControls
            // 
            this.panelPracticeControls.Controls.Add(this.textBoxPractice);
            this.panelPracticeControls.Controls.Add(this.buttonPracticeConfirm);
            this.panelPracticeControls.Location = new System.Drawing.Point(279, 198);
            this.panelPracticeControls.Name = "panelPracticeControls";
            this.panelPracticeControls.Size = new System.Drawing.Size(186, 26);
            this.panelPracticeControls.TabIndex = 11;
            this.panelPracticeControls.Visible = false;
            // 
            // textBoxPractice
            // 
            this.textBoxPractice.Location = new System.Drawing.Point(3, 3);
            this.textBoxPractice.Name = "textBoxPractice";
            this.textBoxPractice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPractice.TabIndex = 0;
            this.textBoxPractice.VisibleChanged += new System.EventHandler(this.textBoxPractice_VisibleChanged);
            this.textBoxPractice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPractice_KeyDown);
            // 
            // buttonPracticeConfirm
            // 
            this.buttonPracticeConfirm.Location = new System.Drawing.Point(109, 1);
            this.buttonPracticeConfirm.Name = "buttonPracticeConfirm";
            this.buttonPracticeConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonPracticeConfirm.TabIndex = 1;
            this.buttonPracticeConfirm.Text = "&Confirm";
            this.buttonPracticeConfirm.UseVisualStyleBackColor = true;
            this.buttonPracticeConfirm.Click += new System.EventHandler(this.buttonPracticeConfirm_Click);
            // 
            // labelPracticeText
            // 
            this.labelPracticeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPracticeText.Location = new System.Drawing.Point(12, 12);
            this.labelPracticeText.Name = "labelPracticeText";
            this.labelPracticeText.Size = new System.Drawing.Size(736, 185);
            this.labelPracticeText.TabIndex = 10;
            this.labelPracticeText.Text = "Instructions";
            this.labelPracticeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPracticeRestart
            // 
            this.buttonPracticeRestart.Location = new System.Drawing.Point(296, 230);
            this.buttonPracticeRestart.Name = "buttonPracticeRestart";
            this.buttonPracticeRestart.Size = new System.Drawing.Size(150, 23);
            this.buttonPracticeRestart.TabIndex = 4;
            this.buttonPracticeRestart.Text = "&Restart practice";
            this.buttonPracticeRestart.UseVisualStyleBackColor = true;
            this.buttonPracticeRestart.Click += new System.EventHandler(this.buttonPracticeRestart_Click);
            // 
            // FormWordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelPracticeMode);
            this.Controls.Add(this.panelEditMode);
            this.Controls.Add(this.labelCurrentWordList);
            this.Controls.Add(this.buttonAddWord);
            this.Controls.Add(this.buttonRemoveWord);
            this.Controls.Add(this.buttonPracticeMode);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FormWordList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordList";
            this.Shown += new System.EventHandler(this.FormWordList_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelEditMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).EndInit();
            this.panelPracticeMode.ResumeLayout(false);
            this.panelPracticeControls.ResumeLayout(false);
            this.panelPracticeControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.Label labelCurrentWordList;
        private System.Windows.Forms.Button buttonAddWord;
        private System.Windows.Forms.Button buttonRemoveWord;
        private System.Windows.Forms.Button buttonPracticeMode;
        private System.Windows.Forms.Panel panelEditMode;
        private System.Windows.Forms.DataGridView dataGridViewEdit;
        private System.Windows.Forms.Panel panelPracticeMode;
        private System.Windows.Forms.Label labelPracticeText;
        private System.Windows.Forms.Button buttonPracticeConfirm;
        private System.Windows.Forms.TextBox textBoxPractice;
        private System.Windows.Forms.Button buttonPracticeRestart;
        private System.Windows.Forms.Panel panelPracticeControls;
        private System.Windows.Forms.Button buttonPracticeDone;
        private System.Windows.Forms.ToolStripMenuItem editMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

