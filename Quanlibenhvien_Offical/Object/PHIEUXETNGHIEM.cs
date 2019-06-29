namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUXETNGHIEM")]
    public partial class PHIEUXETNGHIEM
    {
        [Key]
        [StringLength(20)]
        public string IDpxn { get; set; }

        [StringLength(500)]
        public string gan { get; set; }

        [StringLength(500)]
        public string mat { get; set; }

        [StringLength(500)]
        public string tuy { get; set; }

        [StringLength(500)]
        public string lach { get; set; }

        [StringLength(500)]
        public string hethongtietlieu { get; set; }

        [StringLength(500)]
        public string tuyentienliet { get; set; }

        [StringLength(100)]
        public string mota { get; set; }

        [StringLength(50)]
        public string ketluan { get; set; }

        [StringLength(20)]
        public string IDnv { get; set; }

        public DateTime? thoigianlap { get; set; }

        [StringLength(20)]
        public string IDpb { get; set; }

        [StringLength(20)]
        public string IDloai { get; set; }

        [Required]
        [StringLength(20)]
        public string IDpttxn { get; set; }

        public virtual LOAIPHIEUXETNGHIEM LOAIPHIEUXETNGHIEM { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHIEUTHANHTOANXNKT PHIEUTHANHTOANXNKT { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }
    }
}
