namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHAMANG")]
    public partial class NHAMANG
    {
      public NHAMANG()
        {
        }


        public string MANM { get; set; }


        public string TENNM { get; set; }


        public string GHICHU { get; set; }
    }
}
