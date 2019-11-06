using System;

namespace KGMIPiPK
{
    public partial class ViewНеСовпадаютПоИнн
    {
        public int Id { get; set; }
        public long? Uin { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int? SexId { get; set; }
        public int? OblPersId { get; set; }
        public int? SwpLpuId { get; set; }
        public DateTime? DateSwp { get; set; }
        public string UserUpd { get; set; }
        public DateTime DateUpd { get; set; }
        public byte RecStatus { get; set; }
        public byte StafTypeCode { get; set; }
        public DateTime? DateReg { get; set; }
        public int? Country { get; set; }
        public string Uin2 { get; set; }
    }
}