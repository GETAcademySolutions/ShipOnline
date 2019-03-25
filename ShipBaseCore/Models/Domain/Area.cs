using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShipBaseCore.Models.MyDomain;

namespace ShipBaseCore.Models.Domain
{
    [Table("area")]
    public partial class Area
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Area()
        {
            MyShips = new HashSet<MyShip>();
        }

        [Column(Order = 0)]
        [StringLength(10)]
        public string Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Column(Order = 1)]
        [StringLength(3)]
        public string NationId { get; set; }

        [StringLength(4)]
        public string CountyId { get; set; }

        [StringLength(30)]
        public string Shire { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyShip> MyShips { get; set; }
    }
}
