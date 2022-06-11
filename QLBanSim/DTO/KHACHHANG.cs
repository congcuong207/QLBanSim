namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
      public KHACHHANG()
        {
        }


        public string MAKH { get; set; }

        public string MASIM { get; set; }


        public string TENKH { get; set; }


        public string DIACHI { get; set; }


        public string SDT { get; set; }

    }
}
