using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

namespace TravelRegistrationSystem.WinFormUI
{
    public static class ImageHelper
    {
        //将图片转换成二进制
        public static byte[] ImageToBytes(Image img, ImageFormat imgFormat)
        {
            if (img == null) return null;
            Bitmap bmp = new Bitmap(img);
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, imgFormat);
            ms.Seek(0, SeekOrigin.Begin);

            byte[] imgBytes = new byte[ms.Length];
            ms.Read(imgBytes, 0, imgBytes.Length);
            ms.Close();
            return imgBytes;
        }
        //将二进制转换成图片
        public static Image BytesToImage(byte[] imgBytes)
        {
            if (imgBytes == null) return null;
            MemoryStream ms =new MemoryStream();
            ms.Write(imgBytes,0,imgBytes.Length);
            ms.Seek(0,SeekOrigin.Begin);
            Image img;
            try{
                img=Image.FromStream(ms,true);
                ms.Close();
            }
            catch(Exception ex)
            {
                img=null;
            }
            return img;
        }
    }
}
