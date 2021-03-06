using System;
using System.Linq;
using System.Windows.Forms;

namespace DatabasLaboration3
{
    public partial class UserControlAuthors : UserControl
    {
        public event EventHandler SelectionChanged;
        public Författare SelectedAuthor;

        public int RowCount;

        protected virtual void OnSelectionChanged(EventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }

        public UserControlAuthors()
        {
            InitializeComponent();
        }

        public void ReloadAuthors()
        {
            using var db = new BokhandelContext();
            
            if (!db.Database.CanConnect())
            {
                return;
            }
            
            dataGridViewAuthors.Rows.Clear();

            foreach (var author in db.Författare)
            {
                dataGridViewAuthors.Rows.Add(
                    author.Id, 
                    author.Förnamn, 
                    author.Efternamn, 
                    author.Födelsedatum.ToShortDateString()
                );
            }
        }

        private void dataGridViewAuthors_SelectionChanged(object sender, EventArgs e)
        {
            var row = dataGridViewAuthors.CurrentRow;

            var id = int.Parse(row.Cells[0].Value.ToString());

            using (var db = new BokhandelContext())
            {
                var author = db.Författare
                .SingleOrDefault(f => f.Id == id);

                SelectedAuthor = author;
            }

            OnSelectionChanged(EventArgs.Empty);
        }
        private void dataGridViewAuthors_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RowCount = dataGridViewAuthors.Rows.Count;
        }
        private void dataGridViewAuthors_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RowCount = dataGridViewAuthors.Rows.Count;
        }
    }
}
