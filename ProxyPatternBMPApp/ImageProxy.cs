using System;
using System.Text.RegularExpressions;

namespace ProxyPatternBMPApp
{
    public class ImageProxy
    {
        private string path;
        
        public Size GetSizeOfImage()
        {
            Size sizeImage = new Size();
            int Height = 0;
            var t = Regex.IsMatch(path, @"\S[0-9]\D[0-9]");
            string trimmed = path.Trim();
            string trimResult = trimmed.Substring(0, trimmed.IndexOf('.'));
            var regexH = new Regex(@"\d*\Z");
            Height = Convert.ToInt32(regexH.Match(trimResult).Value);
            int Width = 0;
            var regexW = new Regex(@"\S[0 - 9].");
            Width = Convert.ToInt32(regexW.Match(path).Value);
            sizeImage.Height = Height;
            sizeImage.Width = Width;
            return sizeImage;
        }

        public ImageProxy(string filename)
        {
            path = filename;
        }

    }
}


