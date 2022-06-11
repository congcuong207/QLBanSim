namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        public NHANVIEN()
        {
        }


        public string MANV { get; set; }


        public string HOTEN { get; set; }

        public string NAMSINH { get; set; }


        public string GIOITINH { get; set; }

  
        public string DIACHI { get; set; }

    }
}
