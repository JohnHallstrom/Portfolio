using System;
using System.Windows.Forms;
using CSharpLaborationFourLibrary;

namespace CSharpLaborationFourWinFormsApplication
{
    public partial class FormLoadList : Form
    {
        public string SelectedList { get { return listBoxList.GetItemText(listBoxList.SelectedItem); } }

        public FormLoadList()
        {
            InitializeComponent();
        }

        private void listBoxLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxList.Items.Count != 0)
            {
                buttonDeleteList.Enabled = true;
                buttonLoadList.Enabled = true;
            }

            labelWordCount.Visible = true;
            labelWordCount.Text = $"Word count: {WinFormsHelper.Count(listBoxList.GetItemText(listBoxList.SelectedItem))}";

            listBoxLanguage.Items.Clear();

            foreach (string language in WinFormsHelper.Languages(listBoxList.GetItemText(listBoxList.SelectedItem)))
            {
                listBoxLanguage.Items.Add(language.Capitalize());
            }

            listBoxLanguage.SelectedIndex = 0;
        }
        private void listBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxWord.Items.Clear();

            foreach (string word in WinFormsHelper.SelectLanguageWords(
                listBoxList.GetItemText(listBoxList.SelectedItem), 
                listBoxLanguage.GetItemText(listBoxLanguage.SelectedItem)))
            {
                listBoxWord.Items.Add(word.Capitalize());
            }
        }
        private void listBoxList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxList.Items.Count != 0)
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }
        private void listBoxList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteListPrompt();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonNewList_Click(object sender, EventArgs e)
        {
            FormNewList newList = new FormNewList(this);

            if (newList.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
        }
        private void buttonDeleteList_Click(object sender, EventArgs e)
        {
            DeleteListPrompt();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLoadList_Shown(object sender, EventArgs e)
        {
            RefreshListBoxLists();
        }

        public void RefreshListBoxLists()
        {
            listBoxList.Items.Clear();
            listBoxLanguage.Items.Clear();
            listBoxWord.Items.Clear();

            foreach (string list in WinFormsHelper.Lists())
            {
                listBoxList.Items.Add(list);
            }

            if (listBoxList.Items.Count != 0)
            {
                listBoxList.SelectedIndex = 0;
                listBoxLanguage.SelectedIndex = 0;
            }
            else
            {
                buttonDeleteList.Enabled = false;
                buttonLoadList.Enabled = false;
            }
        }
        private void DeleteListPrompt()
        {
            if (MessageBox.Show(this, "Are you sure you want to permanently delete this list?", 
                "Delete list", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                WinFormsHelper.DeleteList(listBoxList.GetItemText(listBoxList.SelectedItem));

                RefreshListBoxLists();
            }
        }
    }
}