using DataStructuresLibrary.LinkedlistImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary.DoubleLinkedList
{
    public class LinkedListIterator<T>
    {
        internal LinkedListNode<T>? CurrentNode;
        public LinkedListIterator()
        {
            CurrentNode = null;
        }
        internal LinkedListIterator(LinkedListNode<T> node)
        {
            CurrentNode = node;
        }
        public T Data() => CurrentNode!.Data;

        public LinkedListIterator<T> Next()
        {
            CurrentNode = CurrentNode!.Next;
            return this;
        }
        internal LinkedListNode<T>? Current() => this.CurrentNode;

    }
}
