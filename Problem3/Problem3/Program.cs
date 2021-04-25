using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 10000; long time;
            var FillListInstance = new FillList();
            var FillDictionaryInstance = new FillDictionary();
            time = FillListInstance.FillListInternalGetHashCode(n, true);
            Console.WriteLine("time_FillListWithInternalHashCode[{0}]={1}", n, time);
            time = FillListInstance.FillListInternalGetHashCode(n, false);
            Console.WriteLine("time_FillListWithConstHashCode[{0}]={1}", n, time);
            time = FillDictionaryInstance.FillDictionaryInternalGetHashCode(n, true);
            Console.WriteLine("time_FillDictionaryWithInternalHashCode[{0}]={1}", n, time);
            time = FillDictionaryInstance.FillDictionaryInternalGetHashCode(n, false);
            Console.WriteLine("time_FillDictionaryWithConstHashCode[{0}]={1}", n, time);

            Console.ReadKey();
        }
    }

}
