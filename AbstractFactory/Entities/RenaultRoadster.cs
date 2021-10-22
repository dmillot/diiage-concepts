using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities
{
    public class RenaultRoadster : IRoadster
    {
        public RenaultRoadster()
        {
            Console.WriteLine("Create Renault Roadster");
        }
    }
}