using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class GlbSSkillCategoryStatus
    {
        public GlbSSkillCategoryStatus()
        {
            SkSkillCategory = new HashSet<SkSkillCategory>();
        }

        public byte Id { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<SkSkillCategory> SkSkillCategory { get; set; }
    }
}
