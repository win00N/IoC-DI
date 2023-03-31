namespace IoC_DI
{
    internal class Ethash : IAlgorithm
    {
        public bool Hash()
        {
            var random = new Random();
            Thread.Sleep(1000);
            var hash = random.Next();
            if (hash <= 10000)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return nameof(Ethash);
        }
    }
}
