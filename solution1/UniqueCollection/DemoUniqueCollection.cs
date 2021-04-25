using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace UniqueCollection
{
    public class DemoUniqueCollection
    {
        public void FillIntCollection(int count)
        {
            UniqueCollectionClass<int> IntCollection = new UniqueCollectionClass<int>();
            for (int i = 0; i < count; i++)
            {
                IntCollection.Add(i);
            }
            IntCollection.Print();
        }
        public void run()
        {
            FillIntCollection(10);
            Console.ReadKey();
        }
    }
}
