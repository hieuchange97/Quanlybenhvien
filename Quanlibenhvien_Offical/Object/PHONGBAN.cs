namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONGBAN")]
    public partial class PHONGBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONGBAN()
        {
            BENHNHANLAMVIECs = new HashSet<BENHNHANLAMVIEC>();
            NHANVIENLAMVIECs = new HashSet<NHANVIENLAMVIEC>();
            PHIEUXETNGHIEMs = new HashSet<PHIEUXETNGHIEM>();
            PHONGBAN1 = new HashSet<PHONGBAN>();
            PHONGBANDICHVUs = new HashSet<PHONGBANDICHVU>();
        }

        [Key]
        [StringLength(20)]
        public string IDpb { get; set; }

        [StringLength(30)]
        public string Tenpb { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }

        [StringLength(50)]
        public string Nhiemvu { get; set; }

        [StringLength(20)]
        public string IDpbCha { get; set; }

        [StringLength(20)]
        public string IDkhoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BENHNHANLAMVIEC> BENHNHANLAMVIECs { get; set; }

        public virtual KHOA KHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIENLAMVIEC> NHANVIENLAMVIECs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUXETNGHIEM> PHIEUXETNGHIEMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONGBAN> PHONGBAN1 { get; set; }

        public virtual PHONGBAN PHONGBAN2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONGBANDICHVU> PHONGBANDICHVUs { get; set; }
    }
}
