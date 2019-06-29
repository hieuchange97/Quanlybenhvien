namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHANHTOANXNKT")]
    public partial class PHIEUTHANHTOANXNKT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTHANHTOANXNKT()
        {
            PHIEUXETNGHIEMs = new HashSet<PHIEUXETNGHIEM>();
        }

        [Key]
        [StringLength(20)]
        public string IDpttxn { get; set; }

        [StringLength(20)]
        public string IDdichvu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaylap { get; set; }

        public TimeSpan? giolap { get; set; }

        public bool? trangthaitt { get; set; }

        [StringLength(50)]
        public string phantramgiam { get; set; }

        [StringLength(20)]
        public string IDnv { get; set; }

        [StringLength(20)]
        public string IDba { get; set; }

        [StringLength(20)]
        public string IDbnlv { get; set; }

        [StringLength(20)]
        public string IDnvthungan { get; set; }

        public bool? trangthaiXN { get; set; }

        public virtual BENHAN BENHAN { get; set; }

        public virtual BENHNHANLAMVIEC BENHNHANLAMVIEC { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual NHANVIEN NHANVIEN1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUXETNGHIEM> PHIEUXETNGHIEMs { get; set; }
    }
}
