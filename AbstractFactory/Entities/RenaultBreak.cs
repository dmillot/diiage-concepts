using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities
{
    public class RenaultBreak : IBreak
    {
        public RenaultBreak()
        {
            Console.WriteLine("Create Renault Break");
        }
    }
}