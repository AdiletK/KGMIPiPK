using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class GlbSStaffType
    {
        public GlbSStaffType()
        {
            SkPerson = new HashSet<SkPerson>();
            Students = new HashSet<Students>();
        }

        public byte Code { get; set; }
        public byte StafgrId { get; set; }
        public string FullName { get; set; }

        public virtual GlbSStaffGroup Stafgr { get; set; }
        public virtual ICollection<SkPerson> SkPerson { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
