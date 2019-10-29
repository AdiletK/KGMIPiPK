using System;
using System.Collections.Generic;

namespace KGMIPiPK
{
    public partial class Temp
    {
        public int? Id { get; set; }
        public string Uin { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public byte? Ter2Id { get; set; }
        public short? Ter3Id { get; set; }
        public short? Ter5Id { get; set; }
        public string Address { get; set; }
        public byte? SexId { get; set; }
        public int? NationId { get; set; }
        public byte? FamstatId { get; set; }
        public short? EduclevId { get; set; }
        public byte? LivcondId { get; set; }
        public bool HouseBuilding { get; set; }
        public bool SubsidiaryWork { get; set; }
        public DateTime? WStartDate { get; set; }
        public DateTime? MStartDate { get; set; }
        public int? WPhone { get; set; }
        public int? HPhone { get; set; }
        public byte[] Photo { get; set; }
        public bool IsQuit { get; set; }
        public string Comment { get; set; }
        public int? OblPersId { get; set; }
        public int? RepPersId { get; set; }
        public int? SwpLpuId { get; set; }
        public DateTime? DateSwp { get; set; }
        public string UserUpd { get; set; }
        public DateTime? DateUpd { get; set; }
        public byte? RecStatus { get; set; }
        public string CharUin { get; set; }
    }
}
