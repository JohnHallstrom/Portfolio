using System;
using System.Collections.Generic;

#nullable disable

namespace DatabasLaboration3
{
    public partial class OrderDetaljer
    {
        public int Id { get; set; }
        public int OrdrarId { get; set; }
        public string Isbn { get; set; }
        public int Antal { get; set; }
        public decimal Styckpris { get; set; }
        public decimal? Moms { get; set; }
        public DateTime Orderdatum { get; set; }
        public DateTime Leveransdatum { get; set; }

        public virtual Böcker Böcker { get; set; }
        public virtual Ordrar Ordrar { get; set; }
    }
}
