using _01_Strategy.Intefaces;

namespace _01_Strategy.Models.Behaviors
{
    public class QuackMute : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Silence!!!!");
        }
    }
}
