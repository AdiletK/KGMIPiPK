﻿using System;

namespace KGMIPiPK
{
    public partial class GlbTer3
    {
        public short Id { get; set; }
        public byte Ter2Id { get; set; }
        public string FullName { get; set; }
        public string Soato { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Comment { get; set; }
    }
}