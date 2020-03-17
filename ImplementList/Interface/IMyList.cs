using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ImplementList.Interface
{
    interface IMyList: IEnumerable
    {
        Node FirstNode { get; set; }
        Node LastNode { get; set; }
        int Count { get; set; }
        void Add(int value);
        void PrintAll();
    }
    public class Node
    {
      public int Value { get; set; }
      public Node NextNode { get; set; }
    }
}
