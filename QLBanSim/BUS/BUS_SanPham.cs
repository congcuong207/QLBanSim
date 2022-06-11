using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_SanPham
    {
        private DAL_SanPham dal = new DAL_SanPham();
        public int Them(SIM sim)
        {
            int ketqua = dal.Them(sim);
            return ketqua;
        }
        public int Sua(SIM sim)
        {
            int ketqua = dal.Sua(sim);
            return ketqua;
        }
        public int Xoa(string id)
        {
            int ketqua = dal.Xoa(id);
            return ketqua;
        }
        public List<SIM> LayDSSim()
        {
            return dal.LayDSSim();
        }
        public SIM LayDSSim(string name)
        {
            return dal.LayDSSim(name);
        }
    }
}
