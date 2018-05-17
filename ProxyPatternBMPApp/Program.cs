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
                var path = Console.ReadLine();
                try
                {
                    ImageProxy proxy = new ImageProxy(path);
                    Console.WriteLine(proxy.GetSizeOfImage().ToString());
                    OperationStateIsCorrect = true;
                }
                catch (FormatException e)
                {
                    ImageWork work = new ImageWork(path);
                    Console.WriteLine(work.GetSizeOfImage().ToString());
                    OperationStateIsCorrect = true;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("This file is no exist");
                }

            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
