using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Temy
    {
        public Temy()
        {
            Lextures = new HashSet<Lextures>();
        }

        public short Nom { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Lextures> Lextures { get; set; }
    }
}