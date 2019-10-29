using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Sex
    {
        public Sex()
        {
            Students = new HashSet<Students>();
        }

        public byte Code { get; set; }
        public string Sex1 { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}
