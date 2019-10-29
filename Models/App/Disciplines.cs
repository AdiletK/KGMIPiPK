using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Disciplines
    {
        public Disciplines()
        {
            Tests = new HashSet<Tests>();
        }

        public byte Nom { get; set; }
        public string Discipline { get; set; }

        public virtual ICollection<Tests> Tests { get; set; }
    }
}
