using System;
using System.Drawing;

namespace ProxyPatternBMPApp
{
    public class ImageWork:Image
    {
        public Size sizeImage = new Size();
        private Bitmap bmp;
        private int getImageHeight()
        {
            return bmp.Height;
        }

        private int getImageWidth()
        {
            return bmp.Width;
        }

        public string ImageFileName()
        {
            var result = ImageProxy.ImageFileNameStatic();
            return result;
        }

        private void SetSizeOfImage()
        {
            try
            {
                bmp = new Bitmap(ImageFileName());
                sizeImage.Height = getImageHeight();
                sizeImage.Width = getImageWidth();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("This file is no exist");
            }
        }

        public ImageWork()
        {
            SetSizeOfImage();
        }
    }
}
