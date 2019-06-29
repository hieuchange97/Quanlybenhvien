namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOA")]
    public partial class KHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOA()
        {
            NHANVIENs = new HashSet<NHANVIEN>();
            PHONGBANs = new HashSet<PHONGBAN>();
        }

        [Key]
        [StringLength(20)]
        public string IDkhoa { get; set; }

        [StringLength(50)]
        public string Tenkhoa { get; set; }

        [StringLength(20)]
        public string IDtruongkhoa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaythanhlap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONGBAN> PHONGBANs { get; set; }
    }
}
