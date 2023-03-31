namespace IoC_DI;

/// <summary>
/// Основной класс выполняющих майнинг.
/// </summary>
public class Miner
{
    /// <summary>
    /// Алгоритм поиска хеша.
    /// </summary>
    public IAlgorithm Algorithm { get; set; }

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
    /// 
    public Miner()
    {
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
            var hashResult = Algorithm.Hash();
            HashFound?.Invoke(this, hashResult);
        }
    }
}
