namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BENHNHAN")]
    public partial class BENHNHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BENHNHAN()
        {
            BENHANs = new HashSet<BENHAN>();
            BENHNHANLAMVIECs = new HashSet<BENHNHANLAMVIEC>();
            BHYTs = new HashSet<BHYT>();
        }

        [Key]
        [StringLength(20)]
        public string IDbn { get; set; }

        [StringLength(30)]
        public string hodem { get; set; }

        [StringLength(30)]
        public string Ten { get; set; }

        public bool? gioitinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(15)]
        public string Sdt { get; set; }

        [StringLength(30)]
        public string Xaphuong { get; set; }

        [StringLength(30)]
        public string Quanhuyen { get; set; }

        [StringLength(30)]
        public string Tinhthanhpho { get; set; }

        [StringLength(50)]
        public string Nghenghiep { get; set; }

        [StringLength(15)]
        public string CMTND { get; set; }

        [StringLength(20)]
        public string Giaykhaisinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BENHAN> BENHANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BENHNHANLAMVIEC> BENHNHANLAMVIECs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BHYT> BHYTs { get; set; }
    }
}
