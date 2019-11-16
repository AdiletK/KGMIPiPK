using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Lpu
    {
        public Lpu()
        {
            Students = new HashSet<Students>();
        }

        public short Nom { get; set; }
        public string Name { get; set; }
        public int District { get; set; }

        public virtual Districts DistrictNavigation { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}