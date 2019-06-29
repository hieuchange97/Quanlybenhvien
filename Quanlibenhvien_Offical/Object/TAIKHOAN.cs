namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [StringLength(20)]
        public string IDtk { get; set; }

        [StringLength(20)]
        public string Tendn { get; set; }

        [StringLength(20)]
        public string Matkhau { get; set; }

        [StringLength(20)]
        public string IDnv { get; set; }

        [StringLength(20)]
        public string IDquyen { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHANQUYEN PHANQUYEN { get; set; }
    }
}
