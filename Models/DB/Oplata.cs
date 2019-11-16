using System;
using System.ComponentModel.DataAnnotations;

namespace KGMIPiPK
{
    public partial class Oplata
    {
        public int Nom { get; set; }
        public int Student { get; set; }
        public int Summa { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}