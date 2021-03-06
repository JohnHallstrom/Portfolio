using System;
using System.Linq;
using System.Windows.Forms;

namespace DatabasLaboration3
{
    public partial class UserControlPublishers : UserControl
    {
        public event EventHandler SelectionChanged;
        public Förlag SelectedPublisher;

        public int RowCount;

        protected virtual void OnSelectionChanged(EventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }

        public UserControlPublishers()
        {
            InitializeComponent();
        }

        public void ReloadPublishers()
        {
            using var db = new BokhandelContext();

            if (!db.Database.CanConnect())
            {
                return;
            }

            dataGridViewPublishers.Rows.Clear();

            foreach (var publisher in db.Förlag)
            {
                dataGridViewPublishers.Rows.Add(
                    publisher.Id,
                    publisher.Namn,
                    publisher.Adress,
                    publisher.Stad,
                    publisher.Postnummer,
                    publisher.Kontaktperson,
                    publisher.Telefonnummer
                );
            }
        }

        private void dataGridViewPublishers_SelectionChanged(object sender, EventArgs e)
        {
            var row = dataGridViewPublishers.CurrentRow;

            var id = int.Parse(row.Cells[0].Value.ToString());

            using (var db = new BokhandelContext())
            {
                var publisher = db.Förlag
                .SingleOrDefault(f => f.Id == id);

                SelectedPublisher = publisher;
            }

            OnSelectionChanged(EventArgs.Empty);
        }
        private void dataGridViewPublishers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowCount = dataGridViewPublishers.Rows.Count;
        }
        private void dataGridViewPublishers_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowCount = dataGridViewPublishers.Rows.Count;
        }
    }
}
