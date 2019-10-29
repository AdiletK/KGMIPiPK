using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Districts
    {
        public Districts()
        {
            Lpu = new HashSet<Lpu>();
            Settlements = new HashSet<Settlements>();
            Students = new HashSet<Students>();
        }

        public int Code { get; set; }
        public string District { get; set; }
        public byte Region { get; set; }
        public short? Ter3 { get; set; }

        public virtual Regions RegionNavigation { get; set; }
        public virtual ICollection<Lpu> Lpu { get; set; }
        public virtual ICollection<Settlements> Settlements { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
