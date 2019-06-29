namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAYCHUYENVIEN")]
    public partial class GIAYCHUYENVIEN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string IDgcv { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string IDbhyt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaycap { get; set; }

        [StringLength(100)]
        public string Chuandoan { get; set; }

        [StringLength(100)]
        public string lydochuyen { get; set; }

        [StringLength(100)]
        public string Noicap { get; set; }

        [StringLength(50)]
        public string Nguoicap { get; set; }

        public virtual BHYT BHYT { get; set; }
    }
}
