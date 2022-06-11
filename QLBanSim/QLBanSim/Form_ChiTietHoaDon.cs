using BUS;
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
        public Form_ChiTietHoaDon(string MaHD)
        {
           maHD = MaHD;
            InitializeComponent();
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
            dgv_ctdh.DataSource = cHITIETDONHANGs;
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
                MASIM = frmcthd_masim.Text.Trim()+ cHITIETDONHANGs.Count,
            };
            cHITIETDONHANGs.Add(ctdh);
            loadChiTietHoaDon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_ctdh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
