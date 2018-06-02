using System;

namespace Task_3
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] valueEn = new string[5];
        private string[] valueUk = new string[5];

        public int Count { get { return key.Length; } }

        public Dictionary()
        {
            key[0] = "книга"; valueEn[0] = "book"; valueUk[0] = "книга";
            key[1] = "ручка"; valueEn[1] = "pen"; valueUk[1] = "ручка";
            key[2] = "солнце"; valueEn[2] = "sun"; valueUk[2] = "сонце";
            key[3] = "яблоко"; valueEn[3] = "apple"; valueUk[3] = "яблуко";
            key[4] = "стол"; valueEn[4] = "table"; valueUk[4] = "стiл";
        }

        public void Add(string ru, string en, string ua)
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] == ru)
                {
                    valueEn[i] = en;
                    valueUk[i] = ua;
                    return;
                }
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + valueEn[index] + " - " + valueUk[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return key[i] + " - " + valueEn[i] + " - " + valueUk[i];
                    if (valueEn[i] == index)
                        return key[i] + " - " + valueEn[i] + " - " + valueUk[i];
                    if (valueUk[i] == index)
                        return key[i] + " - " + valueEn[i] + " - " + valueUk[i];
                }
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стiл"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблyко"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
