using System;
using System.Windows.Forms;
using CSharp____Laboration_4_WinForms_Application.Properties;

namespace CSharpLaborationFourWinFormsApplication
{
    public partial class FormIntroduction : Form
    {
        public FormIntroduction()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormIntroduction_Shown(object sender, EventArgs e)
        {
            checkBoxShowOnStartup.Checked = Settings.Default.ShowIntroductionOnStartup;

            labelIntroductionText.Text =
                "WordList 0.8.2.\n\n" +
                "Practice your vocabulary in different languages.\n" +
                "You can create new WordLists, or edit already existing ones.\n\n" +
                "Upcoming 0.9 features: Automaticly add words from other lists in matching languages, " +
                "colour modes and size modes.";
        }

        private void checkBoxShowOnStartup_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxShowOnStartup.Checked)
            {
                Settings.Default.ShowIntroductionOnStartup = true;
                MessageBox.Show(this, "Introduction page will now show on startup.", "Introduction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Settings.Default.ShowIntroductionOnStartup = false;

                MessageBox.Show(this, "Introduction page can be found in the 'Help' menu.", "Introduction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Settings.Default.Save();
        }
    }
}