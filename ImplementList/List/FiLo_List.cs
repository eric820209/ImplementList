using ImplementList.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementList.List
{
    class FiLo_List : IMyList
    {
        public FiLo_List()
        {
            FirstNode = null;
            Count = 0;
        }
        public Node FirstNode { get; set; }
        public int Count { get; set; }


        public void Add(int NewValue)
        {
            Node node = new Node();
            node.Value = NewValue;
            node.NextNode = FirstNode;
            FirstNode = node;
            Count += 1;
        }

        public void PrintAll()
        {
            Node TempNode = FirstNode;
            if (Count == 0)
            {
                Console.WriteLine("Exception : List is null");
                return;
            }
            while (TempNode != null)
            {
                Console.Write($" {TempNode.Value} -> ");

                TempNode = TempNode.NextNode;
            };

        }
    }
}
