using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections;
using System.Linq;
using System.Text;

namespace UniqueCollection
{
    public class UniqueCollectionClass<T>
    {
        private Collection<T> _collection;

        public UniqueCollectionClass()
        {
            _collection = new Collection<T>();
        }
        
        public void Add(T element)
        {
            if (element == null) throw new ArgumentNullException("Нельзя добавить null в колллекцию.");
            else
            {
                if (_collection.Contains(element))
                    throw new ArgumentException("Не удалось добавить " + element + ".\nКоллекция может содержать только уникальные экземпляры.");
                else _collection.Add(element);
            }
        }

        public void Print()
        {
            Console.WriteLine("Коллекция содержит элементы типа{0}:", typeof(T));
            foreach (T item in _collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
