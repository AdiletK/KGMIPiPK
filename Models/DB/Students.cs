using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KGMIPiPK
{
    public partial class Students
    {
        public Students()
        {
            GurnalPosesh1 = new HashSet<GurnalPosesh1>();
            PovyshenieKategorii = new HashSet<PovyshenieKategorii>();
            PovyshenieKvalifikatsii = new HashSet<PovyshenieKvalifikatsii>();
            Prisutstvie = new HashSet<Prisutstvie>();
            Tests = new HashSet<Tests>();
        }

        public int Number { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateBorn { get; set; }
        public byte? Sex { get; set; }
        public string IdNumber { get; set; }
        public int? Grup { get; set; }
        public int? Nationality { get; set; }
        public string AddressStudent { get; set; }
        public int? Settlement { get; set; }
        public short? Uchregdenie { get; set; }
        public byte? Post { get; set; }
        public byte? Head { get; set; }
        public byte? Obrazovanie { get; set; }
        public byte? StagObsh { get; set; }
        public byte? StagPoSpec { get; set; }
        public string Telefon { get; set; }
        public string Vuz { get; set; }
        public string Specialnost { get; set; }
        public short? GodOkoncaniya { get; set; }
        public int? District { get; set; }
        public string BirthPlace { get; set; }
        public int? Tmp { get; set; }
        public int? Sk { get; set; }
        public int? WPhone { get; set; }
        public int? HPhone { get; set; }

        public virtual Districts DistrictNavigation { get; set; }
        public virtual Groups GrupNavigation { get; set; }
        public virtual Heads HeadNavigation { get; set; }
        public virtual GlbPNation NationalityNavigation { get; set; }
        public virtual GlbSStaffType ObrazovanieNavigation { get; set; }
        public virtual Posts PostNavigation { get; set; }
        public virtual Settlements SettlementNavigation { get; set; }
        public virtual Sex SexNavigation { get; set; }
        public virtual Lpu UchregdenieNavigation { get; set; }
        public virtual ICollection<GurnalPosesh1> GurnalPosesh1 { get; set; }
        public virtual ICollection<PovyshenieKategorii> PovyshenieKategorii { get; set; }
        public virtual ICollection<PovyshenieKvalifikatsii> PovyshenieKvalifikatsii { get; set; }
        public virtual ICollection<Prisutstvie> Prisutstvie { get; set; }
        public virtual ICollection<Tests> Tests { get; set; }
    }
}