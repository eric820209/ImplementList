using ImplementList.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementList.List
{
    class FiFo_List : IMyList
    {
        public FiFo_List()
        {
            FirstNode = null;
            Count = 0;
        }
        public Node FirstNode { get; set; }
        public int Count { get; set; }


        public void Add(int NewValue)
        {
          
        }

        public  void  PrintAll()
        {
          
        }
    }
}
