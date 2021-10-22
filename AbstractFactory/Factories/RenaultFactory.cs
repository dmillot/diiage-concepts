using AbstractFactory.Entities;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class RenaultFactory : ICarsFactory
    {
        public IBreak CreateBreak()
        {
            return new RenaultBreak();
        }

        public IRoadster CreateRoadster()
        {
            return new RenaultRoadster();
        }
    }
}