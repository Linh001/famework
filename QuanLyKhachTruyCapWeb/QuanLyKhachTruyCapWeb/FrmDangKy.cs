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
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKyTK_Click(object sender, EventArgs e)
        {
            if(tbxNhapLaiMK.Text != tbxNhapMK.Text)
            {
                lblThongBao.Text = @"Mật khẩu không khớp!";
            }
            else
            {
                lblThongBao.Text = @"Đăng ký thành công!";
                Hide();
                FrmLuaChon frmLuaChon = new FrmLuaChon();
                frmLuaChon.ShowDialog();
                Close();
            }
        }

        private void tbxHoTen_TextChanged(object sender, EventArgs e)
        {
            btnDangKyTK.Enabled = tbxHoTen.Text != "" && tbxSDT.Text != "" && tbxNhapTK.Text != "" &&
                tbxNhapMK.Text != "" && tbxNhapLaiMK.Text != "";
            tbxNhapMK.UseSystemPasswordChar = true;
            tbxNhapLaiMK.UseSystemPasswordChar = true;
        }
    }
}
