using System;
using System.Collections.Generic;
using System.Text;

namespace tpModul5_103082400034
{
    internal class DataGeneric<T>
    {
        public T Data;
        public DataGeneric(T data)
        {

            Data = data;
        }

        public  void PrintData()
        {


            Console.WriteLine("Data yang dipanggil adalah : " + Data);
        }
    }
}
