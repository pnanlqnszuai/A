using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            var my = CultureInfo.CurrentCulture;
            var ua = new CultureInfo("uk-UA");

            string sentence = File.ReadAllText("product.txt", Encoding.Default);

            Console.WriteLine(sentence);

            Console.WriteLine(new string('-', 25));

            string pattern = @"[0-9]+[\.\,][0-9]+";

            string sentenceMy = Regex.Replace(sentence, pattern, (m) => double.Parse(m.Value).ToString("C", my));
            string sentenceUa = Regex.Replace(sentence, pattern, (m) => double.Parse(m.Value).ToString("C", ua));

            Console.WriteLine(sentenceMy);

            Console.WriteLine(new string('-', 25));

            Console.WriteLine(sentenceUa);

            Console.ReadKey();
        }
    }
}
