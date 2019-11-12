using System;
using System.ComponentModel.DataAnnotations;

namespace KGMIPiPK
{
    public partial class Course_Group
    {
        //not db class
        public Course_Group()
        {
        }

        [Key]
        public int Code { get; set; }

        public String Group { get; set; }

        public byte Plan { get; set; }
    }
}