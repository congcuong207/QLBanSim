namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANG")]
    public partial class DONHANG
    {
    public DONHANG()
        {
        }


        public string MADONHANG { get; set; }


        public string MAKH { get; set; }


        public string MANV { get; set; }

        public string NGAYMUA { get; set; }

    }
}
