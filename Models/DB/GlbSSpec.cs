using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class GlbSSpec
    {
        public GlbSSpec()
        {
            PovyshenieKategorii = new HashSet<PovyshenieKategorii>();
            SkSkillCategory = new HashSet<SkSkillCategory>();
        }

        public short Code { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<PovyshenieKategorii> PovyshenieKategorii { get; set; }
        public virtual ICollection<SkSkillCategory> SkSkillCategory { get; set; }
    }
}