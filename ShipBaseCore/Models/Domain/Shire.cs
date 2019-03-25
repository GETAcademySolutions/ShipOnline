using System.ComponentModel.DataAnnotations;

namespace ShipBaseCore.Models.Domain
{
    public partial class Shire
    {
        [Key]
        [StringLength(30)]
        public string SHIRE_NAME { get; set; }

        [StringLength(3)]
        public string NATION_ID { get; set; }
    }
}
