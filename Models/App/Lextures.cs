using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KGMIPiPK
{
    public partial class Lextures
    {
        public Lextures()
        {
            Prisutstvie = new HashSet<Prisutstvie>();
        }

        public int Nom { get; set; }
        public DateTime Day { get; set; }
        public int Group { get; set; }
        public short Tema { get; set; }
        public short Teacher { get; set; }
        public byte Hours { get; set; }
        public byte VidZan { get; set; }

        public virtual Groups GroupNavigation { get; set; }
        public virtual Teachers TeacherNavigation { get; set; }
        public virtual Temy TemaNavigation { get; set; }
        public virtual VidZan VidZanNavigation { get; set; }
        public virtual ICollection<Prisutstvie> Prisutstvie { get; set; }
    }
}