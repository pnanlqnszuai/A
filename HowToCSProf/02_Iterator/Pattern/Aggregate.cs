// "Aggregate"

namespace _02_Iterator
{
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
  
        public abstract object this[int index] { get; set; }
    }
}
