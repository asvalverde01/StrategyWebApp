using StrategyWebApp.Interfaces;

namespace StrategyWebApp.Strategies
{
    public class ConcreteStrategyB : IStrategy<int, double>
    {
        public double Execute(int param)
        {
            return param * 1.5;
        }
    }
}
