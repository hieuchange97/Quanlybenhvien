namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONTHUOC")]
    public partial class DONTHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONTHUOC()
        {
            CHITIETDONTHUOCs = new HashSet<CHITIETDONTHUOC>();
        }

        [Key]
        [StringLength(20)]
        public string IDdonthuoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaylap { get; set; }

        [StringLength(20)]
        public string IDba { get; set; }

        [StringLength(20)]
        public string IDnv { get; set; }

        public int? Thanhtien { get; set; }

        public virtual BENHAN BENHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONTHUOC> CHITIETDONTHUOCs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
