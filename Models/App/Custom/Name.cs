using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KGMIPiPK
{
    public partial class Name
    {
        //not db class
        public Name()
        {
        }

        [Key]
        public int Number { get; set; }
        public String FIO { get; set; }
    }
}
