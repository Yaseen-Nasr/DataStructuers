using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary.DoubleLinkedList
{
    internal class LinkedListNode
    {
        public int Data { get; }
        public LinkedListNode? Next { get; set; }
        public LinkedListNode? Back { get; set; }
        public LinkedListNode(int data)
        {
            Data = data;
            Next = null;
            Back = null;
        }
    }
}
