using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Prisutstvie
    {
        public int Nom { get; set; }
        public int Lexture { get; set; }
        public int Student { get; set; }
        public string Prisutstvie1 { get; set; }
        public string Prim { get; set; }

        public virtual Lextures LextureNavigation { get; set; }
        public virtual Students StudentNavigation { get; set; }
    }
}
