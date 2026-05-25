using SOLID_By_Example.I_InterfaceSegregation.Before.Interfaces;
using System;

namespace SOLID_By_Example.I_InterfaceSegregation.Before.Entities
{
    public class HumanWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Human is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Human is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("Human is sleeping.");
        }
    }
}