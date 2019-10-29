using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class GlbTer2
    {
        public byte Id { get; set; }
        public byte Ter1Id { get; set; }
        public string FullName { get; set; }
        public string Soato { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Comment { get; set; }
    }
}
