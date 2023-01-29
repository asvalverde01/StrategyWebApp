using StrategyWebApp.Interfaces;

namespace StrategyWebApp.Strategies
{
    public class ConcreteStrategyA : IStrategy<int, double>
    {
        public double Execute(int param)
        {
            return param * 1.2;
        }
    }
}
