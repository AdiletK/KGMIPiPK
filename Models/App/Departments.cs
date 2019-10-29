using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Departments
    {
        public Departments()
        {
            Teachers = new HashSet<Teachers>();
        }

        public byte Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public byte Faculty { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual Faculties FacultyNavigation { get; set; }
        public virtual ICollection<Teachers> Teachers { get; set; }
    }
}
