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
    public partial class FrmDrawCircle : Form
    {
        int radioCheck = 0;
        int radius = 100;
        int a, b;
        public FrmDrawCircle()
        {
            InitializeComponent();

        }

        private void drawPixel_Ellipse(int xc, int yc, int x, int y, Bitmap bm, Color color)
        {
            //if ((xc + x) < 0 || (xc + x) >= bm.Width || (xc - x) < 0 || (xc - x) >= bm.Width) return;
            //if ((yc + y) < 0 || (yc + y) >= bm.Height || (yc - y) < 0 || (yc - y) >= bm.Height) return;
            if((xc+x)>=0 && (xc + x) < bm.Width && (yc+y) >=0 && (yc+y)<bm.Height)
            {
                bm.SetPixel(xc + x, yc + y, Color.Green);
            }
            if ((xc - x) >= 0 && (xc - x) < bm.Width && (yc + y) >= 0 && (yc + y) < bm.Height)
            {
                bm.SetPixel(xc - x, yc + y, Color.DeepPink);
            }
            if ((xc + x) >= 0 && (xc + x) < bm.Width && (yc - y) >= 0 && (yc - y) < bm.Height)
            {
                bm.SetPixel(xc + x, yc - y, Color.Blue);
            }
            if((xc - x) >= 0 && (xc - x) < bm.Width && (yc - y) >= 0 && (yc - y) < bm.Height)
            {
                bm.SetPixel(xc - x, yc - y, Color.Tomato);
            }
        }

        private void Ellipse_MidPoint(int xc, int yc, int a, int b, Bitmap bm)
        {
            int x, y, fx, fy, a2, b2, d;
            x = 0;
            y = b;
            a2 = a * a;
            b2 = b * b;
            fx = 0;
            fy = 2 * a2 * y;
            drawPixel_Ellipse(xc, yc, x, y, bm, Color.Red);
            d = b2 - (a2 * b) + (a2 / 4);
            while (fx < fy)
            {
                x++;
                fx += 2 * b2;
                if (d < 0)
                    d += b2 * (2 * x + 3);
                else
                {
                    y--;
                    d += b2 * (2 * x + 3) + a2 * (2 - 2 * y);
                    fy -= 2 * a2;
                }
                drawPixel_Ellipse(xc, yc, x, y, bm, Color.Green);
            }
            d = (int)(b2 * (x + 0.5) * (x + 0.5) + a2 * (y - 1) * (y - 1) - a2 * b2);
            while (y > 0)
            {
                y--;
                fy -= 2 * a2;
                if (d >= 0)
                    d += a2 * (3 - 2 * y);
                else
                {
                    x++;
                    fx += 2 * b2;
                    d += b2 * (2 * x + 2) + a2 * (3 - 2 * y);
                }
                drawPixel_Ellipse(xc, yc, x, y, bm, Color.Orange);
            }
        }

        public void Circle_Decac(int a, int b, int r, Bitmap bm)
        {
            double y1_real, y2_real;
            int y1, y2;
            for (int x = (a - r); x <= (a + r); x++)
            {
                y1_real = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x - a, 2)) + b;
                y2_real = -Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x - a, 2)) + b;

                y1 = (int) y1_real;
                y2 = (int) y2_real;
                if(x>=0 && x<bm.Width && y1>=0 && y1 < bm.Height)
                {
                    bm.SetPixel(x, y1, Color.Red);
                }
                if (x >= 0 && x < bm.Width && y2 >= 0 && y2 < bm.Height)
                {
                    bm.SetPixel(x, y2, Color.Red);
                }
                
            }
        }


        public void Circle_ToaDoCuc(int a, int b, int r, Bitmap bm)
        {
            int x, y;
            double x1, y1;
            for(int goc=0; goc<=360; goc++)
            {
                x1 = r * Math.Cos(goc * 3.14 / 180) + a;
                y1 = r * Math.Sin(goc * 3.14 / 180) + b;
                x = (int)(x1);
                y = (int)(y1);
                if (x >= 0 && x < bm.Width && y >= 0 && y < bm.Height)
                {
                    bm.SetPixel(x, y, Color.Black);
                }
                
            }
        }

        public void Circle_MidPoint(int a, int b, int r, Bitmap bm)
        {
            int y = r;
            int max_step = (int)(r * 0.70710678);
            int d = 1 - r;
            for(int x = 0; x<max_step; x++)
            {
                if (d < 0)
                {
                    d += 2 * (x + 1) + 1;

                }
                else
                {
                    d += 2 * (x + 1) + 1 - 2 * y + 2;
                    y = y - 1;
                }
                drawEightPixels(x, y, bm);
            }
        }

        private void DrawPixels(int x, int y, Bitmap bm, Color color)
        {
            x = a + x;
            y = b - y;
            if(x>=0 && x<bm.Width && y>=0 && y < bm.Height)
            {
                bm.SetPixel(x, y, color);
            }
            
        }

        private void drawEightPixels(int x, int y, Bitmap bm)
        {
            DrawPixels(x, y, bm, Color.Red);
            DrawPixels(y, x, bm, Color.Green);
            DrawPixels(y, -x, bm, Color.DeepPink);
            DrawPixels(x, -y, bm, Color.Cyan);
            DrawPixels(-x, -y, bm, Color.Magenta);
            DrawPixels(-y, -x, bm, Color.Yellow);
            DrawPixels(-y, x, bm, Color.Brown);
            DrawPixels(-x, y, bm, Color.LightBlue);
        }

        private void btnDecac_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
            Circle_Decac(200, 200, radius, bm);
            ptbDraw.Image = bm;
        }

        private void btnTDC_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
            Circle_ToaDoCuc(200, 200, radius, bm);
            ptbDraw.Image = bm;
        }

        private void btnMidPoint_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
            a = 300;
            b = 300;
            Circle_MidPoint(a, b, radius, bm);

            
            ptbDraw.Image = bm;
        }

        private bool checkMouse = false;

        private void ptbDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkMouse)
            {
                a = e.X;
                b = e.Y;
                Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
                Graphics grap = Graphics.FromImage(bm);
                grap.Clear(Color.White);
                switch (radioCheck)
                {
                    case 0:
                        Circle_Decac(a, b, radius, bm);
                        break;
                    case 1:
                        Circle_ToaDoCuc(a, b, radius, bm);
                        break;
                    case 2:
                        Circle_MidPoint(a, b, radius, bm);
                        break;
                    case 3:
                        Ellipse_MidPoint(a, b, 200, 50, bm);
                        break;
                }
                ptbDraw.Image = bm;
            }
            
        }

        private void ptbDraw_MouseUp(object sender, MouseEventArgs e)
        {
            checkMouse = false;

        }

        private void btnDrawElipse_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
            Ellipse_MidPoint(200, 200, 200, 50, bm);
            ptbDraw.Image = bm;
        }

        private void FrmDrawCircle_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
        }

        private void rbtDecac_CheckedChanged(object sender, EventArgs e)
        {
            radioCheck = 0;
        }

        private void rbtToaDoCuc_CheckedChanged(object sender, EventArgs e)
        {
            radioCheck = 1;
        }

        private void rbtMidPoint_CheckedChanged(object sender, EventArgs e)
        {
            radioCheck = 2;
        }

        private void rbtElipse_CheckedChanged(object sender, EventArgs e)
        {
            radioCheck = 3;
        }

        private void txtBanKinh_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                radius = int.Parse(txtBanKinh.Text);
            }catch(Exception)
            {
                radius = 100;
            }
        }

        private void ptbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            checkMouse = true;
            a = e.X;
            b = e.Y;
            Bitmap bm = new Bitmap(ptbDraw.Width, ptbDraw.Height);
            Graphics grap = Graphics.FromImage(bm);
            grap.Clear(Color.White);
            switch (radioCheck)
            {
                case 0:
                    Circle_Decac(a, b, radius, bm);
                    break;
                case 1:
                    Circle_ToaDoCuc(a, b, radius, bm);
                    break;
                case 2:
                    Circle_MidPoint(a, b, radius, bm);
                    break;
                case 3:
                    Ellipse_MidPoint(a, b, 200, 50, bm);
                    break;
            }
            //Circle_MidPoint(a, b, 100, bm);
            ptbDraw.Image = bm;
        }



    }
}
