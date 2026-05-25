using SOLID_By_Example.I_InterfaceSegregation.After.Interfaces;
using System;

namespace SOLID_By_Example.I_InterfaceSegregation.After.Entitties
{
    public class HumanWorker : IWorkable, IEatable, ISleepable
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
