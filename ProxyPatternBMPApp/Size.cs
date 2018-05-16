namespace ProxyPatternBMPApp
{
    public class Size
    {
        private int width;
        private int height;

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        public string getImageSize()
        {
            string result = "Width: " + Width + " | " + "Height: "+ Height;
            return result;
        }
    }
}
