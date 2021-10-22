using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities
{
    public class PeugeotBreak : IBreak
    {
        public PeugeotBreak()
        {
            Console.WriteLine("Create Peugeot Break");
        }
    }
}