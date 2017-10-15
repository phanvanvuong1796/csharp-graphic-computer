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
    public partial class FrmDrawClock : Form
    {
        const int ROTATE_SECOND = 1;
        const int ROTATE_MINUTE = 2;
        const int ROTATE_HOUR = 3;

        const double secondDegress = (6 * Math.PI) / 180;
        const double minuteDegress = (6 * Math.PI) / 180;
        const double hourDegressOffset = (6 * Math.PI) / 180;
        const double hourDegress = (30 * Math.PI) / 180;

        double currentSecondDegress;
        double currentMinuteDegress;
        double currentHourDegress;

        public FrmDrawClock()
        {
            InitializeComponent();
            timer.Start();
        }

        double xr;
        double yr;
        double xpSecond;
        double ypSecond;
        double xpMinute;
        double ypMinute;
        double xpHour;
        double ypHour;

        public Pen secondPen;
        public Pen minutePen;
        public Pen hourPen;

        private void rotation(double x, double y, double xr, double yr, double degress, int rotateType)
        {


            switch (rotateType)
            {
                case ROTATE_SECOND:
                    xpSecond = xr + (x - xr) * Math.Cos(degress) - (y - yr) * Math.Sin(degress);
                    ypSecond = yr + (x - xr) * Math.Sin(degress) + (y - yr) * Math.Cos(degress);
                    ptbBackground.CreateGraphics().DrawLine(secondPen, (float)xr, (float)yr, (float)xpSecond, (float)ypSecond);
                    break;
                case ROTATE_MINUTE:
                    xpMinute = xr + (x - xr) * Math.Cos(degress) - (y - yr) * Math.Sin(degress);
                    ypMinute = yr + (x - xr) * Math.Sin(degress) + (y - yr) * Math.Cos(degress);
                    ptbBackground.CreateGraphics().DrawLine(minutePen, (float)xr, (float)yr, (float)xpMinute, (float)ypMinute);
                    break;
                case ROTATE_HOUR:
                    xpHour = xr + (x - xr) * Math.Cos(degress) - (y - yr) * Math.Sin(degress);
                    ypHour = yr + (x - xr) * Math.Sin(degress) + (y - yr) * Math.Cos(degress);
                    ptbBackground.CreateGraphics().DrawLine(hourPen, (float)xr, (float)yr, (float)xpHour, (float)ypHour);
                    break;
            }
            

            
        } 

        private void FrmDrawClock_Load(object sender, EventArgs e)
        {
            secondPen = new Pen(Color.Red, 2);
            minutePen = new Pen(Color.Black, 4);
            hourPen = new Pen(Color.Black, 5);
            xr = ptbBackground.Width / 2;
            yr = ptbBackground.Height / 2;
            drawClock();
        }

        private void initPoint()
        {
            xpSecond = xr;
            ypSecond = yr - 180;
            xpMinute = xr;
            ypMinute = yr - 140;
            xpHour = xr;
            ypHour = yr - 160;
        }

        private void drawClock()
        {
            ptbBackground.Refresh();
            initPoint();
            int currentSecond = DateTime.Now.Second;
            int currentMinute = DateTime.Now.Minute;
            int currentHour = DateTime.Now.Hour;

            currentHourDegress = ((int)(currentMinute / 12)) * hourDegressOffset + currentHour*hourDegress;
            rotation(xpHour, ypHour, xr, yr, currentHourDegress, ROTATE_HOUR);

            currentMinuteDegress = currentMinute * minuteDegress;
            rotation(xpMinute, ypMinute, xr, yr, currentMinuteDegress, ROTATE_MINUTE);

            currentSecondDegress = currentSecond * secondDegress;
            rotation(xpSecond, ypSecond, xr, yr, currentSecondDegress, ROTATE_SECOND);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            drawClock();
        }
    }
}
