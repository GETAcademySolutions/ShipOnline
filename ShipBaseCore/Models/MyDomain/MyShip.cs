using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShipBaseCore.Models.Domain;

namespace ShipBaseCore.Models.MyDomain
{
    [Table("myship")]
    public partial class MyShip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MyShip()
        {
            myshipcontacts = new HashSet<MyShipContact>();
            myshipremarks = new HashSet<MyShipRemark>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long unikid { get; set; }

        [Required]
        [StringLength(50)]
        public string usercompanyid { get; set; }

        [Required]
        [StringLength(50)]
        public string rekno { get; set; }

        [Required]
        [StringLength(50)]
        public string insvesselid { get; set; }

        [StringLength(50)]
        public string vesselname { get; set; }

        [StringLength(3)]
        public string nation_id { get; set; }

        [StringLength(50)]
        public string imono { get; set; }

        [StringLength(50)]
        public string mmsino { get; set; }

        [StringLength(10)]
        public string area_id { get; set; }

        [StringLength(10)]
        public string merke_nr { get; set; }

        public virtual Area area { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyShipContact> myshipcontacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyShipRemark> myshipremarks { get; set; }
    }
}
