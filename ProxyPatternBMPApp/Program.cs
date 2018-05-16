using System;

namespace ProxyPatternBMPApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool OperationStateIsCorrect = false;
            while (!OperationStateIsCorrect)
            {
                try
                {
                    CreateImageProxy();
                    OperationStateIsCorrect = true;
                }
                catch (FormatException e)
                {
                    ImageWork work = new ImageWork();
                    Console.WriteLine(work.sizeImage.getImageSize());
                    OperationStateIsCorrect = true;
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                    OperationStateIsCorrect = false;
                }

            }
            Console.WriteLine("");
            Console.ReadLine();
        }

        static void CreateImageProxy()
        { 
            ImageProxy proxy = new ImageProxy();
            Console.WriteLine(proxy.sizeImage.getImageSize());
        }
    }
}
