using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien {
        private DAL_NhanVien dal = new DAL_NhanVien();
        public int Them(NHANVIEN nhanvien)
        {
            int ketqua = dal.Them(nhanvien);
            return ketqua;
        }
        public int Sua(NHANVIEN nhanvien)
        {
            int ketqua = dal.Sua(nhanvien);
            return ketqua;
        }
        public int Xoa(string id)
        {
            int ketqua = dal.Xoa(id);
            return ketqua;
        }
        public List<NHANVIEN> LayDSNhanVIen()
        {
            return dal.LayDSNhanVien();
        }
    }
}
