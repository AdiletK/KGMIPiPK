using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Posts
    {
        public Posts()
        {
            Students = new HashSet<Students>();
        }

        public byte Nom { get; set; }
        public string Post { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}