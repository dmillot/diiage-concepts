using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities
{
    public class PeugeotRoadster : IRoadster
    {
        public PeugeotRoadster()
        {
            Console.WriteLine("Create Peugeot Roadster");
        }
    }
}