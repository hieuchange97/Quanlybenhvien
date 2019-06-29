namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONGBANDICHVU")]
    public partial class PHONGBANDICHVU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string IDpb { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string IDdichvu { get; set; }

        [StringLength(50)]
        public string ghichu { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }
    }
}
