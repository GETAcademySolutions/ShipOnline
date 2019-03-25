using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.MyDomain
{
    [Table("myshipremark")]
    public partial class MyShipRemark
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string userid { get; set; }

        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long rekno { get; set; }

        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long shipid { get; set; }

        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long remarkid { get; set; }

        [Column(Order = 4, TypeName = "date")]
        public DateTime regdate { get; set; }

        [Column(Order = 5)]
        [StringLength(50)]
        public string decription { get; set; }

        public string remarks { get; set; }

        public virtual MyShip MyShip { get; set; }
    }
}
