using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Kategoriya
    {
        public Kategoriya()
        {
            PovyshenieKategorii = new HashSet<PovyshenieKategorii>();
        }

        public byte Nom { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PovyshenieKategorii> PovyshenieKategorii { get; set; }
    }
}
