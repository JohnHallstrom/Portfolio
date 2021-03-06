namespace CSharpLaborationFourWinFormsApplication
{
    partial class FormIntroduction
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
            this.labelIntroductionText = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.checkBoxShowOnStartup = new System.Windows.Forms.CheckBox();
            this.labelWelcomeMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIntroductionText
            // 
            this.labelIntroductionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntroductionText.Location = new System.Drawing.Point(12, 55);
            this.labelIntroductionText.Name = "labelIntroductionText";
            this.labelIntroductionText.Size = new System.Drawing.Size(560, 168);
            this.labelIntroductionText.TabIndex = 0;
            this.labelIntroductionText.Text = "Introduction text";
            this.labelIntroductionText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonDone
            // 
            this.buttonDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDone.Location = new System.Drawing.Point(497, 226);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "&Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // checkBoxShowOnStartup
            // 
            this.checkBoxShowOnStartup.AutoSize = true;
            this.checkBoxShowOnStartup.Checked = true;
            this.checkBoxShowOnStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowOnStartup.Location = new System.Drawing.Point(388, 230);
            this.checkBoxShowOnStartup.Name = "checkBoxShowOnStartup";
            this.checkBoxShowOnStartup.Size = new System.Drawing.Size(103, 17);
            this.checkBoxShowOnStartup.TabIndex = 4;
            this.checkBoxShowOnStartup.Text = "Show on startup";
            this.checkBoxShowOnStartup.UseVisualStyleBackColor = true;
            this.checkBoxShowOnStartup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxShowOnStartup_MouseClick);
            // 
            // labelWelcomeMessage
            // 
            this.labelWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeMessage.Location = new System.Drawing.Point(12, 9);
            this.labelWelcomeMessage.Name = "labelWelcomeMessage";
            this.labelWelcomeMessage.Size = new System.Drawing.Size(560, 46);
            this.labelWelcomeMessage.TabIndex = 5;
            this.labelWelcomeMessage.Text = "Welcome to WordList!";
            this.labelWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormIntroduction
            // 
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonDone;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.labelWelcomeMessage);
            this.Controls.Add(this.checkBoxShowOnStartup);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.labelIntroductionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormIntroduction";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Introduction";
            this.Shown += new System.EventHandler(this.FormIntroduction_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIntroductionText;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.CheckBox checkBoxShowOnStartup;
        private System.Windows.Forms.Label labelWelcomeMessage;
    }
}