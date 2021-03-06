using System;
using System.Linq;
using System.Windows.Forms;

namespace DatabasLaboration3
{
    public partial class UserControlAddOrEditPublishers : UserControl
    {
        public event EventHandler PublisherCreated;
        public Förlag Publisher;

        private Förlag publisherToEdit;
        private bool editedPublisher;

        protected virtual void OnPublisherCreated(EventArgs e)
        {
            PublisherCreated?.Invoke(this, e);
        }

        public UserControlAddOrEditPublishers()
        {
            InitializeComponent();
        }

        public void LoadPublisher(Förlag publisher)
        {
            buttonOk.Text = "Bekräfta";

            publisherToEdit = publisher;
            editedPublisher = true;

            textBoxName.Text = publisher.Namn;
            textBoxAdress.Text = publisher.Adress;
            textBoxCity.Text = publisher.Stad;
            textBoxPostcode.Text = publisher.Postnummer;
            textBoxContactPerson.Text = publisher.Kontaktperson;
            textBoxPhoneNumber.Text = publisher.Telefonnummer;
        }

        private void UserControlAddOrEditPublishers_Load(object sender, EventArgs e)
        {
            using var db = new BokhandelContext();

            var publishers = db.Förlag;

            ParentForm.AcceptButton = buttonOk;
            ParentForm.CancelButton = buttonCancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
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

            using var db = new BokhandelContext();

            if (!db.Database.CanConnect())
            {
                return;
            }

            if (editedPublisher)
            {
                publisherToEdit.Namn = textBoxName.Text;
                publisherToEdit.Adress = textBoxAdress.Text;
                publisherToEdit.Stad = textBoxCity.Text;
                publisherToEdit.Postnummer = textBoxPostcode.Text;
                publisherToEdit.Kontaktperson = textBoxContactPerson.Text;
                publisherToEdit.Telefonnummer = textBoxPhoneNumber.Text;

                db.Förlag.Update(publisherToEdit);
                db.SaveChanges();

                ParentForm.Close();
            }
            else
            {
                var publisher = new Förlag
                {
                    Namn = textBoxName.Text,
                    Adress = textBoxAdress.Text,
                    Stad = textBoxCity.Text,
                    Postnummer = textBoxPostcode.Text,
                    Kontaktperson = textBoxContactPerson.Text,
                    Telefonnummer = textBoxPhoneNumber.Text
                };

                Publisher = publisher;

                db.Förlag.Add(publisher);

                db.SaveChanges();

                OnPublisherCreated(EventArgs.Empty);

                ParentForm.Close();
            }
        }
        private void textBoxPostcode_Leave(object sender, EventArgs e)
        {
            if (textBoxPostcode.Text.Length != 5)
            {
                MessageBox.Show(this,
                    "Vänligen skriv in ett postnummer med 5 siffror.",
                    "Felaktigt postnummer",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxPostcode.Focus();
            }
        }
        private void textBoxPostcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
