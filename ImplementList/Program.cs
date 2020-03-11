using ImplementList.List;
using System;
using System.Collections.Generic;

namespace ImplementList
{
    class Program
    {
        static void Main(string[] args)
        {
            FiFo_List List1 = new FiFo_List();
            List1.Add(1);
            List1.Add(2);
            List1.Add(3);
            List1.Add(4);
            List1.Add(5);
            List1.PrintAll();
            List1.PrintAll();
            Console.Read();
        }
    }
}
