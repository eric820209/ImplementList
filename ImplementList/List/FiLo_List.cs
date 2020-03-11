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

        public void Add(int value)
        {
            throw new NotImplementedException();
        }

        public void PrintAll()
        {
            throw new NotImplementedException();
        }
    }
}
