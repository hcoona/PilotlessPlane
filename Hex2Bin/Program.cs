using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex2Bin
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                PrintUsage();
                Environment.Exit(1);
            }
            else
            {
                ConvertToBinary(args[0]);
            }
        }

        private static void ConvertToBinary(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("Cannot find file!");
            }
            else
            {
                var hexes = File.ReadAllText(filename)
                    .Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                var bytes = hexes
                    .Where(h => h.Length == 2)
                    .Select(h => byte.Parse(h, NumberStyles.HexNumber))
                    .ToArray();
                File.WriteAllBytes(filename + ".bin", bytes);
            }
        }

        private static void PrintUsage()
        {
            Console.WriteLine("Usage:");
            Console.Write('\t');
            Console.WriteLine("Hex2Bin.exe [input-filename]");
        }
    }
}
