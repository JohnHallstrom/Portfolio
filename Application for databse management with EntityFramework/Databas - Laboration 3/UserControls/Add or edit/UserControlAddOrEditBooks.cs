using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DatabasLaboration3
{
    public partial class UserControlAddOrEditBooks : UserControl
    {
        public event EventHandler BookCreated;
        public Böcker Book;

        private Böcker bookToEdit;
        private bool editedBook;

        protected virtual void OnBookCreated(EventArgs e)
        {
            BookCreated?.Invoke(this, e);
        }

        public UserControlAddOrEditBooks()
        {
            InitializeComponent();
        }

        public void LoadBook(Böcker book)
        {
            buttonAdd.Text = "Bekräfta";

            bookToEdit = book;
            editedBook = true;

            textBoxISBN.Text = book.Isbn;
            textBoxTitle.Text = book.Titel;
            textBoxLanguage.Text = book.Språk;
            textBoxPrice.Text = Convert.ToInt32(book.Pris).ToString();
            dateTimePickerPublishingDate.Value = book.Utgivningsdatum;
        }

        private void UserControlAddBooks_Load(object sender, EventArgs e)
        {
            ParentForm.AcceptButton = buttonAdd;
            ParentForm.CancelButton = buttonCancel;

            using var db = new BokhandelContext();

            if (!db.Database.CanConnect())
            {
                return;
            }
            
            foreach (var author in db.Författare)
            {
                comboBoxAuthors.Items.Add(author);
            }

            foreach (var publisher in db.Förlag)
            {
                comboBoxPublishers.Items.Add(publisher);
            }

            if (editedBook)
            {
                db.Attach(bookToEdit);
                db.Entry(bookToEdit).Collection(b => b.BöckerFörfattare).Load();

                foreach (var author in bookToEdit.BöckerFörfattare)
                {
                    listBoxAuthors.Items.Add(author.Författare);
                }

                foreach (Förlag publisher in comboBoxPublishers.Items)
                {
                    if (publisher.Id == bookToEdit.FörlagId)
                    {
                        comboBoxPublishers.SelectedItem = publisher;
                    }
                }
            }
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            listBoxAuthors.Items.Add(comboBoxAuthors.SelectedItem);
            comboBoxAuthors.Items.Remove(comboBoxAuthors.SelectedItem);

            buttonAddAuthor.Enabled = false;
        }
        private void buttonRemoveAuthor_Click(object sender, EventArgs e)
        {
            comboBoxAuthors.Items.Add(listBoxAuthors.SelectedItem);
            listBoxAuthors.Items.Remove(listBoxAuthors.SelectedItem);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
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

            if (listBoxAuthors.Items.Count == 0 || comboBoxPublishers.SelectedItem == null)
            {
                MessageBox.Show(this,
                        "Ett eller fler val är tomma.",
                        "Tomt val",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            using var db = new BokhandelContext();

            if (!db.Database.CanConnect())
            {
                return;
            }

            if (editedBook)
            {
                bookToEdit.Isbn = textBoxISBN.Text;
                bookToEdit.Titel = textBoxTitle.Text;
                bookToEdit.Språk = textBoxLanguage.Text;
                bookToEdit.Pris = decimal.Parse(textBoxPrice.Text);
                bookToEdit.Utgivningsdatum = dateTimePickerPublishingDate.Value;
                bookToEdit.BöckerFörfattare = new List<BöckerFörfattare>();

                foreach (Författare author in listBoxAuthors.Items)
                {
                    bookToEdit.BöckerFörfattare.Add(new BöckerFörfattare
                    {
                        Isbn = bookToEdit.Isbn,
                        FörfattareId = author.Id
                    });
                }

                foreach (var item in db.BöckerFörfattare)
                {
                    if (item.Isbn == bookToEdit.Isbn)
                    {
                        db.BöckerFörfattare.Remove(item);
                    }
                }

                db.Böcker.Update(bookToEdit);
                db.SaveChanges();

                ParentForm.Close();
            }
            else
            {
                if (db.Böcker.Find(textBoxISBN.Text) == null)
                {
                    var publisher = comboBoxPublishers.SelectedItem as Förlag;

                    var book = new Böcker
                    {
                        Isbn = textBoxISBN.Text,
                        FörlagId = publisher.Id,
                        Titel = textBoxTitle.Text,
                        Språk = textBoxLanguage.Text,
                        Pris = decimal.Parse(textBoxPrice.Text),
                        Utgivningsdatum = dateTimePickerPublishingDate.Value,
                        BöckerFörfattare = new List<BöckerFörfattare>()
                    };

                    foreach (Författare author in listBoxAuthors.Items)
                    {
                        book.BöckerFörfattare.Add(new BöckerFörfattare
                        {
                            Isbn = book.Isbn,
                            FörfattareId = author.Id
                        });
                    }

                    Book = book;

                    db.Böcker.Add(book);
                    db.SaveChanges();

                    OnBookCreated(EventArgs.Empty);

                    ParentForm.Close();
                }
                else
                {
                    MessageBox.Show(this,
                        "Boken finns redan i sortimentet.",
                        "Bok finns redan.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void textBoxISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textBoxISBN_Leave(object sender, EventArgs e)
        {
            if (textBoxISBN.Text.Length != 13)
            {
                MessageBox.Show(this,
                    "Vänligen skriv in ett ISBN med 13 siffor.",
                    "Felaktigt ISBN-nummer",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxISBN.Focus();
            }
        }

        private void comboBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAddAuthor.Enabled = comboBoxAuthors.SelectedItem != null;
        }
        private void listBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemoveAuthor.Enabled = listBoxAuthors.SelectedItem != null;
        }
    }
}
