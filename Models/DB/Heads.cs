using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Heads
    {
        public Heads()
        {
            Students = new HashSet<Students>();
        }

        public byte Nom { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}