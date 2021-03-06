using System;
using System.Collections.Generic;

#nullable disable

namespace DatabasLaboration3
{
    public partial class Butiker
    {
        public Butiker()
        {
            LagerSaldo = new HashSet<LagerSaldo>();
            Ordrar = new HashSet<Ordrar>();
        }

        public int Id { get; set; }
        public string Namn { get; set; }
        public string Adress { get; set; }
        public string Stad { get; set; }
        public string Postnummer { get; set; }

        public virtual ICollection<LagerSaldo> LagerSaldo { get; set; }
        public virtual ICollection<Ordrar> Ordrar { get; set; }

        public override string ToString()
        {
            return Namn;
        }
    }
}
