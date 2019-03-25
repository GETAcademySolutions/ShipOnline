using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.Domain
{
    [Table("compnos")]
    public partial class CompNo
    {
        [Column(Order = 0)]
        [StringLength(10)]
        public string COMPANY_ID { get; set; }

        [Column(Order = 1)]
        [StringLength(30)]
        public string DESCRIPTION { get; set; }

        [StringLength(20)]
        public string NUMBER { get; set; }

        public virtual Company company { get; set; }
    }
}
