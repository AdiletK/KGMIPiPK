using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KGMIPiPK
{
    public partial class Courses
    {
        public Courses()
        {
            Groups = new HashSet<Groups>();
            Tests = new HashSet<Tests>();
        }

        public int Nom { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime? From { get; set; }
        [DataType(DataType.Date)]
        public DateTime? To { get; set; }
        public string FullName { get; set; }
        public bool Graduated { get; set; }
        public byte? Plan { get; set; }
        public byte? IstFin { get; set; }
        public int? Oplata { get; set; }

        public virtual IstFin IstFinNavigation { get; set; }
        public virtual ICollection<Groups> Groups { get; set; }
        public virtual ICollection<Tests> Tests { get; set; }
    }
}