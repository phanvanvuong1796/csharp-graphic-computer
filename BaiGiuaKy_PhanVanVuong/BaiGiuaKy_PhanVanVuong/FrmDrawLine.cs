using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BaiGiuaKy_PhanVanVuong
{
    public partial class FrmDrawLine : Form
    {

        float xa, xb, ya, yb;
        public FrmDrawLine()
        {
            InitializeComponent();
        }

        public bool checkInput()
        {
            bool check = true;
            if (tbXa.Text.Equals("") || tbYa.Text.Equals("") || tbXb.Text.Equals("") || tbYb.Text.Equals(""))
            {
                check = false;
                MessageBox.Show("Nhập đủ tọa độ 2 điểm");
            }
            else
            {
                try
                {
                    xa = float.Parse(tbXa.Text);
                    ya = float.Parse(tbYa.Text);
                    xb = float.Parse(tbXb.Text);
                    yb = float.Parse(tbYb.Text);
                    if (xa < 0 || xb < 0 || ya < 0 || yb < 0)
                    {
                        MessageBox.Show("Cần nhập tọa độ là số lớn hơn 0");
                        check = false;
                    }
                    else
                    {
                        if (xa >= ptbDraw.Width || xb >= ptbDraw.Width || ya >= ptbDraw.Height || yb >= ptbDraw.Height)
                        {
                            check = false;
                            MessageBox.Show("Tọa độ điểm vượt quá khung vẽ");
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Tọa độ cần nhập số");
                    check = false;
                }
            }

            return check;
        }

        public void drawDDA(int x1, int y1, int x2, int y2, Bitmap bm)
        {
            float xtd = (x1 + x2) / 2;
            float ytd = (y1 + y2) / 2;

            // Vẽ DDA kết hợp vẽ đối xứng

            float dx, dy, steps;
            float xInc, yInc, x, y;
            dx = xtd - x1;
            dy = ytd - y1;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xInc = dx / steps;
            yInc = dy / steps;
            x = x1;
            y = y1;

            bm.SetPixel((int)x, (int)y, Color.Red);
            bm.SetPixel((int)(2 * xtd - x), (int)(2 * ytd - y), Color.Black);

            for (int k = 1; k < steps; k++)
            {
                x = x + xInc;
                y = y + yInc;
                bm.SetPixel((int)x, (int)y, Color.Red);
                bm.SetPixel((int)(2 * xtd - x), (int)(2 * ytd - y), Color.Black);
            }
        }

        public void drawNetDut(int x1, int y1, int x2, int y2, Bitmap bm)
        {
            bool draw = true;

            float dx, dy, steps;
            float xInc, yInc, x, y;
            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xInc = dx / steps;
            yInc = dy / steps;
            x = x1;
            y = y1;

            bm.SetPixel((int)x, (int)y, Color.Red);

            int i = (int)(steps / 10);
            int point = i;

            for (int k = 1; k < steps; k++)
            {
                x = x + xInc;
                y = y + yInc;

                if (k == point)
                {
                    draw = draw ? false : true;
                    point += i;
                }
                if (draw)
                {
                    bm.SetPixel((int)x, (int)y, Color.Red);
                }

            }
        }

        public void drawLineTrans(int x1, int y1, int x2, int y2, Bitmap bm)
        {

            float dx, dy, steps;
            float xInc, yInc, x, y;
            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xInc = dx / steps;
            yInc = dy / steps;
            x = x1;
            y = y1;

            bm.SetPixel((int)x, (int)y, Color.Red);

            int trans = 255;
            int i = (int)(steps / 255);
            int point = i > 1 ? i : 1;

            for (int k = 1; k < steps; k++)
            {
                x = x + xInc;
                y = y + yInc;

                if (k == point)
                {
                    trans--;
                    if (trans < 0)
                    {
                        trans = 0;
                    }
                    point += (i > 1 ? i : 1);
                }
                bm.SetPixel((int)x, (int)y, Color.FromArgb(trans, Color.Black));
            }
        }

        public void drawLineBold(int x1, int y1, int x2, int y2, Bitmap bm)
        {

            float dx, dy, steps;
            float xInc, yInc, x, y;
            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xInc = dx / steps;
            yInc = dy / steps;
            x = x1;
            y = y1;

            bm.SetPixel((int)x, (int)y, Color.Red);

            for (int k = 1; k < steps; k++)
            {
                x = x + xInc;
                y = y + yInc;


                for (int i = 0; i < 4; i++)
                {
                    bm.SetPixel((int)(x + i), (int)(y + i), Color.Black);
                }

            }
        }


        public void Swap(ref int x1, ref int x2)
        {
            int temp = x1;
            x1 = x2;
            x2 = temp;
        }

        public void drawBresenham(int x1, int y1, int x2, int y2, Bitmap bm)
        {

            bool flag = false;
            int p, const1, const2;
            int Dy, Dx;
            int i, tang;
            if (Math.Abs(x1 - x2) < Math.Abs(y1 - y2))
            {
                flag = true;
                Swap(ref x1, ref y1);
                Swap(ref x2, ref y2);
            }
            if (x1 > x2)
            {
                Swap(ref x1, ref x2);
                Swap(ref y1, ref y2);
            }
            //---------Tinh Bresenham------------
            Dy = y2 - y1;
            Dx = x2 - x1;
            //--------Tinh huong tang cua Dy
            if (Dy > 0) tang = 1;
            else
            {
                tang = -1;
                Dy = Dy * -1;
            }
            p = 2 * Dy - Dx;
            const1 = 2 * Dy;
            const2 = 2 * (Dy - Dx);
            bm.SetPixel(x1, y1, Color.Red);
            if (flag == false)
            {
                for (i = x1; i < x2; i++)
                {
                    if (p < 0) p = p + const1;
                    else
                    {
                        p = p + const2;
                        y1 += tang;
                    }
                    x1++;
                    bm.SetPixel(x1, y1, Color.Red);
                }
            }
            else
            {
                for (i = x1; i < x2; i++)
                {
                    if (p < 0) p = p + const1;
                    else
                    {
                        p = p + const2;
                        y1 += tang;
                    }
                    x1++;
                    bm.SetPixel(y1, x1, Color.Red);
                }
            }
        }


        public void drawMidPoint(int x1, int y1, int x2, int y2, Bitmap bm)
        {
            int x, y, dx, dy, d;
            bool flag = false;

            int i, tang;
            if (Math.Abs(x1 - x2) < Math.Abs(y1 - y2))
            {
                flag = true;
                Swap(ref x1, ref y1);
                Swap(ref x2, ref y2);
            }
            if (x1 > x2)
            {
                Swap(ref x1, ref x2);
                Swap(ref y1, ref y2);
            }

            y = y1;
            dx = x2 - x1;
            dy = y2 - y1;
            d = dy - dx / 2;

            //--------Tinh huong tang cua Dy
            if (dy > 0) tang = 1;
            else
            {
                tang = -1;
                dy = dy * -1;
            }

            if (flag == false)
            {
                for (x = x1; x <= x2; x++)
                {
                    bm.SetPixel(x, y, Color.Red);
                    if (d <= 0)
                        d = d + dy;
                    else
                    {
                        y += tang;
                        d = d + dy - dx;
                    }
                }
            }
            else
            {
                for (x = x1; x <= x2; x++)
                {
                    bm.SetPixel(y, x, Color.Red);
                    if (d <= 0)
                        d = d + dy;
                    else
                    {
                        y += tang;
                        d = d + dy - dx;
                    }
                }
            }
        }

        private void btnLineDut_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
            if (checkInput())
            {
                drawNetDut((int)xa, (int)ya, (int)xb, (int)yb, bm);
                ptbDraw.Image = bm;
            }
        }

        private void btnLineTrans_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
            if (checkInput())
            {
                drawLineTrans((int)xa, (int)ya, (int)xb, (int)yb, bm);
                ptbDraw.Image = bm;
            }
        }

        private void btnLineBold_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
            if (checkInput())
            {
                drawLineBold((int)xa, (int)ya, (int)xb, (int)yb, bm);
                ptbDraw.Image = bm;
            }
        }

        private void FrmDrawLine_Load(object sender, EventArgs e)
        {

        }

        private void btnBresenham_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
            if (checkInput())
            {
                drawBresenham((int)xa, (int)ya, (int)xb, (int)yb, bm);
                ptbDraw.Image = bm;
            }
        }

        private void btnMidPoint_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
            if (checkInput())
            {
                drawMidPoint((int)xa, (int)ya, (int)xb, (int)yb, bm);
                ptbDraw.Image = bm;
            }
        }


        private void btnDDA_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
            if (checkInput())
            {
                drawDDA((int)xa, (int)ya, (int)xb, (int)yb, bm);
                ptbDraw.Image = bm;
            }
        }
    }
}
