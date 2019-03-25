using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.Domain
{
    [Table("county")]
    public partial class County
    {
        [StringLength(4)]
        public string ID { get; set; }

        [StringLength(30)]
        public string NAME { get; set; }

        [StringLength(30)]
        public string SHIRE { get; set; }
    }
}
