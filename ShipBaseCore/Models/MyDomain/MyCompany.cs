using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.MyDomain
{
    [Table("mycompany")]
    public partial class MyCompany
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string inscompid { get; set; }

        [StringLength(50)]
        public string kompname { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string usrekno { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string uscompid { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long mycompany_id { get; set; }
    }
}
