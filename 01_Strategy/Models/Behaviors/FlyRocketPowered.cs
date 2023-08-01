﻿using _01_Strategy.Intefaces;

namespace _01_Strategy.Models.Behaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with a rocket!");
        }
    }
}
