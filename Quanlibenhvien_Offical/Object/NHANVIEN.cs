namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            DONTHUOCs = new HashSet<DONTHUOC>();
            KHOAs = new HashSet<KHOA>();
            NHANVIENLAMVIECs = new HashSet<NHANVIENLAMVIEC>();
            PHIEUHENKHAMLAIs = new HashSet<PHIEUHENKHAMLAI>();
            PHIEUKHAMBENHs = new HashSet<PHIEUKHAMBENH>();
            PHIEUTHANHTOANXNKTs = new HashSet<PHIEUTHANHTOANXNKT>();
            PHIEUTHANHTOANXNKTs1 = new HashSet<PHIEUTHANHTOANXNKT>();
            PHIEUXETNGHIEMs = new HashSet<PHIEUXETNGHIEM>();
            TAIKHOANs = new HashSet<TAIKHOAN>();
        }

        [Key]
        [StringLength(20)]
        public string IDnv { get; set; }

        [StringLength(30)]
        public string Hodem { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }

        public bool? Gioitinh { get; set; }

        [StringLength(12)]
        public string Sđt { get; set; }

        [StringLength(50)]
        public string Xaphuong { get; set; }

        [StringLength(50)]
        public string Quanhuyen { get; set; }

        [StringLength(50)]
        public string Tinhthanhpho { get; set; }

        [StringLength(20)]
        public string IDchucvu { get; set; }

        [StringLength(30)]
        public string Trinhdo { get; set; }

        [StringLength(10)]
        public string IDtk { get; set; }

        [StringLength(20)]
        public string IDkhoa { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONTHUOC> DONTHUOCs { get; set; }

        public virtual KHOA KHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOA> KHOAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIENLAMVIEC> NHANVIENLAMVIECs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUHENKHAMLAI> PHIEUHENKHAMLAIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKHAMBENH> PHIEUKHAMBENHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHANHTOANXNKT> PHIEUTHANHTOANXNKTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHANHTOANXNKT> PHIEUTHANHTOANXNKTs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUXETNGHIEM> PHIEUXETNGHIEMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
