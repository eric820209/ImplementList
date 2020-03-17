using ImplementList.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ImplementList.List
{
    class FiFo_List : IMyList
    {
        public FiFo_List()
        {
            FirstNode = null;
            LastNode = null;
            Count = 0;
        }
        public Node FirstNode { get; set; }
        public int Count { get; set; }
        public Node LastNode { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(int NewValue)
        {
            Node NewNode = new Node();
            NewNode.Value = NewValue;
            if (Count == 0)
            {
                FirstNode = NewNode;
                LastNode = NewNode;
            }
            else
            {
                LastNode.NextNode = NewNode;
                LastNode = NewNode;
            }
            Count++;
        }


        public void PrintAll()
        {
            var CurrentNode = FirstNode;
            while (CurrentNode != null)
            {
                Console.Write($" {CurrentNode.Value} -> ");
                CurrentNode = CurrentNode.NextNode;
            }
            Console.WriteLine($"Last={LastNode.Value}");
        }
    }
}
