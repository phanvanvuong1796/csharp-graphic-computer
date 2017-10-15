using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CropTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image Img;
        //private Size OriginalImageSize;

        int cropX;
        int cropY;
        int cropWidth;

        int cropHeight;
        public Pen cropPen;

        public DashStyle cropDashStyle = DashStyle.DashDot;
        public bool Makeselection = false;

        public bool CreateText = false;

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "";
            Dlg.Title = "Chọn ảnh";
            if (Dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Img = Image.FromFile(Dlg.FileName);
                LoadImage();
            }
        }

        private void LoadImage()
        {
            int imgWidth = Img.Width;
            int imghieght = Img.Height;
            ptbImage.Width = imgWidth;
            ptbImage.Height = imghieght;
            ptbImage.Image = Img;
        }

        private void ptbImage_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Cursor = Cursors.Cross;
                    cropX = e.X;
                    cropY = e.Y;

                    cropPen = new Pen(Color.Black, 2);
                    cropPen.DashStyle = DashStyle.DashDotDot;
                }
                ptbImage.Refresh();
            }
            catch (Exception ex)
            {
            }
        }

        private void ptbImage_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            cropX = tempCropX;
            cropY = tempCropY;
        }

        int tempCropX;
        int tempCropY;

        private void ptbImage_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (ptbImage.Image == null)
                    return;


                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    ptbImage.Refresh();
                    cropWidth = Math.Abs(e.X - cropX);
                    cropHeight = Math.Abs(e.Y - cropY);
                    if (e.X > cropX && e.Y > cropY)
                    {
                        tempCropX = cropX;
                        tempCropY = cropY;
                    }else if(e.X > cropX && e.Y < cropY)
                    {
                        tempCropX = cropX;
                        tempCropY = e.Y;
                    }else if(e.X < cropX && e.Y > cropY)
                    {
                        tempCropX = e.X;
                        tempCropY = cropY;
                    }else if(e.X < cropX && e.Y < cropY)
                    {
                        tempCropX = e.X;
                        tempCropY = e.Y;
                    }
                    ptbImage.CreateGraphics().DrawRectangle(cropPen, tempCropX, tempCropY, cropWidth, cropHeight);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

            try
            {
                if (cropWidth < 1)
                {
                    return;
                }
                Bitmap originalImage = new Bitmap(ptbImage.Image, ptbImage.Width, ptbImage.Height);

                Bitmap resultImage = new Bitmap(cropWidth, cropHeight);

                Color[][] originalColorImage = GetColorMatrixFromBitmap(originalImage);
                Color[][] resultColorImage = new Color[cropWidth][];

                for(int x = 0; x<cropWidth; x++)
                {
                    resultColorImage[x] = new Color[cropHeight];
                    for(int y = 0; y<cropHeight; y++)
                    {
                        resultColorImage[x][y] = originalColorImage[x + cropX][y + cropY];
                    }
                }
                resultImage = GetBitmapFromColorMatrix(resultColorImage);

                ptbImage.Image = resultImage;
                ptbImage.Width = resultImage.Width;
                ptbImage.Height = resultImage.Height;
            }
            catch (Exception ex)
            {

            }
        }


        public Color[][] GetColorMatrixFromBitmap(Bitmap bmpOriginalImage)
        {
            int height = bmpOriginalImage.Height;
            int width = bmpOriginalImage.Width;

            Color[][] colorMatrix = new Color[width][];
            for (int i = 0; i < width; i++)
            {
                colorMatrix[i] = new Color[height];
                for (int j = 0; j < height; j++)
                {
                    colorMatrix[i][j] = bmpOriginalImage.GetPixel(i, j);
                }
            }
            return colorMatrix;
        }

        public Bitmap GetBitmapFromColorMatrix(Color[][] colorMatrix)
        {

            int height = cropHeight;
            int width = cropWidth;
            Bitmap bmpImage = new Bitmap(cropWidth, cropHeight);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmpImage.SetPixel(i, j, colorMatrix[i][j]);
                }
            }
            return bmpImage;
        }

    }
}
