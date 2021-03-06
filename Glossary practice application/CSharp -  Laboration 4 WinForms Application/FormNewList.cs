using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using CSharpLaborationFourLibrary;
using System.Text.RegularExpressions;

namespace CSharpLaborationFourWinFormsApplication
{
    public partial class FormNewList : Form
    {
        public string SelectedList { get { return textBoxListName.Text; } }
        
        private FormWordList parentWordList;
        private FormLoadList parentLoadList;

        public FormNewList(FormWordList parent)
        {
            parentWordList = parent;

            InitializeComponent();
        }

        public FormNewList(FormLoadList parent)
        {
            parentLoadList = parent;

            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            textBoxListName.Text = textBoxListName.Text.Trim();

            if (!string.IsNullOrEmpty(textBoxListName.Text))
            {
                if (textBoxListLanguages.Lines.Length > 1)
                {
                    if (!string.IsNullOrEmpty(textBoxListLanguages.Lines[0]) && 
                        !string.IsNullOrEmpty(textBoxListLanguages.Lines[1]))
                    {
                        string[] language = textBoxListLanguages.Lines;
                        
                        for (int i = 0; i < language.Length; i++)
                        {
                            language[i] = language[i].Trim();
                        }

                        WinFormsHelper.New(textBoxListName.Text, language);

                        buttonConfirm.DialogResult = DialogResult.OK;

                        if (parentLoadList != null)
                        {
                            parentLoadList.RefreshListBoxLists();
                        }
                        else
                        {
                            parentWordList.LoadNewList(this);
                        }

                        Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Enter at least two languages.", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    MessageBox.Show(this, "Enter at least two languages.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "Enter a list name.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void textBoxListName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex pattern = new Regex(@"[^\\|\/|:|\*|\?|""|<|>|\|]");

            if (!pattern.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;

                textBoxListName.BackColor = Color.LightPink;
                labelListNameInvalidInput.Visible = true;

                await Task.Delay(1000);

                textBoxListName.BackColor = Color.White;
            }
        }
    }
}