using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Registry
{
    class Program
    {
        static void Main(string[] args)
        {
            // Совершаем навигацию в нужное место и открываем его для записи.
            RegistryKey myKey = Registry.CurrentUser;
            RegistryKey wKey = myKey.OpenSubKey("Software", true);
            RegistryKey newKey = wKey.CreateSubKey("CyberBionicSystematics");

            // Совершаем запись в реестр.
            newKey.SetValue("TheStringName", "I contain string value.");
            newKey.SetValue("TheInt32Name", 1234567890);

            // Тип можно указать явно.
            newKey.SetValue("AnotherName", 1234567890, RegistryValueKind.String);

            wKey.Close();
            newKey.Close();

            // ---------------------------------------------------------------------------

            // Совершаем навигацию по реестру и открываем ключ для чтения,
            // можно сразу указать весь путь, а не совершать навигацию поэтапно.
            myKey = Registry.CurrentUser;
            wKey = myKey.OpenSubKey(@"Software\CyberBionicSystematics");

            // Читаем данные и конвертируем в нужный формат.
            string Str = wKey.GetValue("TheStringName") as string;
            int Int = Convert.ToInt32(wKey.GetValue("TheInt32Name"));
            String Ant = wKey.GetValue("AnotherName") as String;

            wKey.Close();

            // Покажем содержимое, чтобы убедиться в том, что чтение прошло успешно.
            Console.WriteLine("String: {0}\nInt32: {1}\nAnother: {2}", Str, Int, Ant);

            // Задержка.
            Console.ReadKey();
        }
    }
}
