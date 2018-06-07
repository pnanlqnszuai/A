using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CreateDeleteDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo(@"D:\TESTDIR");
            Console.WriteLine(directory.FullName);
            // Создание в TESTDIR новых подкаталогов.
            if (directory.Exists)
            {
                // Создаем D:\TESTDIR\SUBDIR.
                directory.CreateSubdirectory("SUBDIR");

                // Создаем D:\TESTDIR\MyDir\SubMyDir.
                directory.CreateSubdirectory(@"MyDir\SubMyDir");

                Console.WriteLine("Директории созданы.");
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }

            // Выводим информацию о дисках.
            Console.WriteLine("\nГотовимся удалять:\n");
            Console.WriteLine(directory.FullName + @"\MyDir\SubMyDir");
            Console.WriteLine(directory.FullName + @"\SUBDIR");
            Console.WriteLine("\nНажмите Enter для удаления.\n");

            // Задержка перед удалением.
            Console.ReadKey();

            try
            {
                // Удаление каталогов.
                Directory.Delete(directory.FullName + @"\SUBDIR");

                // Второй параметр определяет, будут ли удалены также и все вложенные подкаталоги. 
                Directory.Delete(directory.FullName + @"\MyDir", true);

                Console.WriteLine("Каталоги успешно удалены.");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

            // Delay.
            Console.ReadKey();
        }
    }
}
