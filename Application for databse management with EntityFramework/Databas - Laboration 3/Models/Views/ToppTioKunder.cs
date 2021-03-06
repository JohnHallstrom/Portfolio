using System;
using System.Collections.Generic;

#nullable disable

namespace DatabasLaboration3
{
    public partial class ToppTioKunder
    {
        public string Id { get; set; }
        public string Namn { get; set; }
        public int? AntalOrdrar { get; set; }
        public decimal? TotalbeloppInklMoms { get; set; }
    }
}
