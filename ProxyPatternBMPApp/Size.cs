namespace ProxyPatternBMPApp
{
    public class Size
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public override string ToString()
        {
            string result = "Width: " + Width + " | " + "Height: "+ Height;
            return result;
        }
    }
}
