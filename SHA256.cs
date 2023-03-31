namespace IoC_DI
{
    /// <summary>
    /// Алгоритм вычисления хеш-функции SHA256.
    /// </summary>
    public class SHA256 : IAlgorithm
    {
        /// <summary>
        /// Вычисление нового хеша.
        /// </summary>
        /// <returns>Успешность нахождения хеша.</returns>
        public bool Hash()
        {
            var guid = Guid.NewGuid();
            Thread.Sleep(5000);
            var hash = guid.GetHashCode();
            if (hash <= 10000)
            {
                return true;
            }

            return false;

        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns>Имя алгоритма.</returns>
        public override string ToString()
        {
            return nameof(SHA256);
        }
    }
}