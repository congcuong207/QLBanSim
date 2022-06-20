using BUS;
using DAL;
using DTO;
using System;
using System.Collections;
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
    public partial class Form_ChiTietHoaDon : Form
    {
        string maHD;
        ArrayList cHITIETDONHANGs;
        DAL_HoaDon dal = new DAL_HoaDon();
        public Form_ChiTietHoaDon(string MaHD)
        {

            InitializeComponent();
            maHD = Form_TrangChu.mahd.Trim();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadChiTietHoaDon()
        {
            dgv_ctdh.DataSource = dal.GetCHITIETDONHANGs(maHD);
            dgv_ctdh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_ctdh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Form_ChiTietHoaDon_Load(object sender, EventArgs e)
        {

            loadChiTietHoaDon();
            cHITIETDONHANGs = new ArrayList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CHITIETDONHANG ctdh = new CHITIETDONHANG
            {
                MAHD = maHD,

                MASIM = frmcthd_masim.Text.Trim() ,
            };
            dal.AddCTDH(ctdh);
            loadChiTietHoaDon();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ctdh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_ctdh.SelectedRows)
            {
                frmcthd_masim.Text = row.Cells[0].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dal.DeleteCTDH(mahd,masim);
        }

        string mahd, masim;
        private void dgv_ctdh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dgv_ctdh.SelectedRows)
            {
                mahd = row.Cells[0].ToString().Trim();
                masim = row.Cells[1].ToString().Trim();
            }
        }
    }
}
