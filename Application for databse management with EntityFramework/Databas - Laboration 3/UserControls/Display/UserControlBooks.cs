using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace DatabasLaboration3
{
    public partial class UserControlBooks : UserControl
    {
        public event EventHandler SelectionChanged;
        public Böcker SelectedBook;

        public int RowCount;

        protected virtual void OnSelectionChanged(EventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }

        public UserControlBooks()
        {
            InitializeComponent();
        }

        public void ReloadBooks()
        {
            using var db = new BokhandelContext();

            if (!db.Database.CanConnect())
            {
                return;
            }

            dataGridViewBooks.Rows.Clear();

            foreach (var book in db.Böcker
                .Include(b => b.Förlag)
                .Include(b => b.BöckerFörfattare)
                .ThenInclude(b => b.Författare))
            {
                dataGridViewBooks.Rows.Add(
                    book.Isbn,
                    book.Titel,
                    book.Språk,
                    (int)book.Pris,
                    book.Utgivningsdatum.ToShortDateString(),
                    string.Join(", ", book.BöckerFörfattare.Select(b => b.Författare.ToString())),
                    book.Förlag.Namn
                );
            }
        }
        public void ReloadSelectBooks(Butiker bookstore)
        {
            using var db = new BokhandelContext();

            if (!db.Database.CanConnect())
            {
                return;
            }

            dataGridViewBooks.Rows.Clear();

            foreach (var book in db.Böcker
                       .Include(b => b.LagerSaldo)
                       .Include(b => b.Förlag)
                       .Include(b => b.BöckerFörfattare)
                       .ThenInclude(b => b.Författare)
                       .Where(s => s.LagerSaldo
                           .All(s => s.ButikerId != bookstore.Id)))
            {
                dataGridViewBooks.Rows.Add(
                    book.Isbn,
                    book.Titel,
                    book.Språk,
                    (int)book.Pris,
                    book.Utgivningsdatum.ToShortDateString(),
                    string.Join(", ", book.BöckerFörfattare.Select(b => b.Författare.ToString())),
                    book.Förlag.Namn
                );
            }
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            var row = dataGridViewBooks.CurrentRow;

            var isbn = row.Cells[0].Value.ToString();

            using (var db = new BokhandelContext())
            {
                var book = db.Böcker
                .SingleOrDefault(ls => ls.Isbn == isbn);

                SelectedBook = book;
            }

            OnSelectionChanged(EventArgs.Empty);
        }
        private void dataGridViewBooks_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowCount = dataGridViewBooks.Rows.Count;
        }
        private void dataGridViewBooks_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowCount = dataGridViewBooks.Rows.Count;
        }
    }
}