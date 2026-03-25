using System;
using System.Collections.Generic;
using System.Text;

namespace tpModul5_103082400034
{
    internal class HaloGeneric
    {
        public void SapaUser<T>(T data)
        {

            Console.WriteLine($"Halo User: {data}");
        }
    }
}
