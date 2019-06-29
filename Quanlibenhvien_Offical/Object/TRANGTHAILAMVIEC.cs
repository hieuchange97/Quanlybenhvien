namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRANGTHAILAMVIEC")]
    public partial class TRANGTHAILAMVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRANGTHAILAMVIEC()
        {
            BENHNHANLAMVIECs = new HashSet<BENHNHANLAMVIEC>();
        }

        [Key]
        [StringLength(20)]
        public string IDtrangthai { get; set; }

        [StringLength(50)]
        public string tentrangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BENHNHANLAMVIEC> BENHNHANLAMVIECs { get; set; }
    }
}
