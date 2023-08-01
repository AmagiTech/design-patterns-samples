using _01_Strategy.Intefaces;

namespace _01_Strategy.Models.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
