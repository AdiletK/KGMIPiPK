using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class GurnalPosesh1
    {
        public byte Nom { get; set; }
        public int? Group { get; set; }
        public int? Student { get; set; }
        public byte? VidZan { get; set; }
        public DateTime? _1Day { get; set; }
        public DateTime? _2Day { get; set; }
        public DateTime? _3Day { get; set; }
        public DateTime? _4Day { get; set; }
        public DateTime? _5Day { get; set; }
        public DateTime? _6Day { get; set; }
        public DateTime? _7Day { get; set; }
        public DateTime? _8Day { get; set; }
        public DateTime? _9Day { get; set; }
        public DateTime? _10Day { get; set; }
        public DateTime? _11Day { get; set; }
        public DateTime? _12Day { get; set; }
        public string _1D { get; set; }
        public string _2D { get; set; }
        public string _3D { get; set; }
        public string _4D { get; set; }
        public string _5D { get; set; }
        public string _6D { get; set; }
        public string _7D { get; set; }
        public string _8D { get; set; }
        public string _9D { get; set; }
        public string _10D { get; set; }
        public string _11D { get; set; }
        public string _12D { get; set; }
        public DateTime? Day { get; set; }
        public byte? Hours { get; set; }
        public string Thema { get; set; }
        public string Teacher { get; set; }

        public virtual Students StudentNavigation { get; set; }
    }
}
