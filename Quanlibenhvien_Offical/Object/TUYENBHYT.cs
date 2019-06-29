namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TUYENBHYT")]
    public partial class TUYENBHYT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TUYENBHYT()
        {
            BHYTs = new HashSet<BHYT>();
        }

        [Key]
        [StringLength(20)]
        public string IDtuyen { get; set; }

        [StringLength(50)]
        public string Tentuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BHYT> BHYTs { get; set; }
    }
}
