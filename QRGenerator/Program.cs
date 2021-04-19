using System;
using System.Drawing;
using System.Drawing.Imaging;
using DotImaging;
using QRCoder;

namespace QRGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("QR Code Generator");
                Console.WriteLine("Please choose a option");
                Console.WriteLine("A = Generator a URL QR");
                Console.WriteLine("Q = Quit the application");
            
            var responseA = Console.ReadKey();
            switch (responseA.Key)
            {
                case ConsoleKey.A:
                    Console.Clear();
                    Console.WriteLine("Please choose a option");
                    Console.WriteLine("A = With logo");
                    Console.WriteLine("B = Without logo");
                    var responseB = Console.ReadKey();
                    var QREngine = new QRGenerator.Methods.GenerateURL();
                    switch (responseB.Key)
                    {
                        case ConsoleKey.A:
                            Console.Clear();
                            Console.WriteLine("Enter a URL");
                            string url1 = Console.ReadLine();
                            Console.WriteLine("Enter a path to image");
                            string path1 = Console.ReadLine();
                            var result1 = QREngine.CreateWithImage(url1,path1);
                            Console.WriteLine("Please enter a save location");
                            string savepath1 = Console.ReadLine();
                            result1.Save(savepath1, ImageFormat.Png);
                            break;
                        case ConsoleKey.B:
                            Console.Clear();
                            Console.WriteLine("Enter a URL");
                            string url2 = Console.ReadLine();
                            var result2 = QREngine.CreateWithoutImage(url2);
                            Console.WriteLine("Please enter a save location");
                            string savepath2 = Console.ReadLine();
                            result2.Save(savepath2, ImageFormat.Png);
                            break;
                    }
                    break;
                case ConsoleKey.B:
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
            }
            
        }
    }
}
