using System;
using System.Collections.Generic;

#nullable disable

namespace DatabasLaboration3
{
    public partial class Böcker
    {
        public Böcker()
        {
            BöckerFörfattare = new HashSet<BöckerFörfattare>();
            LagerSaldo = new HashSet<LagerSaldo>();
            OrderDetaljer = new HashSet<OrderDetaljer>();
        }

        public string Isbn { get; set; }
        public int FörlagId { get; set; }
        public string Titel { get; set; }
        public string Språk { get; set; }
        public decimal Pris { get; set; }
        public DateTime Utgivningsdatum { get; set; }

        public virtual Förlag Förlag { get; set; }
        public virtual ICollection<BöckerFörfattare> BöckerFörfattare { get; set; }
        public virtual ICollection<LagerSaldo> LagerSaldo { get; set; }
        public virtual ICollection<OrderDetaljer> OrderDetaljer { get; set; }
    }
}
