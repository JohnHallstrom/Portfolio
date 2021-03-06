using System;
using System.Collections.Generic;

#nullable disable

namespace DatabasLaboration3
{
    public partial class Förlag
    {
        public Förlag()
        {
            Böcker = new HashSet<Böcker>();
        }

        public int Id { get; set; }
        public string Namn { get; set; }
        public string Adress { get; set; }
        public string Stad { get; set; }
        public string Postnummer { get; set; }
        public string Kontaktperson { get; set; }
        public string Telefonnummer { get; set; }

        public virtual ICollection<Böcker> Böcker { get; set; }

        public override string ToString()
        {
            return Namn;
        }
    }
}
