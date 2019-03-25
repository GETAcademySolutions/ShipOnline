using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.Domain
{
    [Table("undept")]
    public partial class Undept
    {
        [StringLength(10)]
        public string COMPANY_NO { get; set; }

        [Column(Order = 0)]
        [StringLength(20)]
        public string USER_NAME { get; set; }

        [Column(Order = 1)]
        [StringLength(20)]
        public string PASSWORD { get; set; }

        public int? INTNO { get; set; }

        public int? USER_NO { get; set; }

        [StringLength(60)]
        public string EMAILADRESS { get; set; }

        [StringLength(20)]
        public string MOB_PHONE { get; set; }

        [StringLength(20)]
        public string TELEPHONE { get; set; }

        [StringLength(20)]
        public string ACTIVE_PASSIV { get; set; }

        [StringLength(20)]
        public string USER_F_NAME { get; set; }

        [StringLength(30)]
        public string USER_E_NAME { get; set; }

        public int? USER_REKNO { get; set; }

        public virtual Nydept nydept { get; set; }
    }
}
