using System;
using System.Collections.Generic;

#nullable disable

namespace DatabasLaboration3
{
    public partial class BöckerFörfattare
    {
        public string Isbn { get; set; }
        public int FörfattareId { get; set; }

        public virtual Författare Författare { get; set; }
        public virtual Böcker IsbnNavigation { get; set; }
    }
}
