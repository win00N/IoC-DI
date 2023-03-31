namespace IoC_DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var miner = new Miner();
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

