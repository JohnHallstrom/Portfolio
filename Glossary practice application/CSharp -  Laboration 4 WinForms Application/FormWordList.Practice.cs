using System;
using System.Windows.Forms;
using CSharpLaborationFourLibrary;

namespace CSharpLaborationFourWinFormsApplication
{
    partial class FormWordList
    {
        private void buttonPracticeConfirm_Click(object sender, EventArgs e)
        {
            CheckUserTranslation();
        }
        private void buttonPracticeDone_Click(object sender, EventArgs e)
        {
            EndPractice();
        }
        private void buttonPracticeRestart_Click(object sender, EventArgs e)
        {
            practiceTotal = 0;
            practiceCorrect = 0;

            Practice();
        }
        private void textBoxPractice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckUserTranslation();

                e.SuppressKeyPress = true;
            }
        }
        private void textBoxPractice_VisibleChanged(object sender, EventArgs e)
        {
            textBoxPractice.Select();
        }

        private void Practice()
        {
            PracticeControlsOn(true);

            WordList loadedList = WordList.LoadList(CurrentList);

            Word word = loadedList.GetWordToPractice();
            practiceWord = word;

            labelPracticeText.Text =
                    $"Enter the {loadedList.Languages[word.ToLanguage]} translation \n" +
                    $"for the {loadedList.Languages[word.FromLanguage]} " +
                    $"word '{word.Translations[word.FromLanguage]}':";

            textBoxPractice.Clear();
        }
        private void EndPractice()
        {
            PracticeControlsOn(false);

            labelPracticeText.Text = $"You answered {practiceCorrect} correct out of {practiceTotal} total.";
        }
        private void PracticeControlsOn(bool on)
        {
            if (on)
            {
                panelPracticeControls.Visible = true;

                buttonPracticeDone.Enabled = true;
                buttonPracticeDone.Visible = true;

                buttonPracticeRestart.Enabled = false;
                buttonPracticeRestart.Visible = false;
            }
            else
            {
                panelPracticeControls.Visible = false;

                buttonPracticeDone.Enabled = false;
                buttonPracticeDone.Visible = false;

                buttonPracticeRestart.Enabled = true;
                buttonPracticeRestart.Visible = true;
            }
        }
        
        private void CheckUserTranslation()
        {
            if (textBoxPractice.Text.Length != 0)
            {
                if (textBoxPractice.Text == practiceWord.Translations[practiceWord.ToLanguage])
                {
                    practiceTotal++;
                    practiceCorrect++;

                    if (MessageBox.Show("Correct answer.\n\nContinue?", "Result",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Practice();
                    }
                    else
                    {
                        EndPractice();
                    }
                }
                else
                {
                    practiceTotal++;

                    if (MessageBox.Show(
                        $"Wrong answer.\n" +
                        $"Correct answer: {practiceWord.Translations[practiceWord.ToLanguage]}\n\n" +
                        $"Continue?",
                        "Result", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Practice();
                    }
                    else
                    {
                        EndPractice();
                    }
                }
            }
        }
    }
}