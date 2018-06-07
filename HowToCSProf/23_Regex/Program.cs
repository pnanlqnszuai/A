using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _23_Regex
{
    /*

            System.Text.RegularExpressions - пространство имён где, хранятся нужные методы для работы с Regex'ами.  

            МЕТАСИМВОЛЫ - это символы для составления Шаблона поиска.

            \d    Определяет символы цифр. 
            \D    Определяет любой символ, который не является цифрой. 
            \w    Определяет любой символ цифры, буквы или подчеркивания. 
            \W    Определяет любой символ, который не является цифрой, буквой или подчеркиванием. 
            \s    Определяет любой непечатный символ, включая пробел. 
            \S    Определяет любой символ, кроме символов табуляции, новой строки и возврата каретки.
             .    Определяет любой символ кроме символа новой строки. 
            \.    Определяет символ точки.

            КВАНТИФИКАТОРЫ - это символы которые определяют, где и сколько раз необходимое вхождение символов может встречаться.

            ^ - c начала строки. 
            $ - с конца строки. 
            + - одно и более вхождений подшаблона в строке. 
            | - символ для указания вариантов шаблона (ИЛИ). 

    */

    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^\d*\D+\d+$");

            Console.WriteLine(regex.IsMatch("asd123"));

            Console.WriteLine(Regex.Replace("test123aaa4x5x6bbb789ccc",  // Исходная строка.
                                            @"\d+",                      // Шаблон.
                                             " "));                      // Символ для замены.

            Console.WriteLine(Regex.Replace("02/05/1982",                                 // Исходная строка. 
                               @"(?<месяц>\d{1,2})\/(?<день>\d{1,2})\/(?<год>\d{2,4})",   // Шаблон.
                                "${день}-${месяц}-${год}"));

            Console.WriteLine(Regex.Replace("123456",                                    // Исходная строка.
                                            @"\d",                                                 // Шаблон.
                                            m => (int.Parse(m.Value) + 1).ToString()));            // Функция изменения совпадения


            // ------------------------------------------------------------------------------

            string input = "";
            input += "<a href='http://cbsystematics.com'>Home-page</a>";
            input += "<a href='http://google.com'>Search</a>";
            input += "<a href='https://ya.ru'>Yandex</a>";
            input += "<a href='https://yandex.ru'>Yandex Full</a>";
            input += "<a href='http://microsoft.com'>Microsoft</a>";

            regex = new Regex(@"href='(?<link>\S+)'>(?<text>\S+)</a>");
            Console.WriteLine(input);

            // for(текущее_значение_m; условие; действие_при_каждой_итерации).
            for (var m = regex.Match(input); m.Success; m = m.NextMatch())
            {
                // {0,-25} - значит что выделить 25 знакомест под вывод {0}. (-) - значит "прижаться" влево :)
                Console.WriteLine("ССЫЛКА: {0,-25} на: {1,-4} позиции с именем: {2}", m.Groups["link"],
                                                                                      m.Groups["link"].Index,
                                                                                      m.Groups["text"]);
            }

            Console.WriteLine(new string('-', 25));

            foreach (Match m in regex.Matches(input))
            {
                Console.WriteLine("ССЫЛКА: {0,-25} на: {1,-4} позиции с именем: {2}", m.Groups["link"],
                                  m.Groups["link"].Index,
                                  m.Groups["text"]);
            }

            Console.WriteLine(new string('-', 20));
            var htmlQuery = from Match m in regex.Matches(input)
                            where m.Groups["link"].Value.StartsWith("https")
                            select m;


            foreach (var m in htmlQuery)
            {
                Console.WriteLine("ССЫЛКА: {0,-25} на: {1,-4} позиции с именем: {2}", m.Groups["link"],
                                 m.Groups["link"].Index,
                                 m.Groups["text"]);
            }
            // Delay.
            Console.ReadKey();

        }
    }
}
