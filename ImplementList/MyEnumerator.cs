using ImplementList.Interface;
using ImplementList.List;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ImplementList
{
    public class MyEnumerator : IEnumerator<Node>
    {
        private FiFo_List _list;
        private Node curNode;

        public MyEnumerator(FiFo_List list)
        {
            _list = list;

            Node node = new Node();
            node.NextNode = _list.FirstNode;
            curNode = node;
        }


        public Node Current
        {
            get
            {
                 return curNode;
            }
        }
        
       
        object IEnumerator.Current { get {
                return Current;
            } }

        public bool MoveNext()
        {
            if (curNode.NextNode == null)
            {
                return false;
            }
            else 
            {
                curNode =curNode.NextNode ;
                return true;
            }
        }

        public void Reset()
        {
            curNode = _list.FirstNode;
        }

        public void Dispose()
        {

        }
    }
}
