namespace StrategyWebApp.Interfaces
{
    public interface IStrategy<T, R>
    {
        R Execute(T param);
    }
}
