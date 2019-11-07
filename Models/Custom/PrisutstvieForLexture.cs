using System;
using System.ComponentModel.DataAnnotations;

namespace KGMIPiPK
{
    public partial class PrisutstvieForLexture
    {
        //not db class
        public PrisutstvieForLexture()
        {
        }

        [Key]
        public int Nom { get; set; }

        public String Student { get; set; }

        public String Prisutstvie { get; set; }
        public String Prim { get; set; }
    }
}