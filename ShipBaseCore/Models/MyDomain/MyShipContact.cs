using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.MyDomain
{
    public partial class MyShipContact
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long unikid { get; set; }

        [StringLength(50)]
        public string userid { get; set; }

        [StringLength(50)]
        public string rekno { get; set; }

        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long shipid { get; set; }

        [StringLength(50)]
        public string contactname { get; set; }

        [StringLength(50)]
        public string mobphone { get; set; }

        [StringLength(50)]
        public string telephone { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        public virtual MyShip MyShip { get; set; }
    }
}
