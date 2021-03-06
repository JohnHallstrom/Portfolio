using System;
using System.Linq;
using System.Windows.Forms;

namespace DatabasLaboration3
{
    public partial class UserControlAddOrEditAuthors : UserControl
    {
        public event EventHandler AuthorCreated;
        public Författare Author;

        private Författare authorToEdit;
        private bool editedAuthor;

        protected virtual void OnAuthorCreated(EventArgs e)
        {
            AuthorCreated?.Invoke(this, e);
        }

        public UserControlAddOrEditAuthors()
        {
            InitializeComponent();
        }

        public void LoadAuthor(Författare author)
        {
            buttonOk.Text = "Bekräfta";

            authorToEdit = author;
            editedAuthor = true;

            textBoxFirstname.Text = author.Förnamn;
            textBoxLastname.Text = author.Efternamn;
            dateTimePickerBirthdate.Value = author.Födelsedatum;
        }

        private void UserControlAddOrEditAuthors_Load(object sender, EventArgs e)
        {
            ParentForm.AcceptButton = buttonOk;
            ParentForm.CancelButton = buttonCancel;

            dateTimePickerBirthdate.MaxDate = DateTime.Now;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                if (control.Text.Length == 0)
                {
                    MessageBox.Show(this,
                        "Ett eller fler fält är tomma.",
                        "Tomt textfält",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            using var db = new BokhandelContext();

            if (!db.Database.CanConnect())
            {
                return;
            }

            if (editedAuthor)
            {
                authorToEdit.Förnamn = textBoxFirstname.Text;
                authorToEdit.Efternamn = textBoxLastname.Text;
                authorToEdit.Födelsedatum = dateTimePickerBirthdate.Value;

                db.Författare.Update(authorToEdit);
                db.SaveChanges();
            }
            else
            {
                var author = new Författare
                {
                    Förnamn = textBoxFirstname.Text,
                    Efternamn = textBoxLastname.Text,
                    Födelsedatum = dateTimePickerBirthdate.Value
                };

                Author = author;

                db.Författare.Add(author);
                db.SaveChanges();

                OnAuthorCreated(EventArgs.Empty);
            }

            ParentForm.Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
