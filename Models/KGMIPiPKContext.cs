using Microsoft.EntityFrameworkCore;

namespace KGMIPiPK
{
    public partial class KGMIPiPKContext : DbContext
    {
        public KGMIPiPKContext()
        {
        }

        public KGMIPiPKContext(DbContextOptions<KGMIPiPKContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course_Group> Course_Group { get; set; }
        public virtual DbSet<Name> Names { get; set; }
        public virtual DbSet<AcademicStatus> AcademicStatus { get; set; }
        public virtual DbSet<AkademStepen> AkademStepen { get; set; }
        public virtual DbSet<Awards> Awards { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<DirectorName> DirectorName { get; set; }
        public virtual DbSet<Disciplines> Disciplines { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<Excel> Excel { get; set; }
        public virtual DbSet<Faculties> Faculties { get; set; }
        public virtual DbSet<GlbPNation> GlbPNation { get; set; }
        public virtual DbSet<GlbSSkillCategoryStatus> GlbSSkillCategoryStatus { get; set; }
        public virtual DbSet<GlbSSpec> GlbSSpec { get; set; }
        public virtual DbSet<GlbSStaffGroup> GlbSStaffGroup { get; set; }
        public virtual DbSet<GlbSStaffType> GlbSStaffType { get; set; }
        public virtual DbSet<GlbTer1> GlbTer1 { get; set; }
        public virtual DbSet<GlbTer2> GlbTer2 { get; set; }
        public virtual DbSet<GlbTer3> GlbTer3 { get; set; }
        public virtual DbSet<GlbTer5> GlbTer5 { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<GurnalPosesh> GurnalPosesh { get; set; }
        public virtual DbSet<GurnalPosesh1> GurnalPosesh1 { get; set; }
        public virtual DbSet<Heads> Heads { get; set; }
        public virtual DbSet<IndicationOfCountry> IndicationOfCountry { get; set; }
        public virtual DbSet<IstFin> IstFin { get; set; }
        public virtual DbSet<Kategoriya> Kategoriya { get; set; }
        public virtual DbSet<Lextures> Lextures { get; set; }
        public virtual DbSet<Lpu> Lpu { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<Nationalities> Nationalities { get; set; }
        public virtual DbSet<Obrazovanie> Obrazovanie { get; set; }
        public virtual DbSet<Oplata> Oplata { get; set; }
        public virtual DbSet<OtchetGruppaVypolneno> OtchetGruppaVypolneno { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<PovyshenieKategorii> PovyshenieKategorii { get; set; }
        public virtual DbSet<PovyshenieKvalifikatsii> PovyshenieKvalifikatsii { get; set; }
        public virtual DbSet<Prisutstvie> Prisutstvie { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<ScientificDegree> ScientificDegree { get; set; }
        public virtual DbSet<Settlements> Settlements { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<SkPerson> SkPerson { get; set; }
        public virtual DbSet<SkSkillCategory> SkSkillCategory { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Temp> Temp { get; set; }
        public virtual DbSet<Temy> Temy { get; set; }
        public virtual DbSet<Tests> Tests { get; set; }
        public virtual DbSet<TmpSPerson> TmpSPerson { get; set; }
        public virtual DbSet<Tsikly> Tsikly { get; set; }
        public virtual DbSet<UchregdenieName> UchregdenieName { get; set; }
        public virtual DbSet<VidZan> VidZan { get; set; }
        public virtual DbSet<View1> View1 { get; set; }
        public virtual DbSet<View2> View2 { get; set; }
        public virtual DbSet<ViewGurnal> ViewGurnal { get; set; }
        public virtual DbSet<ViewRegionsOfKg> ViewRegionsOfKg { get; set; }
        public virtual DbSet<ViewStudentsSvodZan> ViewStudentsSvodZan { get; set; }
        public virtual DbSet<ViewSumHoursStud> ViewSumHoursStud { get; set; }
        public virtual DbSet<ViewВсеIdСПовторамиПоИнн> ViewВсеIdСПовторамиПоИнн { get; set; }
        public virtual DbSet<ViewВсеIdСПовторамиПоФио> ViewВсеIdСПовторамиПоФио { get; set; }
        public virtual DbSet<ViewНеСовпадают> ViewНеСовпадают { get; set; }
        public virtual DbSet<ViewНеСовпадаютПоИнн> ViewНеСовпадаютПоИнн { get; set; }
        public virtual DbSet<ViewОсновная> ViewОсновная { get; set; }
        public virtual DbSet<ViewПовторыSkPerson> ViewПовторыSkPerson { get; set; }
        public virtual DbSet<ViewПовторыSkПоИнн> ViewПовторыSkПоИнн { get; set; }
        public virtual DbSet<ViewПовторыTmpПоИнн> ViewПовторыTmpПоИнн { get; set; }
        public virtual DbSet<ViewПовторыПоФио> ViewПовторыПоФио { get; set; }
        public virtual DbSet<ViewСовпадают> ViewСовпадают { get; set; }
        public virtual DbSet<ViewСовпадаютПоИнн> ViewСовпадаютПоИнн { get; set; }
        public virtual DbSet<ViewСовпадаютПоФио> ViewСовпадаютПоФио { get; set; }
        public virtual DbSet<Year> Year { get; set; }
        public virtual DbSet<СводЗанятия> СводЗанятия { get; set; }
        public virtual DbSet<СводМедперсонал> СводМедперсонал { get; set; }
        public virtual DbSet<СводТест> СводТест { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8S2GQN1;Database=KGMIPiPK;User Id=koyl;password=123;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcademicStatus>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.ToTable("Academic_status");

                entity.Property(e => e.AcademicStatus1)
                    .HasColumnName("Academic_status")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AkademStepen>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Awards>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Award)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.Nom)
                    .HasName("PK_Specialities");

                entity.Property(e => e.From).HasColumnType("smalldatetime");

                entity.Property(e => e.FullName)
                    .HasMaxLength(137)
                    .HasComputedColumnSql("((((rtrim([Name])+' c ')+CONVERT([varchar](15),[From],(104)))+' по ')+CONVERT([varchar](15),[To],(104)))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Oplata).HasDefaultValueSql("((0))");

                entity.Property(e => e.Plan).HasDefaultValueSql("((0))");

                entity.Property(e => e.To).HasColumnType("smalldatetime");

                entity.HasOne(d => d.IstFinNavigation)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.IstFin)
                    .HasConstraintName("FK_Courses_IstFin");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Faculty).HasDefaultValueSql("((3))");

                entity.Property(e => e.Login)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.ShortName)
                    .HasColumnName("Short_Name")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.FacultyNavigation)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.Faculty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departments_Faculties");
            });

            modelBuilder.Entity<DirectorName>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.ToTable("Director_Name");

                entity.Property(e => e.Director)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.NachUchChasti)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.ZamDirector)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Disciplines>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Nom).ValueGeneratedOnAdd();

                entity.Property(e => e.Discipline)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.RegionNavigation)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.Region)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Districts_Regions");
            });

            modelBuilder.Entity<Excel>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.КороткоеНазвание)
                    .HasColumnName("Короткое название")
                    .HasMaxLength(255);

                entity.Property(e => e.Область).HasMaxLength(255);

                entity.Property(e => e.ПолноеНазвание)
                    .HasColumnName("Полное название")
                    .HasMaxLength(255);

                entity.Property(e => e.Район).HasMaxLength(255);
            });

            modelBuilder.Entity<Faculties>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full_Name")
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GlbPNation>(entity =>
            {
                entity.ToTable("glb_P_nation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GlbSSkillCategoryStatus>(entity =>
            {
                entity.ToTable("glb_S_skill_category_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GlbSSpec>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("glb_S_spec");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .ValueGeneratedNever();

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GlbSStaffGroup>(entity =>
            {
                entity.ToTable("glb_S_staff_group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GlbSStaffType>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("glb_S_staff_type");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StafgrId).HasColumnName("stafgr_id");

                entity.HasOne(d => d.Stafgr)
                    .WithMany(p => p.GlbSStaffType)
                    .HasForeignKey(d => d.StafgrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_glb_S_staff_type_glb_S_staff_group");
            });

            modelBuilder.Entity<GlbTer1>(entity =>
            {
                entity.ToTable("glb_ter1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soato)
                    .HasColumnName("SOATO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<GlbTer2>(entity =>
            {
                entity.ToTable("glb_Ter2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Soato)
                    .IsRequired()
                    .HasColumnName("SOATO")
                    .HasMaxLength(5);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Ter1Id).HasColumnName("Ter1_ID");
            });

            modelBuilder.Entity<GlbTer3>(entity =>
            {
                entity.ToTable("glb_Ter3");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Soato)
                    .IsRequired()
                    .HasColumnName("SOATO")
                    .HasMaxLength(3);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Ter2Id).HasColumnName("Ter2_ID");
            });

            modelBuilder.Entity<GlbTer5>(entity =>
            {
                entity.ToTable("glb_Ter5");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment).HasMaxLength(20);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Soato)
                    .IsRequired()
                    .HasColumnName("SOATO")
                    .HasMaxLength(11);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Ter2Id).HasColumnName("Ter2_ID");

                entity.Property(e => e.Ter3Id).HasColumnName("Ter3_ID");

                entity.Property(e => e.Ter4Id).HasColumnName("Ter4_ID");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Grup)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.CourseNavigation)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.Course)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_Courses");
            });

            modelBuilder.Entity<GurnalPosesh>(entity =>
            {
                entity.HasKey(e => e.Nom)
                    .HasName("PK_Table_1");

                entity.Property(e => e.Day).HasColumnType("smalldatetime");

                entity.Property(e => e.Teacher)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Thema)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.VidZan).HasColumnName("Vid_Zan");

                entity.Property(e => e._10D)
                    .HasColumnName("10_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._10Day)
                    .HasColumnName("10_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._11D)
                    .HasColumnName("11_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._11Day)
                    .HasColumnName("11_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._12D)
                    .HasColumnName("12_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._12Day)
                    .HasColumnName("12_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._13D)
                    .HasColumnName("13_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._13Day)
                    .HasColumnName("13_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._14D)
                    .HasColumnName("14_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._14Day)
                    .HasColumnName("14_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._15D)
                    .HasColumnName("15_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._15Day)
                    .HasColumnName("15_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._1D)
                    .HasColumnName("1_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._1Day)
                    .HasColumnName("1_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._2D)
                    .HasColumnName("2_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._2Day)
                    .HasColumnName("2_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._3D)
                    .HasColumnName("3_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._3Day)
                    .HasColumnName("3_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._4D)
                    .HasColumnName("4_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._4Day)
                    .HasColumnName("4_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._5D)
                    .HasColumnName("5_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._5Day)
                    .HasColumnName("5_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._6D)
                    .HasColumnName("6_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._6Day)
                    .HasColumnName("6_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._7D)
                    .HasColumnName("7_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._7Day)
                    .HasColumnName("7_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._8D)
                    .HasColumnName("8_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._8Day)
                    .HasColumnName("8_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._9D)
                    .HasColumnName("9_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._9Day)
                    .HasColumnName("9_day")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<GurnalPosesh1>(entity =>
            {
                entity.HasKey(e => e.Nom)
                    .HasName("PK_GurnalPosesh");

                entity.ToTable("GurnalPosesh_1");

                entity.Property(e => e.Day).HasColumnType("smalldatetime");

                entity.Property(e => e.Teacher)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Thema)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.VidZan).HasColumnName("Vid_Zan");

                entity.Property(e => e._10D)
                    .HasColumnName("10_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._10Day)
                    .HasColumnName("10_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._11D)
                    .HasColumnName("11_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._11Day)
                    .HasColumnName("11_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._12D)
                    .HasColumnName("12_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._12Day)
                    .HasColumnName("12_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._1D)
                    .HasColumnName("1_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._1Day)
                    .HasColumnName("1_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._2D)
                    .HasColumnName("2_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._2Day)
                    .HasColumnName("2_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._3D)
                    .HasColumnName("3_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._3Day)
                    .HasColumnName("3_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._4D)
                    .HasColumnName("4_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._4Day)
                    .HasColumnName("4_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._5D)
                    .HasColumnName("5_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._5Day)
                    .HasColumnName("5_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._6D)
                    .HasColumnName("6_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._6Day)
                    .HasColumnName("6_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._7D)
                    .HasColumnName("7_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._7Day)
                    .HasColumnName("7_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._8D)
                    .HasColumnName("8_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._8Day)
                    .HasColumnName("8_day")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._9D)
                    .HasColumnName("9_d")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._9Day)
                    .HasColumnName("9_day")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.StudentNavigation)
                    .WithMany(p => p.GurnalPosesh1)
                    .HasForeignKey(d => d.Student)
                    .HasConstraintName("FK_GurnalPosesh_Students");
            });

            modelBuilder.Entity<Heads>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Nom).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<IndicationOfCountry>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Indication)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<IstFin>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Kategoriya>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lextures>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.HasIndex(e => new { e.Day, e.Group, e.Teacher, e.Tema })
                    .HasName("IX_Lextures")
                    .IsUnique();

                entity.Property(e => e.Day).HasColumnType("smalldatetime");

                entity.Property(e => e.Hours).HasDefaultValueSql("((1))");

                entity.Property(e => e.VidZan).HasColumnName("Vid_zan");

                entity.HasOne(d => d.GroupNavigation)
                    .WithMany(p => p.Lextures)
                    .HasForeignKey(d => d.Group)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lextures_Groups");

                entity.HasOne(d => d.TeacherNavigation)
                    .WithMany(p => p.Lextures)
                    .HasForeignKey(d => d.Teacher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lextures_Teachers");

                entity.HasOne(d => d.TemaNavigation)
                    .WithMany(p => p.Lextures)
                    .HasForeignKey(d => d.Tema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lextures_Temy");

                entity.HasOne(d => d.VidZanNavigation)
                    .WithMany(p => p.Lextures)
                    .HasForeignKey(d => d.VidZan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lextures_Vid_Zan");
            });

            modelBuilder.Entity<Lpu>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.ToTable("LPU");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.HasOne(d => d.DistrictNavigation)
                    .WithMany(p => p.Lpu)
                    .HasForeignKey(d => d.District)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LPU_Districts");
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.ToTable("Marital_status");

                entity.Property(e => e.MaritalStatus1)
                    .HasColumnName("Marital_status")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Nationalities>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.Property(e => e.Number).ValueGeneratedOnAdd();

                entity.Property(e => e.Code).HasMaxLength(3);

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Obrazovanie>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Oplata>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OtchetGruppaVypolneno>(entity =>
            {
                entity.HasKey(e => e.Nom)
                    .HasName("PK_ОтчетГруппаВыполнено");

                entity.Property(e => e.Группа)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.До).HasColumnType("smalldatetime");

                entity.Property(e => e.Курс)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Лк).HasDefaultValueSql("((0))");

                entity.Property(e => e.Мр)
                    .HasColumnName("МР")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.От).HasColumnType("smalldatetime");

                entity.Property(e => e.Пр).HasDefaultValueSql("((0))");

                entity.Property(e => e.Преподаватель)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Nom).ValueGeneratedOnAdd();

                entity.Property(e => e.Post)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PovyshenieKategorii>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.ToTable("Povyshenie_kategorii");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.HasOne(d => d.KategoriyaNavigation)
                    .WithMany(p => p.PovyshenieKategorii)
                    .HasForeignKey(d => d.Kategoriya)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Povyshenie_kategorii_Kategoriya");

                entity.HasOne(d => d.SpecNavigation)
                    .WithMany(p => p.PovyshenieKategorii)
                    .HasForeignKey(d => d.Spec)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Povyshenie_kategorii_glb_S_spec");

                entity.HasOne(d => d.StudentNavigation)
                    .WithMany(p => p.PovyshenieKategorii)
                    .HasForeignKey(d => d.Student)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Povyshenie_kategorii_Students");
            });

            modelBuilder.Entity<PovyshenieKvalifikatsii>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.ToTable("Povyshenie_kvalifikatsii");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Mesto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.HasOne(d => d.StudentNavigation)
                    .WithMany(p => p.PovyshenieKvalifikatsii)
                    .HasForeignKey(d => d.Student)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Povyshenie_kvalifikatsii_Students");
            });

            modelBuilder.Entity<Prisutstvie>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.HasIndex(e => new { e.Student, e.Lexture })
                    .HasName("IX_Prisutstvie")
                    .IsUnique();

                entity.Property(e => e.Prim)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Prisutstvie1)
                    .IsRequired()
                    .HasColumnName("Prisutstvie")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('+')");

                entity.HasOne(d => d.LextureNavigation)
                    .WithMany(p => p.Prisutstvie)
                    .HasForeignKey(d => d.Lexture)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prisutstvie_Lextures");

                entity.HasOne(d => d.StudentNavigation)
                    .WithMany(p => p.Prisutstvie)
                    .HasForeignKey(d => d.Student)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prisutstvie_Students");
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.Country)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Regions_Countries");
            });

            modelBuilder.Entity<ScientificDegree>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.ToTable("Scientific_degree");

                entity.Property(e => e.Nom).ValueGeneratedOnAdd();

                entity.Property(e => e.ScientificDegree1)
                    .HasColumnName("Scientific_degree")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Settlements>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Ter3Id).HasColumnName("ter3_id");

                entity.HasOne(d => d.Ter3)
                    .WithMany(p => p.Settlements)
                    .HasForeignKey(d => d.Ter3Id)
                    .HasConstraintName("FK_Settlements_Districts");
            });

            modelBuilder.Entity<Sex>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Sex1)
                    .IsRequired()
                    .HasColumnName("Sex")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SkPerson>(entity =>
            {
                entity.ToTable("Sk_person");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateReg)
                    .HasColumnName("date_reg")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateSwp)
                    .HasColumnName("date_swp")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateUpd)
                    .HasColumnName("date_upd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MidName)
                    .HasColumnName("mid_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OblPersId).HasColumnName("obl_pers_id");

                entity.Property(e => e.RecStatus).HasColumnName("rec_status");

                entity.Property(e => e.SexId).HasColumnName("sex_id");

                entity.Property(e => e.SwpLpuId).HasColumnName("swp_lpu_id");

                entity.Property(e => e.Uin).HasColumnName("uin");

                entity.Property(e => e.Uin2)
                    .HasColumnName("uin2")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserUpd)
                    .IsRequired()
                    .HasColumnName("user_upd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.StafTypeCodeNavigation)
                    .WithMany(p => p.SkPerson)
                    .HasForeignKey(d => d.StafTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sk_person_glb_S_staff_type");
            });

            modelBuilder.Entity<SkSkillCategory>(entity =>
            {
                entity.ToTable("Sk_skill_category");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddComent)
                    .HasColumnName("add_coment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssignDate)
                    .HasColumnName("assign_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.AttestDate)
                    .HasColumnName("attest_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateSwp)
                    .HasColumnName("date_swp")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateUpd)
                    .HasColumnName("date_upd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdNew).HasColumnName("ID_New");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OrderNumb)
                    .HasColumnName("order_numb")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PersId).HasColumnName("pers_id");

                entity.Property(e => e.RecStatus).HasColumnName("rec_status");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.SpecCode).HasColumnName("spec_code");

                entity.Property(e => e.SwpLpuId).HasColumnName("swp_lpu_id");

                entity.Property(e => e.UserUpd)
                    .IsRequired()
                    .HasColumnName("user_upd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.SkSkillCategory)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sk_skill_category_glb_S_skill_category_status");

                entity.HasOne(d => d.SpecCodeNavigation)
                    .WithMany(p => p.SkSkillCategory)
                    .HasForeignKey(d => d.SpecCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sk_skill_category_glb_S_spec");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.Property(e => e.AddressStudent).HasMaxLength(80);

                entity.Property(e => e.BirthPlace)
                    .HasColumnName("birth_place")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateBorn).HasColumnType("smalldatetime");

                entity.Property(e => e.GodOkoncaniya).HasColumnName("God_okoncaniya");

                entity.Property(e => e.HPhone).HasColumnName("h_phone");

                entity.Property(e => e.IdNumber)
                    .HasColumnName("ID_Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname).HasMaxLength(25);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Sk).HasColumnName("SK");

                entity.Property(e => e.Specialnost)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.StagObsh).HasColumnName("Stag_obsh");

                entity.Property(e => e.StagPoSpec).HasColumnName("Stag_po_spec");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Tmp).HasColumnName("tmp");

                entity.Property(e => e.Vuz)
                    .HasColumnName("VUZ")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.WPhone).HasColumnName("w_phone");

                entity.HasOne(d => d.DistrictNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.District)
                    .HasConstraintName("FK_Students_Districts");

                entity.HasOne(d => d.GrupNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Grup)
                    .HasConstraintName("FK_Students_Groups");

                entity.HasOne(d => d.HeadNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Head)
                    .HasConstraintName("FK_Students_Heads");

                entity.HasOne(d => d.NationalityNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Nationality)
                    .HasConstraintName("FK_Students_glb_P_nation");

                entity.HasOne(d => d.ObrazovanieNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Obrazovanie)
                    .HasConstraintName("FK_Students_glb_S_staff_type");

                entity.HasOne(d => d.PostNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Post)
                    .HasConstraintName("FK_Students_Posts");

                entity.HasOne(d => d.SettlementNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Settlement)
                    .HasConstraintName("FK_Students_Settlements");

                entity.HasOne(d => d.SexNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Sex)
                    .HasConstraintName("FK_Students_Sex");

                entity.HasOne(d => d.UchregdenieNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Uchregdenie)
                    .HasConstraintName("FK_Students_LPU");
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Faculty).HasDefaultValueSql("((2))");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("FIO")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Prim)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK_Teachers_Departments");

                entity.HasOne(d => d.FacultyNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.Faculty)
                    .HasConstraintName("FK_Teachers_Faculties");
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BirthPlace)
                    .HasColumnName("birth_place")
                    .HasMaxLength(50);

                entity.Property(e => e.CharUin)
                    .HasColumnName("char_uin")
                    .HasMaxLength(20);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(100);

                entity.Property(e => e.DateSwp)
                    .HasColumnName("date_swp")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateUpd)
                    .HasColumnName("date_upd")
                    .HasColumnType("datetime");

                entity.Property(e => e.EduclevId).HasColumnName("educlev_id");

                entity.Property(e => e.FamstatId).HasColumnName("famstat_id");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(15);

                entity.Property(e => e.HPhone).HasColumnName("h_phone");

                entity.Property(e => e.HouseBuilding).HasColumnName("house_building");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsQuit).HasColumnName("is_quit");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(30);

                entity.Property(e => e.LivcondId).HasColumnName("livcond_id");

                entity.Property(e => e.MStartDate)
                    .HasColumnName("m_start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MidName)
                    .HasColumnName("mid_name")
                    .HasMaxLength(30);

                entity.Property(e => e.NationId).HasColumnName("nation_id");

                entity.Property(e => e.OblPersId).HasColumnName("obl_pers_id");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("image");

                entity.Property(e => e.RecStatus).HasColumnName("rec_status");

                entity.Property(e => e.RepPersId).HasColumnName("rep_pers_id");

                entity.Property(e => e.SexId).HasColumnName("sex_id");

                entity.Property(e => e.SubsidiaryWork).HasColumnName("subsidiary_work");

                entity.Property(e => e.SwpLpuId).HasColumnName("swp_lpu_id");

                entity.Property(e => e.Ter2Id).HasColumnName("ter2_id");

                entity.Property(e => e.Ter3Id).HasColumnName("ter3_id");

                entity.Property(e => e.Ter5Id).HasColumnName("ter5_id");

                entity.Property(e => e.Uin)
                    .HasColumnName("uin")
                    .HasMaxLength(255);

                entity.Property(e => e.UserUpd)
                    .HasColumnName("user_upd")
                    .HasMaxLength(20);

                entity.Property(e => e.WPhone).HasColumnName("w_phone");

                entity.Property(e => e.WStartDate)
                    .HasColumnName("w_start_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Temy>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tests>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.HasIndex(e => new { e.Discipline, e.Student, e.Course })
                    .HasName("IX_Tests")
                    .IsUnique();

                entity.Property(e => e.PosttestPract).HasColumnName("Posttest_pract");

                entity.Property(e => e.PosttestTeor).HasColumnName("Posttest_teor");

                entity.HasOne(d => d.CourseNavigation)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.Course)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tests_Courses");

                entity.HasOne(d => d.DisciplineNavigation)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.Discipline)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tests_Disciplines");

                entity.HasOne(d => d.StudentNavigation)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.Student)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tests_Students");
            });

            modelBuilder.Entity<TmpSPerson>(entity =>
            {
                entity.ToTable("tmp_s_person");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BirthPlace)
                    .HasColumnName("birth_place")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CharUin)
                    .HasColumnName("char_uin")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateSwp)
                    .HasColumnName("date_swp")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateUpd)
                    .HasColumnName("date_upd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EduclevId).HasColumnName("educlev_id");

                entity.Property(e => e.FamstatId).HasColumnName("famstat_id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HPhone).HasColumnName("h_phone");

                entity.Property(e => e.HouseBuilding).HasColumnName("house_building");

                entity.Property(e => e.IsQuit).HasColumnName("is_quit");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LivcondId).HasColumnName("livcond_id");

                entity.Property(e => e.MStartDate)
                    .HasColumnName("m_start_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MidName)
                    .HasColumnName("mid_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NationId).HasColumnName("nation_id");

                entity.Property(e => e.OblPersId).HasColumnName("obl_pers_id");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("image");

                entity.Property(e => e.RecStatus).HasColumnName("rec_status");

                entity.Property(e => e.RepPersId).HasColumnName("rep_pers_id");

                entity.Property(e => e.SexId).HasColumnName("sex_id");

                entity.Property(e => e.Sk).HasColumnName("SK");

                entity.Property(e => e.SubsidiaryWork).HasColumnName("subsidiary_work");

                entity.Property(e => e.SwpLpuId).HasColumnName("swp_lpu_id");

                entity.Property(e => e.Ter2Id).HasColumnName("ter2_id");

                entity.Property(e => e.Ter3Id).HasColumnName("ter3_id");

                entity.Property(e => e.Ter5Id).HasColumnName("ter5_id");

                entity.Property(e => e.Uin).HasColumnName("uin");

                entity.Property(e => e.UserUpd)
                    .HasColumnName("user_upd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WPhone).HasColumnName("w_phone");

                entity.Property(e => e.WStartDate)
                    .HasColumnName("w_start_date")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Tsikly>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Nom).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UchregdenieName>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.ToTable("Uchregdenie_Name");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VidZan>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.ToTable("Vid_Zan");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.VidZan1)
                    .IsRequired()
                    .HasColumnName("VidZan")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.Sk).HasColumnName("SK");
            });

            modelBuilder.Entity<View2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_2");

                entity.Property(e => e.AttestDate)
                    .HasColumnName("attest_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Catefory)
                    .IsRequired()
                    .HasColumnName("catefory")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateSwp)
                    .HasColumnName("date_swp")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lpu).HasColumnName("lpu");

                entity.Property(e => e.MidName)
                    .HasColumnName("mid_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OblPersId).HasColumnName("obl_pers_id");

                entity.Property(e => e.RecStatus).HasColumnName("rec_status");

                entity.Property(e => e.Spec)
                    .IsRequired()
                    .HasColumnName("spec")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecCode).HasColumnName("spec_code");

                entity.Property(e => e.SwpLpuId).HasColumnName("swp_lpu_id");

                entity.Property(e => e.Uin).HasColumnName("uin");

                entity.Property(e => e.ТипОбразования)
                    .IsRequired()
                    .HasColumnName("Тип образования")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewGurnal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Gurnal");

                entity.Property(e => e.Day).HasColumnType("smalldatetime");

                entity.Property(e => e.Teacher)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Thema)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.VidZan).HasColumnName("Vid_Zan");

                entity.Property(e => e._10Д)
                    .HasColumnName("10_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._10День)
                    .HasColumnName("10_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._11Д)
                    .HasColumnName("11_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._11День)
                    .HasColumnName("11_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._12Д)
                    .HasColumnName("12_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._12День)
                    .HasColumnName("12_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._13Д)
                    .HasColumnName("13_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._13День)
                    .HasColumnName("13_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._14Д)
                    .HasColumnName("14_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._14День)
                    .HasColumnName("14_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._15Д)
                    .HasColumnName("15_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._15День)
                    .HasColumnName("15_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._1Д)
                    .HasColumnName("1_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._1День)
                    .HasColumnName("1_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._2Д)
                    .HasColumnName("2_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._2День)
                    .HasColumnName("2_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._3Д)
                    .HasColumnName("3_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._3День)
                    .HasColumnName("3_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._4Д)
                    .HasColumnName("4_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._4День)
                    .HasColumnName("4_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._5Д)
                    .HasColumnName("5_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._5День)
                    .HasColumnName("5_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._6Д)
                    .HasColumnName("6_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._6День)
                    .HasColumnName("6_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._7Д)
                    .HasColumnName("7_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._7День)
                    .HasColumnName("7_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._8Д)
                    .HasColumnName("8_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._8День)
                    .HasColumnName("8_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._9Д)
                    .HasColumnName("9_д")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e._9День)
                    .HasColumnName("9_день")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ВидЗан)
                    .HasColumnName("Вид зан")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Группа).HasMaxLength(20);

                entity.Property(e => e.До).HasColumnType("smalldatetime");

                entity.Property(e => e.Курс)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.От).HasColumnType("smalldatetime");

                entity.Property(e => e.Слушатель).HasMaxLength(77);
            });

            modelBuilder.Entity<ViewRegionsOfKg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RegionsOfKg");

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ViewStudentsSvodZan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Students_Svod_Zan");

                entity.Property(e => e.Course).HasMaxLength(137);

                entity.Property(e => e.VidZan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViewSumHoursStud>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SumHoursStud");
            });

            modelBuilder.Entity<ViewВсеIdСПовторамиПоИнн>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Все_ID_с_повторами_по ИНН");

                entity.Property(e => e.CharUin)
                    .HasColumnName("char_uin")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ViewВсеIdСПовторамиПоФио>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Все_ID_с_повторами_по_ФИО");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ViewНеСовпадают>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Не_совпадают");

                entity.Property(e => e.Sk).HasColumnName("SK");
            });

            modelBuilder.Entity<ViewНеСовпадаютПоИнн>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Не_совпадают_по_ИНН");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateReg)
                    .HasColumnName("date_reg")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateSwp)
                    .HasColumnName("date_swp")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateUpd)
                    .HasColumnName("date_upd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MidName)
                    .HasColumnName("mid_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OblPersId).HasColumnName("obl_pers_id");

                entity.Property(e => e.RecStatus).HasColumnName("rec_status");

                entity.Property(e => e.SexId).HasColumnName("sex_id");

                entity.Property(e => e.SwpLpuId).HasColumnName("swp_lpu_id");

                entity.Property(e => e.Uin).HasColumnName("uin");

                entity.Property(e => e.Uin2)
                    .HasColumnName("uin2")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserUpd)
                    .IsRequired()
                    .HasColumnName("user_upd")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewОсновная>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Основная");

                entity.Property(e => e.ВидЗанятия)
                    .IsRequired()
                    .HasColumnName("Вид занятия")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Группа)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Дата).HasColumnType("smalldatetime");

                entity.Property(e => e.Курс).HasMaxLength(137);

                entity.Property(e => e.Преподаватель)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Прим)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Присутствовал)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Слушатель).HasMaxLength(77);

                entity.Property(e => e.Тема)
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViewПовторыSkPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Повторы_SK_Person");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MidName)
                    .HasColumnName("mid_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MinId).HasColumnName("Min_ID");
            });

            modelBuilder.Entity<ViewПовторыSkПоИнн>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Повторы_SK_по_ИНН");

                entity.Property(e => e.MinId).HasColumnName("Min_ID");

                entity.Property(e => e.Uin2)
                    .HasColumnName("uin2")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ViewПовторыTmpПоИнн>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Повторы_tmp_по_ИНН");

                entity.Property(e => e.CharUin)
                    .HasColumnName("char_uin")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MinId).HasColumnName("MIN_ID");
            });

            modelBuilder.Entity<ViewПовторыПоФио>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Повторы_по_ФИО");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MidName)
                    .HasColumnName("mid_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MinId).HasColumnName("Min_Id");
            });

            modelBuilder.Entity<ViewСовпадают>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Совпадают");

                entity.Property(e => e.Sk).HasColumnName("SK");
            });

            modelBuilder.Entity<ViewСовпадаютПоИнн>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Совпадают_по_ИНН");
            });

            modelBuilder.Entity<ViewСовпадаютПоФио>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Совпадают_по_ФИО");

                entity.Property(e => e.Sk).HasColumnName("SK");
            });

            modelBuilder.Entity<Year>(entity =>
            {
                entity.HasKey(e => e.Nom);

                entity.Property(e => e.Nom).ValueGeneratedOnAdd();

                entity.Property(e => e.Year1)
                    .IsRequired()
                    .HasColumnName("year")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<СводЗанятия>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Свод_занятия");

                entity.Property(e => e.ВидЗан)
                    .IsRequired()
                    .HasColumnName("Вид_зан")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Группа)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Дата).HasColumnType("smalldatetime");

                entity.Property(e => e.До)
                    .HasColumnName("до")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Курс)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Преподаватель)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Присутствовал)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.С)
                    .HasColumnName("с")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Слушатель).HasMaxLength(77);

                entity.Property(e => e.Тема)
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<СводМедперсонал>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Свод_медперсонал");

                entity.Property(e => e.Адрес).HasMaxLength(80);

                entity.Property(e => e.Вуз)
                    .HasColumnName("ВУЗ")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ГодОкончания).HasColumnName("Год окончания");

                entity.Property(e => e.Должность)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Инн)
                    .HasColumnName("ИНН")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Лпу)
                    .HasColumnName("ЛПУ")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.НасПункт)
                    .HasColumnName("Нас_пункт")
                    .HasMaxLength(255);

                entity.Property(e => e.Национальность)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Область).HasMaxLength(30);

                entity.Property(e => e.Образование)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Пол).HasMaxLength(10);

                entity.Property(e => e.Район).HasMaxLength(30);

                entity.Property(e => e.Специальность)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.СтажОбщий).HasColumnName("Стаж общий");

                entity.Property(e => e.СтажПоСпец).HasColumnName("Стаж по спец");

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasMaxLength(77);
            });

            modelBuilder.Entity<СводТест>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Свод_тест");

                entity.Property(e => e.Дисциплина)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Курс).HasMaxLength(137);

                entity.Property(e => e.ПосттестПрактика).HasColumnName("Посттест_практика");

                entity.Property(e => e.ПосттестТеория).HasColumnName("Посттест_теория");

                entity.Property(e => e.Слушатель).HasMaxLength(77);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}