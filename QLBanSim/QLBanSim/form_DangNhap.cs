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
    public partial class form_DangNhap : Form
    {
        public form_DangNhap()
        {
            InitializeComponent();
        }

        private void form_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("hienbeo") && textBox2.Text.Equals("123456789"))
            {
                this.Hide();
                Form_TrangChu frm = new Form_TrangChu();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }
    }
}
