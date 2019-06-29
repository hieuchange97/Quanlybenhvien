namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIPHIEUXETNGHIEM")]
    public partial class LOAIPHIEUXETNGHIEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIPHIEUXETNGHIEM()
        {
            PHIEUXETNGHIEMs = new HashSet<PHIEUXETNGHIEM>();
        }

        [Key]
        [StringLength(20)]
        public string IDloai { get; set; }

        [StringLength(100)]
        public string Tenloai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUXETNGHIEM> PHIEUXETNGHIEMs { get; set; }
    }
}
