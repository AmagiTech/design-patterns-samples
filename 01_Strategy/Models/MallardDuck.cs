using _01_Strategy.Models.Behaviors;

namespace _01_Strategy.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
            : base(new FlyWithWings(), new QuackVak())
        {
        }
        public override void Display()
        {
            Console.WriteLine("Mallard Duck");
        }
    }
}
