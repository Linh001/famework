using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachTruyCapWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbxTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = tbxMatKhau.Text != "" && tbxTaiKhoan.Text != "";
        }

        private void cbxHide_CheckedChanged(object sender, EventArgs e)
        {
            tbxMatKhau.UseSystemPasswordChar = !cbxHide.Checked;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLuaChon frmLuaChon = new FrmLuaChon();
            frmLuaChon.ShowDialog();
            Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Hide();
            FrmDangKy frmDangKy = new FrmDangKy();
            frmDangKy.ShowDialog();
            Close();
        }
    }
}
