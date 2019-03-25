using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.Domain
{
    [Table("company")]
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            CompNos = new HashSet<CompNo>();
            Nydepts = new HashSet<Nydept>();
            ShipComps = new HashSet<ShipComp>();
        }

        [Key]
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(3)]
        public string FIRMAID { get; set; }

        [StringLength(65)]
        public string NAME { get; set; }

        [StringLength(20)]
        public string CUST_NO { get; set; }

        [StringLength(50)]
        public string ADDRESS { get; set; }

        [StringLength(50)]
        public string OFFICE { get; set; }

        [StringLength(50)]
        public string PLACE { get; set; }

        [StringLength(10)]
        public string POSTBOX_PNO { get; set; }

        [StringLength(30)]
        public string COUNTY { get; set; }

        [StringLength(25)]
        public string TELEPHONE { get; set; }

        [StringLength(25)]
        public string TELEFAX { get; set; }

        [StringLength(25)]
        public string TELEX { get; set; }

        [StringLength(25)]
        public string CABLE { get; set; }

        [StringLength(1)]
        public string YARD { get; set; }

        [StringLength(15)]
        public string FORETAKSNR { get; set; }

        public short? LABEL_COUNT { get; set; }

        [StringLength(3)]
        public string NATION_ID { get; set; }

        [StringLength(10)]
        public string PLACE_ID { get; set; }

        [StringLength(64)]
        public string WEBSITE { get; set; }

        [StringLength(65)]
        public string INT_NAME { get; set; }

        [StringLength(20)]
        public string PUBLISH_WEB { get; set; }

        [StringLength(1)]
        public string PUB_NEW_BUILD { get; set; }

        [StringLength(10)]
        public string NAME_ABBRIVATION { get; set; }

        [StringLength(60)]
        public string OFFICE2 { get; set; }

        public string MISC { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CompNo> CompNos { get; set; }
        public ICollection<CompNo> CompNos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Nydept> Nydepts { get; set; }
        public ICollection<Nydept> Nydepts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ShipComp> ShipComps { get; set; }
        public ICollection<ShipComp> ShipComps { get; set; }
    }
}
