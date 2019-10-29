using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Groups
    {
        public Groups()
        {
            Lextures = new HashSet<Lextures>();
            Students = new HashSet<Students>();
        }

        public int Code { get; set; }
        public string Grup { get; set; }
        public int Course { get; set; }
        public bool? Select { get; set; }

        public virtual Courses CourseNavigation { get; set; }
        public virtual ICollection<Lextures> Lextures { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
