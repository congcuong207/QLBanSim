using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang dal = new DAL_KhachHang();
        public int Them(KHACHHANG kh)
        {
            int ketqua = dal.Them(kh);
            return ketqua;
        }
        public int Sua(KHACHHANG kh)
        {
            int ketqua = dal.Sua(kh);
            return ketqua;
        }
        public int Xoa(string id)
        {
            int ketqua = dal.Xoa(id);
            return ketqua;
        }
        public List<KHACHHANG> LayDSKhachHang()
        {
            return dal.LayDSKhachHang();
        }
        public KHACHHANG LayDSKhachHang(string id)
        {
            return dal.LayDSKhachHang(id);
        }
    }
}
