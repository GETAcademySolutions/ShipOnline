using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.Domain
{
    public partial class Nyinsu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROWID { get; set; }

        [StringLength(8)]
        public string LAST_LOGIN { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LAST_LOGIN_DATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LAST_LOGIN_TIME { get; set; }

        [StringLength(40)]
        public string NAME { get; set; }

        [StringLength(10)]
        public string COMPANY_ID { get; set; }

        [StringLength(20)]
        public string USERNAME { get; set; }

        [StringLength(20)]
        public string PASSWORD { get; set; }

        [StringLength(20)]
        public string BOOKS { get; set; }

        public int? USER_COUNT { get; set; }

        [StringLength(1)]
        public string SUPERUSER { get; set; }

        public int? LEVEL { get; set; }

        [StringLength(8)]
        public string EXPIRES { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EXPIRES_DATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EXPIRES_TIME { get; set; }
    }
}
