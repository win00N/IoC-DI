using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_DI
{
    /// <summary>
    /// Базовый интерфейс криптоалгоритма хеш-функции.
    /// </summary>
    internal interface IAlgorithm
    {
        bool Hash();
    }
}
