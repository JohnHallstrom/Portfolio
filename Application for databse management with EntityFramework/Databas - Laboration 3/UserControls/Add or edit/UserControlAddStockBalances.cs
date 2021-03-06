using System;
using System.Windows.Forms;

namespace DatabasLaboration3
{
    public partial class UserControlAddStockBalances : UserControl
    {
        public event EventHandler StockBalanceCreated;
        public LagerSaldo StockBalance;

        public Butiker SelectedBookstore;

        protected virtual void OnStockBalanceCreated(EventArgs e)
        {
            StockBalanceCreated?.Invoke(this, e);
        }

        public UserControlAddStockBalances()
        {
            InitializeComponent();
        }

        private void CreateStockBalance()
        {
            using var db = new BokhandelContext();
            
            if (!db.Database.CanConnect())
            {
                return;
            }

            var selectedBook = userControlBooks.SelectedBook;

            var stockBalance = new LagerSaldo
            {
                ButikerId = SelectedBookstore.Id,
                Isbn = selectedBook.Isbn,
                Antal = (int)numericUpDownAmount.Value
            };

            StockBalance = stockBalance;

            db.LagerSaldo.Add(stockBalance);
            db.SaveChanges();

            numericUpDownAmount.Value = 0;

            OnStockBalanceCreated(EventArgs.Empty);
        }

        private void UserControlAddStockBalances_Load(object sender, EventArgs e)
        {
            userControlBooks.ReloadSelectBooks(SelectedBookstore);

            buttonAdd.Enabled = userControlBooks.RowCount != 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreateStockBalance();

            userControlBooks.ReloadSelectBooks(SelectedBookstore);

            buttonAdd.Enabled = userControlBooks.RowCount != 0;
        }
    }
}
