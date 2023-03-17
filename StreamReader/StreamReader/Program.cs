using System;
using System.Diagnostics.Metrics;
using System.IO;
using static System.Net.WebRequestMethods;

namespace FileReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faili lugemine");
            string line;
            int lineNumber = 1;

            try
            {
                StreamReader sr = new StreamReader("C:/Users/opilane/source/repos/luuletus.txt");
                while ((line = sr.ReadLine())!= null)
                {
                    int symbolsCount = line.Length;
                    Console.WriteLine($"{lineNumber}. {line} ({symbolsCount} sümbolit)");
                    lineNumber++;


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("faili ei saa lugeda");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}


