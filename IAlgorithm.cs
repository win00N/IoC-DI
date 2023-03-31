namespace IoC_DI
{
    /// <summary>
    /// Базовый интерфейс криптоалгоритма хеш-функции.
    /// </summary>
    public interface IAlgorithm
    {
        bool Hash();
    }
}
