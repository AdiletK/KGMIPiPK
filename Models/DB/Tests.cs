namespace KGMIPiPK
{
    public partial class Tests
    {
        public int Nom { get; set; }
        public int Course { get; set; }
        public int Student { get; set; }
        public byte Discipline { get; set; }
        public byte Predtest { get; set; }
        public byte PosttestPract { get; set; }
        public byte PosttestTeor { get; set; }

        public virtual Courses CourseNavigation { get; set; }
        public virtual Disciplines DisciplineNavigation { get; set; }
        public virtual Students StudentNavigation { get; set; }
    }
}