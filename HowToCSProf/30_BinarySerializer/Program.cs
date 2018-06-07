using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _30_BinarySerializer
{
    public enum Mode
    {
        Lux, Sport
    }

    // Класс Car будет доступен для сериализации.
    [Serializable]
    public class Car
    {
        protected int speed;
        protected string name;

        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }

    // Класс Mersedes будет доступен для сериализации. 
    [Serializable]
    public class Mersedes : Car
    {
        // Два режима работы - Спорт и Люкс.
        protected Mode mode;

        public Mersedes(string name, int speed, Mode mode)
            : base(name, speed)
        {
            this.mode = mode;
        }

        public void SetMode(Mode mode)
        {
            this.mode = mode;
            Console.WriteLine(this.mode);
        }

        public void ShowMode()
        {
            Console.WriteLine(this.mode);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mersedes auto = new Mersedes("G500", 250, Mode.Lux);
            auto.ShowMode();
            

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("CarData.dat"))
            {
                // Cериализация.
                formatter.Serialize(stream, auto);
            }


            using (FileStream stream = File.OpenRead("CarData.dat"))
            {
                auto = formatter.Deserialize(stream) as Mersedes;

                Console.WriteLine("Имя     : " + auto.Name);
                Console.WriteLine("Скорость: " + auto.Speed);
            }


            // Задержка.
            Console.ReadKey();
        }
    }
}
