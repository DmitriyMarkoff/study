using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solution1
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Write("Выберите задание (3, 6, 7): ");
        switch (Console.ReadLine())
        {
            case "3":
                {
                    Console.WriteLine("Задание 3.");
                    //Theme3();
                    break;
                }
            case "6":
                {
                    Console.WriteLine("Задание 6.");
                    //Theme6();
                    break;
                }
            case "7":
                {
                    Console.WriteLine("Задание 7.");
                    //Theme7();
                    break;
                }
                
        }
        Console.ReadKey();
        }
    }
}
