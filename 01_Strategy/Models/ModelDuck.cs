using _01_Strategy.Models.Behaviors;

namespace _01_Strategy.Models
{
    internal class ModelDuck : Duck
    {
        public ModelDuck()
            : base(new FlyNoWay(), new QuackMute())
        {
        }
        public override void Display()
        {
            Console.WriteLine("Model Duck");
        }
    }
}
