namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIM")]
    public partial class SIM
    {
        

        [Key]
        [StringLength(10)]
        public string MASIM { get; set; }

        [StringLength(10)]
        public string MALOAI { get; set; }

        [StringLength(10)]
        public string MANM { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        public int? GIA { get; set; }

        
    }
}
