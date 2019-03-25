using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.Domain
{
    [Table("place")]
    public partial class Place
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string NATION_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ID { get; set; }

        [StringLength(30)]
        public string NAME { get; set; }

        [StringLength(4)]
        public string COUNTY_ID { get; set; }
    }
}
