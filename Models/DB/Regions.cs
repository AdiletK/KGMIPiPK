using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Regions
    {
        public Regions()
        {
            Districts = new HashSet<Districts>();
        }

        public byte Code { get; set; }
        public string Region { get; set; }
        public byte Country { get; set; }

        public virtual Countries CountryNavigation { get; set; }
        public virtual ICollection<Districts> Districts { get; set; }
    }
}