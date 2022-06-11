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
    public class DAL_SanPham
    {
        public int Them(SIM s)
        {
            string query =
                $"INSERT INTO SIM(MASIM, MALOAI, MANM,SDT,GIA)VALUES('{s.MASIM}', '{s.MALOAI}', '{s.MANM}', '{s.SDT}',{s.GIA})";
            return DBHelper.NonQuery(query, null);
        }
        public int Sua(SIM s)
        {
            string query =
                $"UPDATE SIM SET MALOAI = N'{s.MALOAI}', MANM = N'{s.MANM}', SDT='{s.SDT}',GIA={s.GIA} WHERE MASIM='{s.MASIM}'";
            return DBHelper.NonQuery(query, null);
        }
        public int Xoa(string id)
        {
            string query = $"DELETE FROM SIM where MASIM = '{id}'";
            return DBHelper.NonQuery(query, null);
        }
        public List<SIM> LayDSSim()
        {
            List<SIM> sIMs = new List<SIM>();
            string query = "select * from SIM";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                SIM sim = new SIM()
                {
                    MASIM = row["MASIM"] as string,
                    MALOAI = row["MALOAI"] as string,
                    MANM = row["MANM"] as string,
                    SDT = row["SDT"] as string,
                    GIA = row["GIA"] as int? ?? 0
                };
                sIMs.Add(sim);
            }

            return sIMs;
        }
        public SIM LayDSSim(string id)
        {
            SIM sim = new SIM();
            string query = $"select * from SIM where MASIM = '{id}'";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                sim = new SIM()
                {
                    MASIM = row["MASIM"] as string,
                    MALOAI = row["MALOAI"] as string,
                    MANM = row["MANM"] as string,
                    SDT = row["SDT"] as string,
                    GIA = row["GIA"] as int? ?? 0
                };
            }

            return sim;
        }
    }
}
