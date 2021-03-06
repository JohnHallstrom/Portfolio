using System;
using System.Windows.Forms;
using CSharpLaborationFourLibrary;
using CSharp____Laboration_4_WinForms_Application.Properties;

namespace CSharpLaborationFourWinFormsApplication
{
    public partial class FormWordList : Form
    {
        public string CurrentList;

        private Word practiceWord;
        private int practiceTotal = 0;
        private int practiceCorrect = 0;

        public FormWordList()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewList newList = new FormNewList(this);

            if (newList.ShowDialog() == DialogResult.OK)
            {
                LoadNewList(newList);

                practiceToolStripMenuItem.Enabled = true;
                EditButtonsSwitch();

                labelCurrentWordList.Text = $"Current list: {newList.SelectedList}";
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSelectedList();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWord();
        }
        private void removeWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveWord();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!panelEditMode.Enabled)
            {
                panelPracticeMode.Enabled = false;
                panelPracticeMode.Visible = false;

                panelEditMode.Enabled = true;
                panelEditMode.Visible = true;

                labelCurrentWordList.Visible = true;

                EditButtonsSwitch();
            }
        }
        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelPracticeMode.Enabled)
            {
                panelEditMode.Enabled = false;
                panelEditMode.Visible = false;

                panelPracticeMode.Enabled = true;
                panelPracticeMode.Visible = true;
                
                labelCurrentWordList.Visible = false;

                EditButtonsSwitch();
            }

            Practice();
        }
        private void introductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIntroduction formIntroduction = new FormIntroduction();
            formIntroduction.ShowDialog();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormWordList_Shown(object sender, EventArgs e)
        {
            if (Settings.Default.ShowIntroductionOnStartup)
            {
                ShowIntroduction();
            }

            LoadSelectedList();
        }
        private void ShowIntroduction()
        {
            FormIntroduction introduction = new FormIntroduction();

            introduction.ShowDialog();
        }
    }
}