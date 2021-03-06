using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CSharpLaborationFourLibrary;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpLaborationFourWinFormsApplication
{
    public partial class FormAddWord : Form
    {
        FormWordList parentFormWordList;
        private bool wordAdded;

        public FormAddWord(FormWordList parent)
        {
            parentFormWordList = parent;

            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddWord();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            AddWord();
        }

        private void FormAddWord_Shown(object sender, EventArgs e)
        {
            string selection = parentFormWordList.CurrentList;

            dataGridView.TopLeftHeaderCell.Value = "LANGUAGE";
            dataGridView.Columns.Add("WORD", "WORD");

            int rowTotalHeight = 0;

            foreach (string language in WinFormsHelper.Languages(selection))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = language.ToUpper();

                dataGridView.Rows.Add(row);
                rowTotalHeight += row.Height;
            }

            Height = rowTotalHeight + (138 - 44) + dataGridView.ColumnHeadersHeight;
        }
        private void FormAddWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wordAdded)
            {
                DialogResult = DialogResult.OK;
            }
        }
        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddWord();
            }
        }

        private bool AddWord()
        {
            List<string> wordsToAdd = new List<string>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 0)
                    {
                        if (!string.IsNullOrEmpty((string)cell.Value))
                        {
                            cell.Value = cell.Value.ToString().Trim();

                            if (string.IsNullOrEmpty((string)cell.Value))
                            {
                                MessageBox.Show(this, "Enter one translation for every language.", "Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Enter one translation for every language.", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return false;
                        }

                        
                        wordsToAdd.Add(cell.Value.ToString().ToLower());
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
   
            WinFormsHelper.Add(parentFormWordList.CurrentList, wordsToAdd.ToArray());

            parentFormWordList.RefreshLoadedList();

            dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
            dataGridView.BeginEdit(true);
            
            wordAdded = true;

            return true;
        }
    }
}