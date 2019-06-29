namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUOC")]
    public partial class THUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUOC()
        {
            CHITIETDONTHUOCs = new HashSet<CHITIETDONTHUOC>();
        }

        [Key]
        [StringLength(20)]
        public string IDthuoc { get; set; }

        [StringLength(50)]
        public string Tenthuoc { get; set; }

        [StringLength(100)]
        public string Thanhphan { get; set; }

        [StringLength(50)]
        public string Luongdung { get; set; }

        [StringLength(20)]
        public string DVT { get; set; }

        public int? Dongia { get; set; }

        [StringLength(30)]
        public string Xuatxu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONTHUOC> CHITIETDONTHUOCs { get; set; }
    }
}
