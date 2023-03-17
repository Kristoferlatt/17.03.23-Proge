using System;
using System.IO;

namespace FileReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faili lugemine");

            try
            {
                
               using (StreamReader sr = new StreamReader("C:/Users/opilane/source/repos/Tuttavad.txt"))
                    //fail kuskil kaustas
                {
                    string line = sr.ReadToEnd();
                    string[] names = line.Split("\n");

                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }
                    Console.WriteLine();

                    Array.Sort(names);
                    Console.WriteLine("Sorteeritud");

                    foreach (string sortedName in names)
                    {
                        Console.WriteLine(sortedName);
                    }
                    sr.Close();
                    using (StreamWriter streamWriter = new StreamWriter("C:/Users/opilane/source/repos/Tuttavad1.txt", true))
                    {
                        int i = 1;
                        foreach( string name in names)
                        {
                            streamWriter.WriteLine(i + ". " + name);
                            i++;
                        }
                        streamWriter.WriteLine("");

                    }
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
