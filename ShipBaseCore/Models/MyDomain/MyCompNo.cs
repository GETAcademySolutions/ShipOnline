using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.MyDomain
{
    [Table("mycompnos")]
    public partial class MyCompNo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MyCOMPANY_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string DESCRIPTION { get; set; }

        [StringLength(20)]
        public string NUMBER { get; set; }

        public long? int_no { get; set; }
    }
}
