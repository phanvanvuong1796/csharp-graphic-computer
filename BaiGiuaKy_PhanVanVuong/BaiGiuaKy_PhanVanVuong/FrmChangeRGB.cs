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
    public partial class frmChangeRGB : Form
    {
        public frmChangeRGB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadValueColor();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            loadValueColor();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            loadValueColor();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            loadValueColor();
        }

        public void loadValueColor()
        {
            colorR.BackColor = Color.FromArgb(trackBarRed.Value, 0, 0);
            colorG.BackColor = Color.FromArgb(0, trackBarGreen.Value, 0);
            colorB.BackColor = Color.FromArgb(0, 0, trackBarBlue.Value);

            colorC.BackColor = Color.FromArgb(255 - trackBarRed.Value, 0, 0);
            colorM.BackColor = Color.FromArgb(0, 255-trackBarGreen.Value, 0);
            colorY.BackColor = Color.FromArgb(0, 0, 255 - trackBarBlue.Value);

            colorResult.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            lbRedValue.Text = trackBarRed.Value + "";
            lbGreenValue.Text = trackBarGreen.Value + "";
            lbBueValue.Text = trackBarBlue.Value + "";
            lbCValue.Text = (255 - trackBarRed.Value) + "";
            lbMValue.Text = (255 - trackBarGreen.Value) + "";
            lbYValue.Text = (255 - trackBarBlue.Value) + "";

        }
    }
}
