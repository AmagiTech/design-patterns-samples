using _01_Strategy.Intefaces;

namespace _01_Strategy.Models
{
    public abstract class Duck
    {
        IFlyBehavior _flyBehavior;
        IQuackBehavior _quackBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }
        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public abstract void Display();
        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float!");
        }
    }
}
