using System;
using System.Collections.Generic;

#nullable disable

namespace DatabasLaboration3
{
    public partial class Kunder
    {
        public Kunder()
        {
            Ordrar = new HashSet<Ordrar>();
        }

        public string Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Adress { get; set; }
        public string Stad { get; set; }
        public string Postnummer { get; set; }
        public string Epostadress { get; set; }
        public string Telefonnnummer { get; set; }

        public virtual ICollection<Ordrar> Ordrar { get; set; }
    }
}
