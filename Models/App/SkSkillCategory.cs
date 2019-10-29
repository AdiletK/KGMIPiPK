using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class SkSkillCategory
    {
        public int Id { get; set; }
        public int PersId { get; set; }
        public byte SkillId { get; set; }
        public short SpecCode { get; set; }
        public DateTime AssignDate { get; set; }
        public DateTime AttestDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? SwpLpuId { get; set; }
        public DateTime? DateSwp { get; set; }
        public string UserUpd { get; set; }
        public DateTime DateUpd { get; set; }
        public byte RecStatus { get; set; }
        public string AddComent { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderNumb { get; set; }
        public int? IdNew { get; set; }

        public virtual GlbSSkillCategoryStatus Skill { get; set; }
        public virtual GlbSSpec SpecCodeNavigation { get; set; }
    }
}
