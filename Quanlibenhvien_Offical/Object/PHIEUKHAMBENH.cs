namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUKHAMBENH")]
    public partial class PHIEUKHAMBENH
    {
        [Key]
        [StringLength(20)]
        public string IDpk { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaylap { get; set; }

        public TimeSpan? giolap { get; set; }

        [StringLength(50)]
        public string Nhiptim { get; set; }

        [StringLength(50)]
        public string Nhiptho { get; set; }

        [StringLength(50)]
        public string Huyetap { get; set; }

        [StringLength(50)]
        public string Nhietdo { get; set; }

        [StringLength(50)]
        public string Cacbophan { get; set; }

        [StringLength(100)]
        public string Tieusubenh { get; set; }

        public bool? CLS { get; set; }

        [StringLength(100)]
        public string ChuandoanCLS { get; set; }

        [StringLength(1000)]
        public string Ketluan { get; set; }

        [StringLength(1000)]
        public string Xuly { get; set; }

        [Required]
        [StringLength(20)]
        public string IDba { get; set; }

        [StringLength(20)]
        public string IDnv { get; set; }

        public virtual BENHAN BENHAN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
