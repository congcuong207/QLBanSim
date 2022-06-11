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
    public class DAL_HoaDon
    {
        public int Them(DONHANG dh)
        {
            string query =
                $"	INSERT INTO DONHANG( MADONHANG, MAKH, MANV,NGAYMUA) VALUES('{dh.MADONHANG}', '{dh.MAKH}', '{dh.MANV}','{dh.NGAYMUA}')";
            return DBHelper.NonQuery(query, null);
        }
        public int Sua(DONHANG dh)
        {
            string query =
                $"UPDATE DONHANG SET MAKH = N'{dh.MAKH}', MANV = N'{dh.MANV}', NGAYMUA='{dh.NGAYMUA}' WHERE MADONHANG='{dh.MADONHANG}'";
            return DBHelper.NonQuery(query, null);
        }
        public int Xoa(string id)
        {
            string query = $"DELETE FROM DONHANG where MADONHANG = '{id}'";
            return DBHelper.NonQuery(query, null);
        }
        public List<DONHANG> LayDSDonHang()
        {
            List<DONHANG> dONHANGs = new List<DONHANG>();
            string query = "select * from DONHANG";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                DONHANG donhang = new DONHANG()
                {
                    MADONHANG = row["MADONHANG"] as string,
                    MAKH = row["MAKH"] as string,
                    MANV = row["MANV"] as string,
                    NGAYMUA = row["NGAYMUA"] as string,
                };
                dONHANGs.Add(donhang);
            }

            return dONHANGs;
        }
        public DONHANG LayDSDonHang(string id)
        {
            DONHANG donhang = new DONHANG();
            string query = $"select * from DONHANG where MADONHANG = '{id}'";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                donhang = new DONHANG()
                {
                    MADONHANG = row["MADONHANG"] as string,
                    MAKH = row["MAKH"] as string,
                    MANV = row["MANV"] as string,
                    NGAYMUA = row["NGAYMUA"] as string,
                };
            }

            return donhang;
        }
    }
}
