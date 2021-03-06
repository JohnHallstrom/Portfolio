using System;
using System.Collections.Generic;

#nullable disable

namespace DatabasLaboration3
{
    public partial class Författare
    {
        public Författare()
        {
            BöckerFörfattare = new HashSet<BöckerFörfattare>();
        }

        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public DateTime Födelsedatum { get; set; }

        public virtual ICollection<BöckerFörfattare> BöckerFörfattare { get; set; }

        public override string ToString()
        {
            return $"{Förnamn} {Efternamn}";
        }
    }
}
