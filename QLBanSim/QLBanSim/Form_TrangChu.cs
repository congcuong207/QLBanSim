using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanSim
{
    public partial class Form_TrangChu : Form
    {
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        BUS_KhachHang bus_khachhang = new BUS_KhachHang();
        public Form_TrangChu()
        {
            InitializeComponent();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }





        private void btMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenNhaMang.Text = "";
            txtMaLoai.Text = "";
            txtGiaBan.Text = "";
            txtSDT.Text = "";
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtXuatXu_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void Form_TrangChu_Load(object sender, EventArgs e)
        {
            loadSanPham();
            loadNhanVien();
            loadKhachHang();
            loadHoaDon();
        }
        BUS_DonHang bus_hoadon = new BUS_DonHang();
        private void loadHoaDon()
        {
            dgv_hoadon.DataSource = bus_hoadon.LayDSDonHang();
            dgv_hoadon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_hoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        BUS_SanPham busSanPham = new BUS_SanPham();
        private void loadSanPham()
        {
            dgv_sanpham.DataSource = busSanPham.LayDSSim();
            dgv_sanpham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_sanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void loadNhanVien()
        {
            dgv_nhanvien.DataSource = bus_nhanvien.LayDSNhanVIen();
            dgv_nhanvien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadKhachHang()
        {
            dgv_khanghang.DataSource = bus_khachhang.LayDSKhachHang();
            dgv_khanghang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_khanghang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string tenNM = txtTenNhaMang.Text.Trim();
            string maLoai = txtMaLoai.Text.Trim();
            string giaBan = txtGiaBan.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            SIM sim = new SIM()
            {
                MASIM = maSP,
                MANM = tenNM,
                MALOAI = maLoai,
                GIA = int.Parse(giaBan),
                SDT = sdt,
            };
            busSanPham.Them(sim);
            loadSanPham();

        }
        private void btSua_Click(object sender, EventArgs e)
        {

            string message = "Bạn có chắc chắn muốn sửa?";
            string title = "Sửa sim";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string maSP = txtMaSP.Text.Trim();
                string tenNM = txtTenNhaMang.Text.Trim();
                string maLoai = txtMaLoai.Text.Trim();
                string giaBan = txtGiaBan.Text.Trim();
                string sdt = txtSDT.Text.Trim();

                SIM sim = new SIM()
                {
                    MASIM = maSP,
                    MANM = tenNM,
                    MALOAI = maLoai,
                    GIA = int.Parse(giaBan),
                    SDT = sdt,
                };
                busSanPham.Sua(sim);
                loadSanPham();
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xóa?";
            string title = "Xóa sim";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string maSP = txtMaSP.Text.Trim();
                busSanPham.Xoa(maSP);
                loadSanPham();
            }
        }


        private void dgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_sanpham.SelectedRows)
            {
                txtMaSP.Text = row.Cells[0].Value.ToString();

                txtMaLoai.Text = row.Cells[1].Value.ToString();
                txtTenNhaMang.Text = row.Cells[2].Value.ToString();
                txtGiaBan.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string manv = frmnv_manv.Text.Trim();
            string hoten = frmnv_tennv.Text.Trim();
            string namsinh = frmnv_namsinh.Text.Trim();
            string gioitinh = frmnv_gioitinh.Text.Trim();
            string diachi = frmnv_diachi.Text.Trim();

            NHANVIEN nhanvien = new NHANVIEN()
            {
                MANV = manv,
                HOTEN = hoten,
                NAMSINH = namsinh,
                GIOITINH = gioitinh,
                DIACHI = diachi,
            };
            bus_nhanvien.Them(nhanvien);
            loadNhanVien();
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_nhanvien.SelectedRows)
            {
                frmnv_manv.Text = row.Cells[0].Value.ToString();
                frmnv_tennv.Text = row.Cells[1].Value.ToString();
                frmnv_namsinh.Text = row.Cells[2].Value.ToString();
                frmnv_gioitinh.Text = row.Cells[3].Value.ToString();
                frmnv_diachi.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dgv_khanghang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_khanghang.SelectedRows)
            {
                frmkh_makh.Text = row.Cells[0].Value.ToString();
                frmkh_tenkh.Text = row.Cells[2].Value.ToString();
                frmkh_diachi.Text = row.Cells[3].Value.ToString();
                frmkh_sdt.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dgv_hoadon.SelectedRows)
            {
                frmhd_madh.Text = row.Cells[0].Value.ToString();
                frmhd_makh.Text = row.Cells[1].Value.ToString();
                frmhd_manv.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value != null)
                {
                    frmhd_ngay.Text = row.Cells[3].Value.ToString();
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string makh = frmkh_makh.Text.Trim();
            string hoten = frmkh_tenkh.Text.Trim();
            string diachi = frmkh_diachi.Text.Trim();
            string sdt = frmkh_sdt.Text.Trim();

            KHACHHANG khachhang = new KHACHHANG()
            {
                MAKH = makh,
                TENKH = hoten,
                DIACHI = diachi,
                SDT = sdt,
            };
            bus_khachhang.Them(khachhang);
            loadKhachHang();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn sửa?";
            string title = "Sửa khách hàng";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string manv = frmnv_manv.Text.Trim();
                string hoten = frmnv_tennv.Text.Trim();
                string namsinh = frmnv_namsinh.Text.Trim();
                string gioitinh = frmnv_gioitinh.Text.Trim();
                string diachi = frmnv_diachi.Text.Trim();

                NHANVIEN nhanvien = new NHANVIEN()
                {
                    MANV = manv,
                    HOTEN = hoten,
                    NAMSINH = namsinh,
                    GIOITINH = gioitinh,
                    DIACHI = diachi,
                };
                bus_nhanvien.Sua(nhanvien);
                loadNhanVien();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xóa?";
            string title = "Xóa nhân viên";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string maNV = frmnv_manv.Text.Trim();
                bus_nhanvien.Xoa(maNV);
                loadNhanVien();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn sửa?";
            string title = "Sửa khách hàng";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string makh = frmkh_makh.Text.Trim();
                string hoten = frmkh_tenkh.Text.Trim();
                string diachi = frmkh_diachi.Text.Trim();
                string sdt = frmkh_sdt.Text.Trim();

                KHACHHANG khachhang = new KHACHHANG()
                {
                    MAKH = makh,
                    TENKH = hoten,
                    DIACHI = diachi,
                    SDT = sdt,
                };
                bus_khachhang.Sua(khachhang);
                loadKhachHang();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn muốn xóa?";
            string title = "Xóa khách hàng";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string maKH = frmkh_makh.Text.Trim();
                bus_khachhang.Xoa(maKH);
                loadKhachHang();
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmkh_makh.Text = "";
            frmkh_masim.Text = "";
            frmkh_tenkh.Text = "";
            frmkh_diachi.Text = "";
            frmkh_sdt.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmnv_manv.Text = "";
            frmnv_tennv.Text = "";
            frmnv_namsinh.Text = "";
            frmnv_gioitinh.Text = "";
            frmnv_diachi.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
       public static string mahd;
        private void button9_Click(object sender, EventArgs e)
        {
            mahd = frmhd_madh.Text.Trim();
            Form_ChiTietHoaDon frm = new Form_ChiTietHoaDon(frmhd_madh.Text.Trim());
            frm.Show();
        }
        //thêm hóa đơn
        private void button14_Click(object sender, EventArgs e)
        {
            DONHANG dh = new DONHANG()
            {
                MADONHANG = frmhd_madh.Text.Trim(),
               
                MAKH = frmhd_makh.Text.Trim(),
                MANV = frmhd_manv.Text.Trim(),
                NGAYMUA = frmhd_ngay.Text.Trim(),
            };
            if (bus_hoadon.Them(dh) > 0)
            {
                MessageBox.Show("Thêm thành công");
                loadHoaDon();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DONHANG dh = new DONHANG()
            {
                MADONHANG = frmhd_madh.Text.Trim(),
                MAKH = frmhd_makh.Text.Trim(),
                MANV = frmhd_manv.Text.Trim(),
                NGAYMUA = frmhd_ngay.Text.Trim(),
            };
            if (bus_hoadon.Sua(dh) > 0)
            {
                MessageBox.Show("Sửa thành công");
                loadHoaDon();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DONHANG dh = new DONHANG()
            {
                MADONHANG = frmhd_madh.Text.Trim(),
                MAKH = frmhd_makh.Text.Trim(),
                MANV = frmhd_manv.Text.Trim(),
                NGAYMUA = frmhd_ngay.Text.Trim(),
            };
            if (bus_hoadon.Xoa(dh.MADONHANG) > 0)
            {
                MessageBox.Show("Xóa thành công");
                loadHoaDon();
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
    }
}
