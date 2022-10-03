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
    public partial class FrmLuaChon : Form
    {
        public FrmLuaChon()
        {
            InitializeComponent();
        }

        private void tbxTraLoi_TextChanged(object sender, EventArgs e)
        {
            btnGui.Enabled = btnHocHoi.Enabled = btnNangCap.Enabled = btnTamLy.Enabled = tbxTraLoi.Text != "";
        }
    }
}
