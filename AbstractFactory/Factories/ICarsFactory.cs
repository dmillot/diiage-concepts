using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public interface ICarsFactory
    {
        IBreak CreateBreak();

        IRoadster CreateRoadster();
    }
}