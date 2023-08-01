using _01_Strategy.Intefaces;

namespace _01_Strategy.Models.Behaviors
{
    public class QuackVak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Vak vak");
        }
    }
}
