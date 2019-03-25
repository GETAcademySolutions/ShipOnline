using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.Domain
{
    [Table("nation")]
    public partial class Nation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string ID { get; set; }

        [StringLength(30)]
        public string NAME { get; set; }

        [StringLength(4)]
        public string TEL_PREFIX { get; set; }

        [StringLength(4)]
        public string ADR_PREFIX { get; set; }

        [StringLength(2)]
        public string TOLLPREFIX { get; set; }

        [StringLength(20)]
        public string VALUTA { get; set; }

        [StringLength(5)]
        public string VALUTAKODE { get; set; }

        public double? EXCHANGE_FIRST { get; set; }

        [StringLength(3)]
        public string SEC_CURRENECY { get; set; }

        [StringLength(20)]
        public string SEC_DESC { get; set; }

        public double? EXCHANGE_RATE { get; set; }

        [StringLength(1)]
        public string POST_F_L { get; set; }

        [StringLength(3)]
        public string PUB_INTERNET { get; set; }

        [StringLength(30)]
        public string CAPITAL { get; set; }

        public int? POPULATION { get; set; }

        [StringLength(30)]
        public string SYSTEM_OF_GOVERMENT { get; set; }

        [StringLength(5)]
        public string CURRENCY { get; set; }

        [StringLength(30)]
        public string VERDENSDEL { get; set; }

        [StringLength(30)]
        public string UNDER_VERDEN { get; set; }

        [StringLength(20)]
        public string FLAGGKODE { get; set; }

        public short? NUMERIC_CODE { get; set; }

        [StringLength(2)]
        public string ID2 { get; set; }

        [StringLength(3)]
        public string ALIAS_ID { get; set; }

        [StringLength(30)]
        public string ALIAS_NAME { get; set; }

        public string REMARKS { get; set; }

        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
