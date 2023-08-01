using _01_Strategy.Models.Behaviors;
using _01_Strategy.Models;

Duck duck = new MallardDuck();
duck.Display();
duck.PerformQuack();
duck.PerformFly();

Console.WriteLine();

Duck duck2 = new ModelDuck();
duck2.Display();
duck2.PerformQuack();
duck2.PerformFly();

Console.WriteLine();

Console.WriteLine("Run Time Modify");
Console.WriteLine();

duck2.SetQuackBehavior(new QuackSqueak());
duck2.SetFlyBehavior(new FlyRocketPowered());

duck2.Display();
duck2.PerformQuack();
duck2.PerformFly();