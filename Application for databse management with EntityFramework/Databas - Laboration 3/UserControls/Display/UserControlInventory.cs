using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace DatabasLaboration3
{
    public partial class UserControlInventory : UserControl
    {
        public event EventHandler BookSelectionChanged;
        public Böcker SelectedBook;
        protected virtual void OnBookSelectionChanged(EventArgs e)
        {
            BookSelectionChanged?.Invoke(this, e);
        }

        public event EventHandler AuthorSelectionChanged;
        public Författare SelectedAuthor;
        protected virtual void OnAuthorSelectionChanged(EventArgs e)
        {
            AuthorSelectionChanged?.Invoke(this, e);
        }

        public event EventHandler PublisherSelectionChanged;
        public Förlag SelectedPublisher;
        protected virtual void OnPublisherSelectionChanged(EventArgs e)
        {
            PublisherSelectionChanged?.Invoke(this, e);
        }

        public UserControlInventory()
        {
            InitializeComponent();
        }

        public void ReloadInventory()
        {
            userControlBooks.ReloadBooks();
            userControlAuthors.ReloadAuthors();
            userControlPublishers.ReloadPublishers();

            buttonEdit.Enabled = userControlBooks.RowCount != 0;
            buttonRemove.Enabled = userControlBooks.RowCount != 0;
        }

        private void UserControlInventory_Load(object sender, EventArgs e)
        {
            using var db = new BokhandelContext();

            buttonAdd.Enabled = db.Database.CanConnect();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    var addBook = new FormAddAndEdit();

                    addBook.AddBook();
                    addBook.ShowDialog();
                    userControlBooks.ReloadBooks();
                    break;
                case 1:
                    var addAuthor = new FormAddAndEdit();

                    addAuthor.AddAuthor();
                    addAuthor.ShowDialog();
                    userControlAuthors.ReloadAuthors();
                    break;
                case 2:
                    var addPublisher = new FormAddAndEdit();

                    addPublisher.AddPublisher();
                    addPublisher.ShowDialog();
                    userControlPublishers.ReloadPublishers();
                    break;
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    var editBook = new FormAddAndEdit();

                    editBook.EditBook(userControlBooks.SelectedBook);
                    editBook.ShowDialog();
                    userControlBooks.ReloadBooks();
                    break;
                case 1:
                    var editAuthor = new FormAddAndEdit();

                    editAuthor.EditAuthor(userControlAuthors.SelectedAuthor);
                    editAuthor.ShowDialog();
                    userControlAuthors.ReloadAuthors();
                    break;
                case 2:
                    var editPublisher = new FormAddAndEdit();

                    editPublisher.EditPublisher(userControlPublishers.SelectedPublisher);
                    editPublisher.ShowDialog();
                    userControlPublishers.ReloadPublishers();
                    break;
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    if (MessageBox.Show(this,
                        "Vill du ta bort vald bok från sortimentet?",
                        "Ta bort bok från sortiment",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using var db = new BokhandelContext();

                        if (!db.Database.CanConnect())
                        {
                            return;
                        }

                        if (db.LagerSaldo.Any(l => l.Isbn == SelectedBook.Isbn))
                        {
                            MessageBox.Show(this,
                            "Boken finns i ett lager och kan därför inte tas bort.",
                            "Kan inte ta bort bok",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }

                        foreach (var item in db.BöckerFörfattare.Where(b => b.Isbn == SelectedBook.Isbn))
                        {
                            db.BöckerFörfattare.Remove(item);
                        }

                        db.Böcker.Remove(userControlBooks.SelectedBook);
                        db.SaveChanges();
                        userControlBooks.ReloadBooks();
                    }
                    break;
                case 1:
                    if (MessageBox.Show(this,
                        "Vill du ta bort vald författare?",
                        "Ta bort författare",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using var db = new BokhandelContext();

                        if (!db.Database.CanConnect())
                        {
                            return;
                        }

                        if (db.BöckerFörfattare.Any(b => b.FörfattareId == SelectedAuthor.Id))
                        {
                            MessageBox.Show(this,
                            "Författaren har böcker i sortimentet och kan därför inte tas bort.",
                            "Kan inte ta bort författare",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }

                        db.Författare.Remove(userControlAuthors.SelectedAuthor);
                        db.SaveChanges();
                        userControlAuthors.ReloadAuthors();
                    }
                    break;
                case 2:
                    if (MessageBox.Show(this,
                        "Vill du ta bort valt förlag?",
                        "Ta bort förlag",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using var db = new BokhandelContext();

                        if (!db.Database.CanConnect())
                        {
                            return;
                        }

                        if (db.Böcker.Any(b => b.FörlagId == SelectedPublisher.Id))
                        {
                            MessageBox.Show(this,
                            "Förlaget har böcker i sortimentet och kan därför inte tas bort.",
                            "Kan inte ta bort förlag",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }

                        db.Förlag.Remove(userControlPublishers.SelectedPublisher);
                        db.SaveChanges();
                        userControlPublishers.ReloadPublishers();
                    }
                    break;
            }
        }

        private void userControlBooks_SelectionChanged(object sender, EventArgs e)
        {
            SelectedBook = userControlBooks.SelectedBook;
        }
        private void userControlAuthors_SelectionChanged(object sender, EventArgs e)
        {
            SelectedAuthor = userControlAuthors.SelectedAuthor;
        }
        private void userControlPublishers_SelectionChanged(object sender, EventArgs e)
        {
            SelectedPublisher = userControlPublishers.SelectedPublisher;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    buttonEdit.Enabled = userControlBooks.RowCount != 0;
                    buttonRemove.Enabled = userControlBooks.RowCount != 0;
                    break;
                case 1:
                    buttonEdit.Enabled = userControlAuthors.RowCount != 0;
                    buttonRemove.Enabled = userControlAuthors.RowCount != 0;
                    break;
                case 2:
                    buttonEdit.Enabled = userControlPublishers.RowCount != 0;
                    buttonRemove.Enabled = userControlPublishers.RowCount != 0;
                    break;
            }
        }
    }
}
