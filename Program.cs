namespace IoC_DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Miner miner = null;

            Console.WriteLine("Выберите алгоритм: ");
            Console.WriteLine("1 - SHA256 ");
            Console.WriteLine("2 - Ethash");
            var algorithmInput = Console.ReadLine();

            if (int.TryParse(algorithmInput, out int algorithm))
            {
                switch (algorithm)
                {
                    case 1:
                        miner = new Miner(new SHA256());
                        break;
                    case 2:
                        miner = new Miner(new Ethash());
                        break;
                    default:
                        throw new ArgumentException("Неизвестный алгоритм.", nameof(algorithm));
                }
            }

            miner.HashFound += Miner_HashFound;

            Console.WriteLine($"Start: {DateTime.Now.ToShortTimeString()}");
            miner.Start();
        }

        private static void Miner_HashFound(object sender, bool e)
        {
            if (e)
            {
                Console.WriteLine("хеш найден");
            }
            else
            {
                Console.WriteLine("Некорректный хеш");
            }
        }
    }
}

