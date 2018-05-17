using System.Drawing;

namespace ProxyPatternBMPApp
{
    public class ImageWork
    {
        private Bitmap bmp;

        private string path;
        public ImageWork(string p)
        {
            path = p;
        }

        public Size GetSizeOfImage()
        {
            bmp = new Bitmap(path);
            Size sizeImage = new Size();
            sizeImage.Height = bmp.Height;
            sizeImage.Width = bmp.Width;
            return sizeImage;
        }

    }
}
