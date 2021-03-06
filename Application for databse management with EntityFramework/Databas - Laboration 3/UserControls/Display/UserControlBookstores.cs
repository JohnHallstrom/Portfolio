using System;
using System.Windows.Forms;

namespace DatabasLaboration3
{
    public partial class UserControlBookstores : UserControl
    {
        public event EventHandler BookstoreSelectionChanged;
        public Butiker SelectedBookstore;

        protected virtual void OnSelectionChanged(EventArgs e)
        {
            BookstoreSelectionChanged?.Invoke(this, e);
        }

        public UserControlBookstores()
        {
            InitializeComponent();
        }

        public void ReloadBookstores()
        {
            using var db = new BokhandelContext();

            if (!db.Database.CanConnect())
            {
                return;
            }

            comboBoxBookstores.Items.Clear();

            foreach (var bookstore in db.Butiker)
            {
                comboBoxBookstores.Items.Add(bookstore);
            }

            if (comboBoxBookstores.SelectedItem == null)
            {
                comboBoxBookstores.SelectedIndex = 0;
            }
        }
        public void ReloadBookstoreInformation()
        {
            using var db = new BokhandelContext();

            if (!db.Database.CanConnect())
            {
                return;
            }

            dataGridViewBookstores.Columns.Clear();
            dataGridViewBookstores.Rows.Clear();

            dataGridViewBookstores.TopLeftHeaderCell.Value = "TYPE";
            dataGridViewBookstores.Columns.Add("INFO", "INFO");

            string[] relevantInfo = { "Namn", "Adress", "Stad", "Postnummer" };

            foreach (string info in relevantInfo)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = info.ToUpper();

                foreach (var property in comboBoxBookstores.SelectedItem.GetType().GetProperties())
                {
                    if (property.Name == info)
                    {
                        row.CreateCells(
                            dataGridViewBookstores,
                            property.GetValue(comboBoxBookstores.SelectedItem)
                        );
                    }
                }

                dataGridViewBookstores.Rows.Add(row);
            }
        }

        private void comboBoxBookstores_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadBookstoreInformation();

            SelectedBookstore = comboBoxBookstores.SelectedItem as Butiker;

            OnSelectionChanged(EventArgs.Empty);
        }
    }
}
