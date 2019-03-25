using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.Domain
{
    [Table("shipcat")]
    public partial class ShipCat
    {
        [StringLength(25)]
        public string ID { get; set; }

        [StringLength(1)]
        public string PUB_INTERNET { get; set; }
    }
}
