using DAL.Utils;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        public int Them(KHACHHANG kh)
        {
            string query =
                $"INSERT INTO KHACHHANG( MAKH,  TENKH,DIACHI,SDT)VALUES('{kh.MAKH}', N'{kh.TENKH}', N'{kh.DIACHI}','{kh.SDT}')";
            return DBHelper.NonQuery(query, null);
        }
        public int Sua(KHACHHANG kh)
        {
            string query =
                $"UPDATE KHACHHANG SET  TENKH = N'{kh.TENKH}', DIACHI=N'{kh.DIACHI}',SDT='{kh.SDT}' WHERE MAKH='{kh.MAKH}'";
            return DBHelper.NonQuery(query, null);
        }
        public int Xoa(string id)
        {
            string query = $"DELETE FROM KHACHHANG where MAKH = '{id}'";
            return DBHelper.NonQuery(query, null);
        }
        public List<KHACHHANG> LayDSKhachHang()
        {
            List<KHACHHANG> kHACHHANGs = new List<KHACHHANG>();
            string query = "select * from KHACHHANG";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                KHACHHANG khachhang = new KHACHHANG()
                {
                    MAKH = row["MAKH"] as string,
   
                    TENKH = row["TENKH"] as string,
                    DIACHI = row["DIACHI"] as string,
                    SDT = row["SDT"] as string
                };
                kHACHHANGs.Add(khachhang);
            }

            return kHACHHANGs;
        }
        public KHACHHANG LayDSKhachHang(string id)
        {
            KHACHHANG khachhang = new KHACHHANG();
            string query = $"select * from KHACHHANG where MAKH = '{id}'";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                khachhang = new KHACHHANG()
                {
                    MAKH = row["MAKH"] as string,
       
                    TENKH = row["TENKH"] as string,
                    DIACHI = row["DIACHI"] as string,
                    SDT = row["SDT"] as string
                };
            }

            return khachhang;
        }

    }
} 
