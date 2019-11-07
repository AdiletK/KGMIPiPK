using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Teachers
    {
        public Teachers()
        {
            Lextures = new HashSet<Lextures>();
        }

        public short Nom { get; set; }
        public string Fio { get; set; }
        public byte? Faculty { get; set; }
        public byte? Department { get; set; }
        public string Telefon { get; set; }
        public string Prim { get; set; }

        public virtual Departments DepartmentNavigation { get; set; }
        public virtual Faculties FacultyNavigation { get; set; }
        public virtual ICollection<Lextures> Lextures { get; set; }
    }
}