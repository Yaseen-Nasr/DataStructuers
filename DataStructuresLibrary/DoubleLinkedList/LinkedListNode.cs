using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary.DoubleLinkedList
{
    public class LinkedListNode<T>
    {
        public T Data { get; }
        public LinkedListNode<T>? Next { get; set; }
        public LinkedListNode<T>? Back { get; set; }
        public LinkedListNode(T data)
        {
            Data = data;
            Next = null;
            Back = null;
        }
    }
}
