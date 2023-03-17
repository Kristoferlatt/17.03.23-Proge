using System.Text;
using System.Text.RegularExpressions;

namespace RegexStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta otsitav sõna");
            Console.WriteLine("Kasuta formaati s--a, Kus - tähistab tundmatut tähte.");

            string choice = Console.ReadLine();
            WordFinder(choice);
        }

        private static void WordFinder(string choice)
        {
            Regex regularExpression = new Regex(@"\b" + choice.Replace("-", "\\w"),
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/source/repos/lemmad.txt", Encoding.Default))
                {
                    while(sr.EndOfStream == false)
                    {
                        string Line = sr.ReadLine();
                        if (Line.Length == choice.Length)
                        {
                            MatchCollection matchCollection = regularExpression.Matches(Line);
                            if (matchCollection.Count >0)
                            {
                                Console.WriteLine(Line);
                            }
                        }
                    }
                    sr.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ei ole olemas sellise pikkusega sõna");
                Console.WriteLine(ex.Message);

                throw;
            }
            Console.ReadKey();
        }
    }
}