using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Строка для изменения кодировок.
            string leUnicodeStr = "здорово!";

            // Настройки кодировок.

            // Unicode - Получает кодировку для формата UTF-16 с прямым порядком байтов.
            Encoding leUnicode = Encoding.Unicode;

            // UTF8 - Получает кодировку для формата UTF-8.
            Encoding utf8 = Encoding.UTF8;

            // Массивы байтов для хранения конвертированной строки.
            string utf8String = utf8.GetString(leUnicode.GetBytes(leUnicodeStr));			// В UTF8.

            // Выводим содержимое массивов на экран.
            Console.WriteLine("Исходная строка: {0}\n", leUnicodeStr);


            Console.WriteLine("Байты UTF: {0}", utf8String);


            Console.WriteLine("Обратно раскодированное слово: {0}", leUnicode.GetString(utf8.GetBytes(utf8String)));

            StreamWriter writer = new StreamWriter(@"D:\test.txt", false, Encoding.UTF8);
            writer.WriteLine(leUnicodeStr);
            writer.Close();


            // Delay.
            Console.ReadLine();
        }
    }
}
