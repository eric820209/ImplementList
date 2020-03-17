using ImplementList.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ImplementList.List
{
    class FiLo_List : IMyList
    {
        public FiLo_List()
        {
            FirstNode = null;
            LastNode = null;
            Count = 0;
        }
        public Node FirstNode { get; set; }
        public int Count { get; set; }
        public Node LastNode { get ; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(int NewValue)
        {
            Node node = new Node();
            node.Value = NewValue;
            node.NextNode = FirstNode;
            FirstNode = node;
            if (Count == 0)
            {
                LastNode = FirstNode;
            }

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
            Console.WriteLine($"Last={LastNode.Value}");
        }
    }
}
