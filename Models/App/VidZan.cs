using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class VidZan
    {
        public VidZan()
        {
            Lextures = new HashSet<Lextures>();
        }

        public byte Nom { get; set; }
        public string VidZan1 { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Lextures> Lextures { get; set; }
    }
}