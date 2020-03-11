using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementList.Interface
{
    interface IMyList
    {
        Node FirstNode { get; set; }
        int Count { get; set; }
        void Add(Node node);
    }
    class Node
    {
       int Value { get; set; }
       Node NextNode { get; set; }
    }
}
