namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BHYT")]
    public partial class BHYT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BHYT()
        {
            GIAYCHUYENVIENs = new HashSet<GIAYCHUYENVIEN>();
        }

        [Key]
        [StringLength(20)]
        public string IDbhyt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaycap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngayhethan { get; set; }

        [StringLength(100)]
        public string Csbd { get; set; }

        [StringLength(20)]
        public string IDtuyen { get; set; }

        public int? DTUT { get; set; }

        [StringLength(20)]
        public string IDbn { get; set; }

        public int? IDdt { get; set; }

        public virtual BENHNHAN BENHNHAN { get; set; }

        public virtual DTUT DTUT1 { get; set; }

        public virtual TUYENBHYT TUYENBHYT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAYCHUYENVIEN> GIAYCHUYENVIENs { get; set; }
    }
}
