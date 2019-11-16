using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Countries
    {
        public Countries()
        {
            Regions = new HashSet<Regions>();
        }

        public byte Code { get; set; }
        public string Country { get; set; }
        public byte Indication { get; set; }

        public virtual ICollection<Regions> Regions { get; set; }
    }
}