using System;
using System.Text.RegularExpressions;

namespace ProxyPatternBMPApp
{
    public class ImageProxy:Image
    {
        public Size sizeImage = new Size();
        private static string path = "";
        private int getImageHeight()
        {
            int result = 0;
            var t = Regex.IsMatch(ImageFileName(), @"\S[0-9]\D[0-9]");
            if (t == false) { throw new FormatException(); }
            string trimmed = ImageFileName().Trim();
            string trimResult = trimmed.Substring(0, trimmed.IndexOf('.'));
            var regex = new Regex(@"\d*\Z");
            if (regex.IsMatch(trimResult) == false)
            {
                throw new FormatException();
            }
            result = Convert.ToInt32(regex.Match(trimResult).Value);
            return result;
        }

        private int getImageWidth()
        {
            int result = 0;
            var t = Regex.IsMatch(ImageFileName(), @"\S[0-9].[0-9]");
            if (!t) { throw new FormatException(); }
            var regex = new Regex(@"\S[0 - 9].");
            if (regex.IsMatch(ImageFileName()) == false)
            {
                throw new FormatException();
            }
            result = Convert.ToInt32(regex.Match(ImageFileName()).Value);
            return result;
        }

        public static string ImageFileNameStatic()
        {
            return path;
        }

        private void SetSizeOfImage()
        {
            sizeImage.Height = getImageHeight();
            sizeImage.Width = getImageWidth();
        }

        public ImageProxy()
        {
            path = Console.ReadLine();
            if (path.Contains(".bmp"))
            {
                ImageFileName();
                SetSizeOfImage();
            }
            else { throw new InvalidOperationException("No file name and path in string"); }
        }

        public string ImageFileName()
        {
            return ImageFileNameStatic();
        }
    }
}
