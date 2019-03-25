using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.Domain
{
    [Table("shipcomp")]
    public partial class ShipComp
    {
        [Column(Order = 0)]
        [StringLength(10)]
        public string COMPANY_ID { get; set; }

        [Column(Order = 1)]
        [StringLength(7)]
        public string SHIP_ID { get; set; }

        [Column(Order = 2)]
        [StringLength(2)]
        public string ROLE_ID { get; set; }

        [StringLength(50)]
        public string SHIP_NAME { get; set; }

        public virtual Company company { get; set; }

        public virtual Role role { get; set; }
    }
}
