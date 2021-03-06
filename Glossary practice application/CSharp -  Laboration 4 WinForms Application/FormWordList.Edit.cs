using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CSharpLaborationFourLibrary;

namespace CSharpLaborationFourWinFormsApplication
{
    partial class FormWordList
    {
        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            AddWord();
        }
        private void buttonRemoveWord_Click(object sender, EventArgs e)
        {
            RemoveWord();
        }
        private void buttonPractice_Click(object sender, EventArgs e)
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

        public void LoadNewList(FormNewList newList)
        {
            dataGridViewEdit.Columns.Clear();
            dataGridViewEdit.Rows.Clear();

            string selection = newList.SelectedList;

            foreach (string language in WinFormsHelper.Languages(selection))
            {
                dataGridViewEdit.Columns.Add(language, language.ToUpper());
            }

            foreach (string[] words in WinFormsHelper.AllWords(selection))
            {
                dataGridViewEdit.Rows.Add(words);
            }

            practiceToolStripMenuItem.Enabled = true;
            EditButtonsSwitch();

            labelCurrentWordList.Text = $"Current list: {newList.SelectedList}";

            CurrentList = newList.SelectedList;
        }
        private void AddWord()
        {
            FormAddWord addWord = new FormAddWord(this);

            if (addWord.ShowDialog() == DialogResult.OK)
            {
                RefreshLoadedList();

                EditButtonsSwitch();
            }
        }
        private void RemoveWord()
        {
            DataGridViewSelectedCellCollection selectedRow = dataGridViewEdit.SelectedCells;

            List<string> translations = new List<string>();

            foreach (DataGridViewCell cell in selectedRow)
            {
                translations.Add(cell.Value.ToString().ToLower());
            }

            Word wordToRemove = new Word(translations.ToArray());

            WinFormsHelper.Remove(CurrentList, wordToRemove);

            RefreshLoadedList();

            EditButtonsSwitch();
        }
        private void EditButtonsSwitch()
        {
            #region Enable/Disable edit mode buttons
            if (dataGridViewEdit.ColumnCount > 1)
            {
                buttonAddWord.Enabled = true;
                addWordToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
            }
            else
            {
                buttonAddWord.Enabled = false;
                addWordToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
            }

            if (dataGridViewEdit.RowCount > 0)
            {
                buttonRemoveWord.Enabled = true;
                removeWordToolStripMenuItem.Enabled = true;
            }
            else
            {
                buttonRemoveWord.Enabled = false;
                removeWordToolStripMenuItem.Enabled = false;
            }

            if (dataGridViewEdit.RowCount > 1)
            {
                buttonPracticeMode.Enabled = true;
                practiceToolStripMenuItem.Enabled = true;
            }
            else
            {
                buttonPracticeMode.Enabled = false;
                practiceToolStripMenuItem.Enabled = false;
            }
            #endregion

            #region Visibility for buttons and label
            if (panelEditMode.Enabled == true)
            {
                buttonAddWord.Visible = true;
                buttonRemoveWord.Visible = true;
                buttonPracticeMode.Visible = true;
                addWordToolStripMenuItem.Visible = true;
                removeWordToolStripMenuItem.Visible = true;
            }
            else
            {
                buttonAddWord.Visible = false;
                buttonRemoveWord.Visible = false;
                buttonPracticeMode.Visible = false;
                addWordToolStripMenuItem.Visible = false;
                removeWordToolStripMenuItem.Visible = false;
            }
            #endregion
        }
        private void LoadSelectedList()
        {
            FormLoadList loadList = new FormLoadList();

            if (loadList.ShowDialog() == DialogResult.OK)
            {
                dataGridViewEdit.Columns.Clear();
                dataGridViewEdit.Rows.Clear();

                string selection = loadList.SelectedList;

                foreach (string language in WinFormsHelper.Languages(selection))
                {
                    dataGridViewEdit.Columns.Add(language, language.ToUpper());
                }

                foreach (string[] words in WinFormsHelper.AllWords(selection))
                {
                    dataGridViewEdit.Rows.Add(words);
                }

                EditButtonsSwitch();
                buttonAddWord.Enabled = true;

                labelCurrentWordList.Text = $"Current list: {loadList.SelectedList}";

                CurrentList = loadList.SelectedList;
            }
        }
        public void RefreshLoadedList()
        {
            dataGridViewEdit.Columns.Clear();
            dataGridViewEdit.Rows.Clear();

            foreach (string language in WinFormsHelper.Languages(CurrentList))
            {
                dataGridViewEdit.Columns.Add(language, language.ToUpper());
            }

            foreach (string[] words in WinFormsHelper.AllWords(CurrentList))
            {
                dataGridViewEdit.Rows.Add(words);
            }
        }
    }
}