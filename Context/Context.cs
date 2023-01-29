using StrategyWebApp.Interfaces;

namespace StrategyWebApp.Context
{
    public class Context<T, R>
    {
        private IStrategy<T, R> _strategy;
        public Context(IStrategy<T, R> strategy)
        {
            _strategy = strategy;
        }

        public R ExecuteStrategy(T param)
        {
            return _strategy.Execute(param);
        }
    }
}
