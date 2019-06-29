namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIENLAMVIEC")]
    public partial class NHANVIENLAMVIEC
    {
        [Key]
        [StringLength(20)]
        public string IDnvlv { get; set; }

        [Required]
        [StringLength(20)]
        public string IDnv { get; set; }

        [Required]
        [StringLength(20)]
        public string IDpb { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Thoigianbatdau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Thoigianketthuc { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }
    }
}
