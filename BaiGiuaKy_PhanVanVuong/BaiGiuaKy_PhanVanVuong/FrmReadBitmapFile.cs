using BaiGiuaKy_PhanVanVuong.converter;
using BaiGiuaKy_PhanVanVuong.tagBitmap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuaKy_PhanVanVuong
{
    public partial class FrmReadBitmapFile : Form
    {
        public FrmReadBitmapFile()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "bmp file|*.bmp";
            open.ShowDialog();
            listPath.Items.Add("" + open.FileName);
        }

        private void listPath_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listPath.Items.Count != 0)
            {
                try {
                    string fileName = listPath.SelectedItem.ToString();
                    TagBitmapFileHeader fileheader = getBitmapFileHeader(fileName);
                    displayHeader(fileheader);
                    TagBitmapFileInfo fileInfo = getBitmapFileInfo(fileName);
                    displayInfo(fileInfo);
                }
                catch (Exception)
                {

                }
                
            }
            
        }

        public TagBitmapFileHeader getBitmapFileHeader(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] header = new byte[14];
            TagBitmapFileHeader fileHeader = new TagBitmapFileHeader();
            try
            {
                stream.Position = 0;
                stream.Read(header, 0, 14);

                fileHeader.bfType = Encoding.ASCII.GetString(header, 0, 2);
                fileHeader.bfSize = ByteConvertInt.byte4Int(header, 2);
                fileHeader.bfReserved1 = ByteConvertInt.byte2Int(header, 6);
                fileHeader.bfReserved2 = ByteConvertInt.byte2Int(header, 8);
                fileHeader.bfOffBits = ByteConvertInt.byte4Int(header, 10);
            }catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                stream.Close();
            }
            return fileHeader;
        }

        public TagBitmapFileInfo getBitmapFileInfo(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] info = new byte[16];
            List<byte> list = new List<byte>();
            TagBitmapFileInfo fileInfo = new TagBitmapFileInfo();
            try
            {
                stream.Position = 0;
                stream.Read(info, 0, 16);
                list.AddRange(info);
                

                info = new byte[16];
                stream.Position = 16;
                stream.Read(info, 0, 16);
                list.AddRange(info);

                info = new byte[16];
                stream.Position = 32;
                stream.Read(info, 0, 16);
                list.AddRange(info);

                info = new byte[6];
                stream.Position = 48;
                stream.Read(info, 0, 6);
                list.AddRange(info);

                info = new byte[54];
                info = list.ToArray();

                fileInfo.biSize = ByteConvertInt.byte4Uint(info, 14);
                fileInfo.biWidth = ByteConvertInt.byte4Long(info, 18);
                fileInfo.biHeight = ByteConvertInt.byte4Long(info, 22);
                fileInfo.biPlanes = ByteConvertInt.byte2Int(info, 26);
                //fileInfo.biPlanes = Encoding.ASCII.GetString(info, 26, 2);
                fileInfo.biBitCount = ByteConvertInt.byte2Int(info, 28);
                //fileInfo.biBitCount = Encoding.ASCII.GetString(info, 28, 2);
                fileInfo.biCompression = ByteConvertInt.byte4Uint(info, 30);
                fileInfo.biSizeImage = ByteConvertInt.byte4Uint(info, 34);
                fileInfo.biXPelsPerMeter = ByteConvertInt.byte4Long(info, 38);
                fileInfo.biYPelsPerMeter = ByteConvertInt.byte4Long(info, 42);
                fileInfo.biClrUsed = ByteConvertInt.byte4Uint(info, 46);
                fileInfo.biClrImportant = ByteConvertInt.byte4Uint(info, 50);
               
            
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                stream.Close();
            }
            return fileInfo;
        }
        public void displayImage(string fileName, TagBitmapFileInfo info)
        {
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            long stride = (info.biWidth * (info.biBitCount / 8))  ;
            byte[] data = new byte[10];
            byte temp;
            long size = 0;
            long position = 54;
            List<Color> listColor = new List<Color>();
            List<List<Color>> listImage = new List<List<Color>>();

            file.Position = position;
            file.Read(data, 6, 10);

            


            for (int i=0; i<info.biHeight; i++)
            {
                size = 0;
                listColor = new List<Color>();
                while (size < stride)
                {
                    file.Position = position;
                    file.Read(data, 0, 3);

                    temp = data[0];
                    data[0] = data[2];
                    data[2] = temp;
                    Color color = Color.FromArgb(data[0], data[1], data[2]);
                    listColor.Add(color);
                }
                position += stride;
                listImage.Insert(0, listColor);
            }
        }


        public void displayHeader(TagBitmapFileHeader fileHeader)
        {
            string header = "Type: " + fileHeader.bfType
                            + "\nSize: " + fileHeader.bfSize + " byte"
                            + "\nReserved1: " + fileHeader.bfReserved1
                            + "\nReserved2: " + fileHeader.bfReserved2
                            + "\nOffBits: " + fileHeader.bfOffBits;
            txtHeader.Text = header;
                            
        }

        public void displayInfo(TagBitmapFileInfo fileInfo)
        {
            string info = "Size: " + fileInfo.biSize
                          + "\nWidth: " + fileInfo.biWidth
                          + "\nHeight: " + fileInfo.biHeight
                          + "\nPlanes: " + fileInfo.biPlanes
                          + "\nBitCount: " + fileInfo.biBitCount
                          + "\nCompression: " + fileInfo.biCompression
                          + "\nSizeImage: " + fileInfo.biSizeImage
                          + "\nXPelsPerMeter: " + fileInfo.biXPelsPerMeter
                          + "\nYPelsPerMeter: " + fileInfo.biYPelsPerMeter
                          + "\nColor used: " + fileInfo.biClrUsed
                          + "\nColor Important: " + fileInfo.biClrImportant;
            txtInformation.Text = info;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
