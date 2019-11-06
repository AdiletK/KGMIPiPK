using System;

namespace KGMIPiPK
{
    public partial class PovyshenieKategorii
    {
        public int Nom { get; set; }
        public int Student { get; set; }
        public byte Kategoriya { get; set; }
        public short Spec { get; set; }
        public DateTime Date { get; set; }

        public virtual Kategoriya KategoriyaNavigation { get; set; }
        public virtual GlbSSpec SpecNavigation { get; set; }
        public virtual Students StudentNavigation { get; set; }
    }
}