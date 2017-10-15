using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuaKy_PhanVanVuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeRGB_Click(object sender, EventArgs e)
        {
            frmChangeRGB rgb = new frmChangeRGB();
            rgb.Show();
        }

        private void btnReadBitmap_Click(object sender, EventArgs e)
        {
            FrmReadBitmapFile frmReadBitmap = new FrmReadBitmapFile();
            frmReadBitmap.Show();
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            FrmDrawLine frmDrawLine = new FrmDrawLine();
            frmDrawLine.Show();
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            FrmDrawCircle frmCircle = new FrmDrawCircle();
            frmCircle.Show();
        }

        private void btnDrawClock_Click(object sender, EventArgs e)
        {
            FrmDrawClock frmClock = new FrmDrawClock();
            frmClock.Show();
        }
    }
}
