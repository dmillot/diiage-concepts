using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singletonn.GetInstance();
            var singleton2 = Singletonn.GetInstance();

            Console.WriteLine(singleton1 == singleton2
                ? "Singleton works, both variables contain the same instance."
                : "Singleton failed, variables contain different instances.");
        }
    }
}