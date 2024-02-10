using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsİntro
{
    internal class Mylist<T>
    {
        T[] items; //liste calışabilmesi için array kullanır arka planda. onun için array oluşturduk.
        // consructor=heepte yer açabilmem için diziyi (array) newlemem gerekir onun için
        // assağıdaki gibi bir metod oluştururuz.

        public Mylist()
        {
            items = new T[0];
        }

        public void add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            items[items.Length - 1] = item;
        }
    }
}
