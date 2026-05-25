using SOLID_By_Example.I_InterfaceSegregation.Before.Interfaces;
using System;

namespace SOLID_By_Example.I_InterfaceSegregation.Before.Entities
{
    public class RobotWorker : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException("Robots do not eat.");
        }

        public void Sleep()
        {
            throw new NotImplementedException("Robots do not sleep.");
        }

        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }
}
