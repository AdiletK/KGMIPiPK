namespace KGMIPiPK
{
    public partial class СводМедперсонал
    {
        public string Фио { get; set; }
        public string Пол { get; set; }
        public string Инн { get; set; }
        public string Национальность { get; set; }
        public string Область { get; set; }
        public string Район { get; set; }
        public string НасПункт { get; set; }
        public string Адрес { get; set; }
        public string Лпу { get; set; }
        public string Должность { get; set; }
        public string Образование { get; set; }
        public byte? СтажОбщий { get; set; }
        public byte? СтажПоСпец { get; set; }
        public string Вуз { get; set; }
        public string Специальность { get; set; }
        public short? ГодОкончания { get; set; }
    }
}