namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BENHNHANLAMVIEC")]
    public partial class BENHNHANLAMVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BENHNHANLAMVIEC()
        {
            PHIEUTHANHTOANXNKTs = new HashSet<PHIEUTHANHTOANXNKT>();
        }

        [Key]
        [StringLength(20)]
        public string IDbnlv { get; set; }

        [Required]
        [StringLength(20)]
        public string IDbn { get; set; }

        [StringLength(20)]
        public string IDpb { get; set; }

        [StringLength(20)]
        public string IDba { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaydk { get; set; }

        public TimeSpan giodk { get; set; }

        public int STT { get; set; }

        [StringLength(20)]
        public string IDtrangthai { get; set; }

        [StringLength(20)]
        public string IDnv { get; set; }

        public virtual BENHAN BENHAN { get; set; }

        public virtual BENHNHAN BENHNHAN { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }

        public virtual TRANGTHAILAMVIEC TRANGTHAILAMVIEC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHANHTOANXNKT> PHIEUTHANHTOANXNKTs { get; set; }
    }
}
