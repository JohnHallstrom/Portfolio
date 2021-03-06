using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatabasLaboration3
{
    public partial class FormAddAndEdit : Form
    {
        public event EventHandler StockBalanceCreated;

        protected virtual void OnStockBalanceCreated(EventArgs e)
        {
            StockBalanceCreated?.Invoke(this, e);
        }

        public FormAddAndEdit()
        {
            InitializeComponent();
        }

        public void AddAuthor()
        {
            Text = "Lägg till ny författare...";

            var addAuthor = new UserControlAddOrEditAuthors { Dock = DockStyle.Fill };

            Size = addAuthor.Size;
            Controls.Add(addAuthor);
        }
        public void AddBook()
        {
            Text = "Lägg till ny bok...";

            var addBook = new UserControlAddOrEditBooks { Dock = DockStyle.Fill };

            Size = addBook.Size;
            Controls.Add(addBook);
        }
        public void AddPublisher()
        {
            Text = "Lägg till nytt förlag...";

            var addPublisher = new UserControlAddOrEditPublishers { Dock = DockStyle.Fill };

            Size = addPublisher.Size;
            Controls.Add(addPublisher);
        }
        public void AddStockBalance(Butiker bookstore)
        {
            Text = "Lägg till bok...";

            var addStockBalance = new UserControlAddStockBalances { Dock = DockStyle.Fill };
            addStockBalance.StockBalanceCreated += AddStockBalance_StockBalanceCreated;

            Size = addStockBalance.Size;
            Controls.Add(addStockBalance);
            addStockBalance.SelectedBookstore = bookstore;
        }
        public void EditAuthor(Författare author)
        {
            Text = "Ändra författare...";

            var editAuthor = new UserControlAddOrEditAuthors { Dock = DockStyle.Fill };

            Size = editAuthor.Size;
            Controls.Add(editAuthor);
            editAuthor.LoadAuthor(author);
        }
        public void EditBook(Böcker book)
        {
            Text = "Ändra bok...";

            var editBook = new UserControlAddOrEditBooks { Dock = DockStyle.Fill };

            Size = editBook.Size;
            Controls.Add(editBook);
            editBook.LoadBook(book);
        }
        public void EditPublisher(Förlag publisher)
        {
            Text = "Ändra förlag...";

            var editPublisher = new UserControlAddOrEditPublishers { Dock = DockStyle.Fill };
            
            Size = editPublisher.Size;
            Controls.Add(editPublisher);
            editPublisher.LoadPublisher(publisher);
        }

        private void AddStockBalance_StockBalanceCreated(object sender, EventArgs e)
        {
            StockBalanceCreated?.Invoke(this, e);
        }
    }
}
