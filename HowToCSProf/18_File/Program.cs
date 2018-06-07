using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_File
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем новый файл в корневом каталоге диска D:
            var file = new FileInfo(@"D:\Test.txt");

            var stream = file.Create();

            // Выводим основную информацию о созданном файле.            
            Console.WriteLine("Full Name   : {0}", file.FullName);
            Console.WriteLine("Attributes  : {0}", file.Attributes.ToString());
            Console.WriteLine("CreationTime: {0}", file.CreationTime);


            Console.WriteLine("Нажмите любую клавишу для удаления файла.");
            Console.ReadKey();

            stream.Close();

            // Удаляем файл.
            file.Delete();

            Console.WriteLine("Файл успешно удален.");

            // Delay.
            Console.ReadKey();
        }
    }
}
