using DataStructuresLibrary.LinkedlistImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary.DoubleLinkedList
{
    public class LinkedListIterator
    {
        internal LinkedListNode? CurrentNode;
        public LinkedListIterator()
        {
            CurrentNode = null;
        }
        internal LinkedListIterator(LinkedListNode node)
        {
            CurrentNode = node;
        }
        public int Data() => CurrentNode!.Data;

        public LinkedListIterator Next()
        {
            CurrentNode = CurrentNode.Next;
            return this;
        }
        internal LinkedListNode? Current() => this.CurrentNode;

    }
}
