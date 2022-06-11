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
    public class DAL_NhanVien
    {
        public int Them(NHANVIEN nv)
        {
            string query =
                $"INSERT INTO NHANVIEN ( MANV, HOTEN, NAMSINH,GIOITINH,DIACHI) VALUES('{nv.MANV}', N'{nv.HOTEN}', '{nv.NAMSINH}', N'{nv.GIOITINH}', N'{nv.DIACHI}')";
            return DBHelper.NonQuery(query, null);
        }
        public int Sua(NHANVIEN nv)
        {
            string query =
                $"UPDATE NHANVIEN SET HOTEN = N'{nv.HOTEN}', NAMSINH = N'{nv.NAMSINH}', GIOITINH=N'{nv.GIOITINH}',DIACHI=N'{nv.DIACHI}' WHERE MANV='{nv.MANV}'";
            return DBHelper.NonQuery(query, null);
        }
        public int Xoa(string id)
        {
            string query = $"DELETE FROM NHANVIEN where MANV = '{id}'";
            return DBHelper.NonQuery(query, null);
        }
        public List<NHANVIEN> LayDSNhanVien()
        {
            List<NHANVIEN> nHANVIENs = new List<NHANVIEN>();
            string query = "select * from NHANVIEN";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                NHANVIEN nhanvien = new NHANVIEN()
                {
                    MANV = row["MANV"] as string,
                    HOTEN = row["HOTEN"] as string,
                    NAMSINH = row["NAMSINH"] as string,
                    GIOITINH = row["GIOITINH"] as string,
                    DIACHI = row["DIACHI"] as string
                };
                nHANVIENs.Add(nhanvien);
            }

            return nHANVIENs;
        }
        public NHANVIEN LayDSNhanVien(string id)
        {
            NHANVIEN nhanvien = new NHANVIEN();
            string query = $"select * from NHANVIEN where MANV = '{id}'";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                nhanvien = new NHANVIEN()
                {
                    MANV = row["MANV"] as string,
                    HOTEN = row["HOTEN"] as string,
                    NAMSINH = row["NAMSINH"] as string,
                    GIOITINH = row["GIOITINH"] as string,
                    DIACHI = row["DIACHI"] as string
                };
            }

            return nhanvien;
        }
    }
}
