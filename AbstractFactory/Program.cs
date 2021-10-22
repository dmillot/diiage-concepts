using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarsFactory factory = new RenaultFactory();
            factory.CreateBreak();
        }
    }
}