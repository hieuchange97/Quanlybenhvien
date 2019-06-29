namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BENHAN")]
    public partial class BENHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BENHAN()
        {
            BENHNHANLAMVIECs = new HashSet<BENHNHANLAMVIEC>();
            DONTHUOCs = new HashSet<DONTHUOC>();
            PHIEUHENKHAMLAIs = new HashSet<PHIEUHENKHAMLAI>();
            PHIEUKHAMBENHs = new HashSet<PHIEUKHAMBENH>();
            PHIEUTHANHTOANXNKTs = new HashSet<PHIEUTHANHTOANXNKT>();
        }

        [Key]
        [StringLength(20)]
        public string IDba { get; set; }

        public DateTime? Ngaylap { get; set; }

        public DateTime? Ngaybangiao { get; set; }

        [StringLength(20)]
        public string IDloaihinh { get; set; }

        [Required]
        [StringLength(20)]
        public string IDbn { get; set; }

        public virtual BENHNHAN BENHNHAN { get; set; }

        public virtual LOAIHINHDIEUTRI LOAIHINHDIEUTRI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BENHNHANLAMVIEC> BENHNHANLAMVIECs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONTHUOC> DONTHUOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUHENKHAMLAI> PHIEUHENKHAMLAIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKHAMBENH> PHIEUKHAMBENHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHANHTOANXNKT> PHIEUTHANHTOANXNKTs { get; set; }
    }
}
