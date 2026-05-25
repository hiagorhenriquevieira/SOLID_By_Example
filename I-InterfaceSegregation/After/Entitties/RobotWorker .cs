using SOLID_By_Example.I_InterfaceSegregation.After.Interfaces;
using System;

namespace SOLID_By_Example.I_InterfaceSegregation.After.Entitties
{
    public class RobotWorker : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }
}