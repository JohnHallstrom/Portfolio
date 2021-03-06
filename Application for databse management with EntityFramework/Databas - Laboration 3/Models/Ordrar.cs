using System;
using System.Collections.Generic;

#nullable disable

namespace DatabasLaboration3
{
    public partial class Ordrar
    {
        public Ordrar()
        {
            OrderDetaljer = new HashSet<OrderDetaljer>();
        }

        public int Id { get; set; }
        public string KunderId { get; set; }
        public int ButikerId { get; set; }
        public string Betalningssätt { get; set; }

        public virtual Butiker Butiker { get; set; }
        public virtual Kunder Kunder { get; set; }
        public virtual ICollection<OrderDetaljer> OrderDetaljer { get; set; }
    }
}
