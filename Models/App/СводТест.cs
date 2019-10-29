using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class СводТест
    {
        public string Курс { get; set; }
        public string Слушатель { get; set; }
        public string Дисциплина { get; set; }
        public byte Предтест { get; set; }
        public byte ПосттестТеория { get; set; }
        public byte ПосттестПрактика { get; set; }
    }
}
