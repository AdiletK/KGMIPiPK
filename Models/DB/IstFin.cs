using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class IstFin
    {
        public IstFin()
        {
            Courses = new HashSet<Courses>();
        }

        public byte Nom { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
    }
}