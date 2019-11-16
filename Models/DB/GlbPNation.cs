using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class GlbPNation
    {
        public GlbPNation()
        {
            Students = new HashSet<Students>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}