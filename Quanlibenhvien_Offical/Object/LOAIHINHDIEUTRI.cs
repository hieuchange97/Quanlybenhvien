namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIHINHDIEUTRI")]
    public partial class LOAIHINHDIEUTRI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIHINHDIEUTRI()
        {
            BENHANs = new HashSet<BENHAN>();
        }

        [Key]
        [StringLength(20)]
        public string IDloaihinh { get; set; }

        [StringLength(50)]
        public string tenloaihinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BENHAN> BENHANs { get; set; }
    }
}
