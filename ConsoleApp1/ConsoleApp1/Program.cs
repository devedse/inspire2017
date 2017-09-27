using System;
using System.IO;
using Compressor;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly Zipper Zipper = new Zipper();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Zipper.CompressDing();
        }
    }
}
