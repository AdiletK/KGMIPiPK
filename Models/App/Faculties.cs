using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Faculties
    {
        public Faculties()
        {
            Departments = new HashSet<Departments>();
            Teachers = new HashSet<Teachers>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Departments> Departments { get; set; }
        public virtual ICollection<Teachers> Teachers { get; set; }
    }
}