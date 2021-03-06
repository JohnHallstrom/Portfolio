using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace DatabasLaboration3
{
    public partial class FormBookstoreManager : Form
    {
        public Författare SelectedAuthor;
        public Böcker SelectedBook;
        public Butiker SelectedBookstore;
        public Författare SelectedPublisher;

        public FormBookstoreManager()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            using var db = new BokhandelContext();

            if (!db.Database.CanConnect())
            {
                MessageBox.Show(
                    "Det gick inte att ansluta till databasen.", 
                    "Kunde inte ansluta", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            userControlInventory.ReloadInventory();
            userControlBookstores.ReloadBookstores();
            userControlBookstores.ReloadBookstoreInformation();
            userControlStockBalances.ReloadStockBalance(SelectedBookstore);
        }
       
        private void userControlBookstores_BookstoreSelectionChanged(object sender, EventArgs e)
        {
            if (userControlBookstores.SelectedBookstore != null)
            {
                SelectedBookstore = userControlBookstores.SelectedBookstore;

                userControlStockBalances.ReloadStockBalance(SelectedBookstore);
            }
        }
        private void userControlInventory_AuthorSelectionChanged(object sender, EventArgs e)
        {
            if (userControlInventory.SelectedAuthor != null)
            {
                SelectedAuthor = userControlInventory.SelectedAuthor;
            }
        }
        private void userControlInventory_BookSelectionChanged(object sender, EventArgs e)
        {
            if (userControlInventory.SelectedBook != null)
            {
                SelectedBook = userControlInventory.SelectedBook;
            }
        }
        private void userControlInventory_PublisherSelectionChanged(object sender, EventArgs e)
        {
            if (userControlInventory.SelectedAuthor != null)
            {
                SelectedPublisher = userControlInventory.SelectedAuthor;
            }
        }
    }
}