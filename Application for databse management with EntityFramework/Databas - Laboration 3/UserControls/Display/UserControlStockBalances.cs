using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace DatabasLaboration3
{
    public partial class UserControlStockBalances : UserControl
    {
        public event EventHandler SelectionChanged;
        public LagerSaldo SelectedStockBalance;

        private Butiker selectedBookstore;

        protected virtual void OnSelectionChanged(EventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }

        public UserControlStockBalances()
        {
            InitializeComponent();
        }

        public void ReloadStockBalance(Butiker bookstore)
        {
            using var db = new BokhandelContext();

            if (!db.Database.CanConnect())
            {
                return;
            }
                
            selectedBookstore = bookstore;

            dataGridViewStockBalances.Rows.Clear();

            foreach (var book in db.Böcker.Include(book => book.LagerSaldo))
            {
                foreach (var stock in book.LagerSaldo.Where(s => s.ButikerId == bookstore.Id))
                {
                    dataGridViewStockBalances.Rows.Add(
                        stock.ButikerId, 
                        book.Isbn, 
                        book.Titel, 
                        stock.Antal
                    );
                }
            }
        }

        private void UserControlStockBalances_Load(object sender, EventArgs e)
        {
            using var db = new BokhandelContext();

            buttonAddBook.Enabled = db.Database.CanConnect();
        }

        private void AddAndEdit_StockBalanceCreated(object sender, EventArgs e)
        {
            ReloadStockBalance(selectedBookstore);
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            var addAndEdit = new FormAddAndEdit();
            addAndEdit.StockBalanceCreated += AddAndEdit_StockBalanceCreated;
            addAndEdit.AddStockBalance(selectedBookstore);
            addAndEdit.ShowDialog();

            ReloadStockBalance(selectedBookstore);
        }
        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,
                "Vill du ta bort vald bok från lagret?",
                "Ta bort bok från lager",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using var db = new BokhandelContext();

                if (!db.Database.CanConnect())
                {
                    return;
                }

                db.LagerSaldo.Remove(SelectedStockBalance);
                db.SaveChanges();

                ReloadStockBalance(selectedBookstore);
            }
        }
        private void buttonEditBalance_Click(object sender, EventArgs e)
        {
            if (panelEditStockBalance.Visible == false)
            {
                panelEditStockBalance.Visible = true;
                buttonEditBalance.Text = "Sluta ändra";
            }
            else
            {
                panelEditStockBalance.Visible = false;
                buttonEditBalance.Text = "Ändra saldo";
            }
        }
        private void buttonStockBalanceEditConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,
                "Vill du ändra saldo på vald bok?",
                "Ändra lagersaldo för bok",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using var db = new BokhandelContext();

                if (!db.Database.CanConnect())
                {
                    return;
                }

                SelectedStockBalance.Antal = (int)numericUpDownStockBalance.Value;

                db.Update(SelectedStockBalance);
                db.SaveChanges();

                ReloadStockBalance(selectedBookstore);
            }
        }

        private void dataGridViewStockBalances_SelectionChanged(object sender, EventArgs e)
        {
            var row = dataGridViewStockBalances.CurrentRow;

            var storeId = (int)row.Cells[0].Value;
            var isbn = row.Cells[1].Value.ToString();

            using (var db = new BokhandelContext())
            {
                var stockBalance = db.LagerSaldo
                    .Include(s => s.Böcker)
                    .SingleOrDefault(ls => ls.ButikerId == storeId && ls.Isbn == isbn);

                SelectedStockBalance = stockBalance;
            }

            OnSelectionChanged(EventArgs.Empty);

            if (SelectedStockBalance != null)
            {
                labelEditStockBalanceTitle.Text = SelectedStockBalance.Böcker.Titel;
                numericUpDownStockBalance.Value = SelectedStockBalance.Antal;
            }
            else
            {
                labelEditStockBalanceTitle.Text = "Ingen bok vald.";
                numericUpDownStockBalance.Value = 0;
            }
        }
        private void dataGridViewStockBalances_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridViewStockBalances.Rows.Count > 0)
            {
                buttonEditBalance.Enabled = true;
                buttonRemoveBook.Enabled = true;
            }
        }
        private void dataGridViewStockBalances_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridViewStockBalances.Rows.Count == 0)
            {
                buttonEditBalance.Enabled = false;
                buttonRemoveBook.Enabled = false;
            }
        }
    }
}
