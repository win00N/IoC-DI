namespace IoC_DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var miner = new Miner();

            IAlgorithm algorithm = null;

            Console.WriteLine("Выберите алгоритм: ");
            Console.WriteLine("1 - SHA256 ");
            Console.WriteLine("2 - Ethash");
            var algorithmInput = Console.ReadLine();

            if (int.TryParse(algorithmInput, out int algo))
            {
                switch (algo)
                {
                    case 1:
                        algorithm = new SHA256();
                        break;
                    case 2:
                        algorithm = new Ethash();
                        break;
                    default:
                        throw new ArgumentException("Неизвестный алгоритм.", nameof(algo));
                }
            }

            miner.HashFound += Miner_HashFound;

            Console.WriteLine($"Start: {DateTime.Now.ToShortTimeString()}");
            miner.Start(algorithm);
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

