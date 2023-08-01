using _01_Strategy.Intefaces;

namespace _01_Strategy.Models.Behaviors
{
    public class QuackSqueak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
