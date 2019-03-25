using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.MyDomain
{
    [Table("myadresstype")]
    public partial class MyAddressType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MyAddressType()
        {
            MyCompanyAdrs = new HashSet<MyCompanyAddr>();
        }

        [Key]
        [Column("myadresstype", TypeName = "numeric")]
        public decimal myadresstype1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyCompanyAddr> MyCompanyAdrs { get; set; }
    }
}
