

namespace SimpleGC
{
    public class Car
    {
        private int speed;
        private string name;

        public Car()
        {
        }

        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public override string ToString()
        {
            return $"{name} едет со скоростью {speed} Км/ч";
            //return string.Format("{0} едет со скоростью {1} Км/ч", name, speed);
        }
    }
}
