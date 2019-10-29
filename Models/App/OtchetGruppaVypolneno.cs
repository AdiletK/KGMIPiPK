using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class OtchetGruppaVypolneno
    {
        public byte Nom { get; set; }
        public string Курс { get; set; }
        public DateTime От { get; set; }
        public DateTime До { get; set; }
        public string Группа { get; set; }
        public byte Запланировано { get; set; }
        public string Преподаватель { get; set; }
        public byte? Лк { get; set; }
        public byte? Пр { get; set; }
        public byte? Мр { get; set; }
    }
}
