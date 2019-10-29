using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Settlements
    {
        public Settlements()
        {
            Students = new HashSet<Students>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int? Ter3Id { get; set; }

        public virtual Districts Ter3 { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
