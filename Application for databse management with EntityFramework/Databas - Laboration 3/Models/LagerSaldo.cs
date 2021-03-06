using System;
using System.Collections.Generic;

#nullable disable

namespace DatabasLaboration3
{
    public partial class LagerSaldo
    {
        public int ButikerId { get; set; }
        public string Isbn { get; set; }
        public int Antal { get; set; }

        public virtual Butiker Butiker { get; set; }
        public virtual Böcker Böcker { get; set; }
    }
}
