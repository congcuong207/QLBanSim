namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAISIM")]
    public partial class LOAISIM
    {
     public LOAISIM()
        {
        }

        [Key]
        [StringLength(10)]
        public string MALOAI { get; set; }

        [StringLength(50)]
        public string TENLOAI { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

    }
}
