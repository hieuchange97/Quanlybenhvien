namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONTHUOC")]
    public partial class CHITIETDONTHUOC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string IDdonthuoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string IDthuoc { get; set; }

        [StringLength(20)]
        public string DVM { get; set; }

        public int? Soluong { get; set; }

        [StringLength(50)]
        public string Lieudung { get; set; }

        public virtual DONTHUOC DONTHUOC { get; set; }

        public virtual THUOC THUOC { get; set; }
    }
}
