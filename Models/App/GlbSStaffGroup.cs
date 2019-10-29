using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class GlbSStaffGroup
    {
        public GlbSStaffGroup()
        {
            GlbSStaffType = new HashSet<GlbSStaffType>();
        }

        public byte Id { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<GlbSStaffType> GlbSStaffType { get; set; }
    }
}
