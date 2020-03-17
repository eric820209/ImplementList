using ImplementList.Interface;
using ImplementList.List;
using System;
using System.Collections.Generic;

namespace ImplementList
{
    class Program
    {
        static void Main(string[] args)
        {
            FiLo_List List1 = new FiLo_List();
            List1.Add(1);
            List1.Add(2);
            List1.Add(3);
            List1.Add(4);
            List1.Add(5);
            List1.PrintAll();
            Console.WriteLine("======================");

            FiFo_List List2 = new FiFo_List();
            List2.Add(1);
            List2.Add(2);
            List2.Add(3);
            List2.Add(4);
            List2.Add(5);
            List2.PrintAll();


            foreach (Node a in List2)
            {
                Console.Write($"{a.Value}");
            }
            Console.ReadLine();
        }
    }
}
