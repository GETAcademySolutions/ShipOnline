using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.Domain
{
    [Table("nydept")]
    public partial class Nydept
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nydept()
        {
            undepts = new HashSet<Undept>();
        }

        [StringLength(10)]
        public string COMPANY_ID { get; set; }

        [StringLength(65)]
        public string COMP_NAME { get; set; }

        public int? NAR_ABONNENT { get; set; }

        public byte? ANT_EX { get; set; }

        [StringLength(30)]
        public string NAME { get; set; }

        [StringLength(3)]
        public string ABONNENTSTYP { get; set; }

        public int? VARENR { get; set; }

        [StringLength(30)]
        public string KONTAKTPERSO { get; set; }

        [StringLength(15)]
        public string REKNR { get; set; }

        [StringLength(15)]
        public string ORDRENR { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BETDATO { get; set; }

        public byte? LEVEL { get; set; }

        [StringLength(20)]
        public string BOOKS { get; set; }

        [StringLength(20)]
        public string USERNAME { get; set; }

        [StringLength(20)]
        public string PASSWORD { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AB_FRA_DATO { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AB_TIL_DATO { get; set; }

        [StringLength(60)]
        public string WEBADDRESS { get; set; }

        [StringLength(15)]
        public string MICRO80_NO { get; set; }

        [StringLength(8)]
        public string KATEGORI { get; set; }

        [StringLength(20)]
        public string SOLD_BY { get; set; }

        [StringLength(10)]
        public string FAKTURERT_AV_FIRMA { get; set; }

        public int? FAKTURA_NR { get; set; }

        [StringLength(20)]
        public string AKT_PASSIV { get; set; }

        [StringLength(8)]
        public string EXPIRES { get; set; }

        [StringLength(8)]
        public string EXPIRES_GROUP { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EXPIRES_DATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EXPIRES_TIME { get; set; }

        [StringLength(1)]
        public string SUPERUSER { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RECNO { get; set; }

        [StringLength(20)]
        public string MAINBOOK { get; set; }

        [StringLength(20)]
        public string PRI_WEB { get; set; }

        [StringLength(3)]
        public string PRIWEB_JN { get; set; }

        [StringLength(3)]
        public string PRIVATE_PIC { get; set; }

        [StringLength(3)]
        public string OFF_PIC { get; set; }

        public string REMARKS { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        public virtual Company company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Undept> undepts { get; set; }
    }
}
