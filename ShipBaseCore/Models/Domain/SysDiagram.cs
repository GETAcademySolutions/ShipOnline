using System.ComponentModel.DataAnnotations;

namespace ShipBaseCore.Models.Domain
{
    public partial class SysDiagram
    {
        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public int principal_id { get; set; }

        [Key]
        public int diagram_id { get; set; }

        public int? version { get; set; }

        public byte[] definition { get; set; }
    }
}
