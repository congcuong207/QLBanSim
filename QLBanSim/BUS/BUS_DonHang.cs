using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DonHang
    {
        private DAL_HoaDon dal = new DAL_HoaDon();

        public int Them(DONHANG dh)
        {
            int ketqua = dal.Them(dh);
            return ketqua;
        }
        public int Sua(DONHANG dh)
        {
            int ketqua = dal.Sua(dh);
            return ketqua;
        }
        public int Xoa(string id)
        {
            int ketqua = dal.Xoa(id);
            return ketqua;
        }
        public List<DONHANG> LayDSDonHang()
        {
            return dal.LayDSDonHang();
        }

        public DONHANG LayDSKhachHang(string id)
        {
            return dal.LayDSDonHang(id);
        }
    }
}
