using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class PovyshenieKvalifikatsii
    {
        public int Nom { get; set; }
        public int Student { get; set; }
        public string Mesto { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }

        public virtual Students StudentNavigation { get; set; }
    }
}
