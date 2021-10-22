using AbstractFactory.Entities;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class PeugeotFactory : ICarsFactory
    {
        public IBreak CreateBreak()
        {
            return new PeugeotBreak();
        }

        public IRoadster CreateRoadster()
        {
            return new PeugeotRoadster();
        }
    }
}