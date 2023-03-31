using System;
using System.Threading;

namespace IoC_DI
{
    /// <summary>
    /// Основной класс выполняющих майнинг.
    /// </summary>
    public class Miner
    {
        /// <summary>
        /// Алгоритм поиска хеша.
        /// </summary>
        private SHA256 sha256;

        /// <summary>
        /// Поток в котором выполняется поиск.
        /// </summary>
        private Thread thread;

        /// <summary>
        /// Событие нахождения хеша.
        /// </summary>
        public event EventHandler<bool> HashFound;

        /// <summary>
        /// Создать экземпляр майнера
        /// </summary>
        public Miner()
        {
            sha256 = new SHA256();
            thread = new Thread(Mine);
        }

        /// <summary>
        /// Начать майнинг.
        /// </summary>
        public void Start()
        {
            thread.Start();
        }

        /// <summary>
        /// Остановить майнинг.
        /// </summary>
        public void Stop()
        {
            thread.Abort();
        }

        /// <summary>
        /// Метод выполняющий майнинг.
        /// </summary>
        private void Mine()
        {
            while (true)
            {
                var hashResult = sha256.Hash();
                HashFound?.Invoke(this, hashResult);
            }
        }
    }
}