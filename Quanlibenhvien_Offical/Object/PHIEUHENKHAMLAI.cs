namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUHENKHAMLAI")]
    public partial class PHIEUHENKHAMLAI
    {
        [Key]
        [StringLength(20)]
        public string IDphieuhen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaylap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayhen { get; set; }

        [StringLength(20)]
        public string IDnv { get; set; }

        [StringLength(20)]
        public string IDba { get; set; }

        public virtual BENHAN BENHAN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
