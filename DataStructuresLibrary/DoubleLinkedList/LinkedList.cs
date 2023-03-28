 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructuresLibrary.DoubleLinkedList
{
    public class LinkedList
    {
        internal LinkedListNode? Head = null;
        internal LinkedListNode? Tail = null;
        public void PrintLinkedListData()
        {
            StringBuilder sb = new StringBuilder();
            if (Head is null)
            {
                Console.WriteLine("Empty List!!");
                return;
            }
            for (LinkedListIterator itr = Begin(); itr.Current() != null; itr = itr.Next())
            {
                sb.Append(itr.Data());
                sb.Append(",");
            }

            Console.WriteLine(sb.ToString().Trim(','));
        }
        public void InsertLast(int data)
        {
            LinkedListNode? node = new(data);
            if (Head is null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Back = Tail;
                Tail!.Next = node;
                Tail = node; 
            }  
        }
        public void InserAfter(int specificNodeData, int newNodeData)
        {
            LinkedListNode newNode =new LinkedListNode(newNodeData);
            LinkedListNode? specificNode = null;
            if (Head is null)
            {
                Console.WriteLine("Empty List!!");
                return;
            }
            specificNode = Find(specificNodeData);
            if (specificNode is null)
            {
                Console.WriteLine($"Node with {specificNodeData} data is not existe!!");
                return;
            }
            newNode.Next = specificNode.Next;
            newNode.Back= specificNode;
            specificNode.Next = newNode; 
            //If newNode is not the tail that mean it between two nodes so make 
            if (Tail == specificNode)
                Tail = newNode;
            else
            newNode.Next!.Back = newNode;

        }
        public void InsertBefore(int specificNodeData, int newNodeData)
        {
            LinkedListNode newNode = new LinkedListNode(newNodeData);
            LinkedListNode? node = Find(specificNodeData); 
            if (node is null)
            {
                Console.WriteLine($"Node with {specificNodeData} data is not existe!!");
                return;
            } 
            newNode.Next = node;
             
            if (node ==Head)
            {
                Head= newNode;
            }else
            {
                node.Back!.Next = newNode;
            }
            node.Back = newNode;

        }
        public void DeleteNode(int data)
        {
            LinkedListNode? node = Find(data);
            if (node is null)
            {
                Console.WriteLine($"Node with {data} data is not existe!!");
                return;
            }
            if(Head == node && Tail == node) 
                Head = Tail = null;
            else if (Head == node)
            {
                Head = node.Next;
                Head!.Next!.Back = null;
            }
            else
            {
                if (Tail == node)
                {
                    Tail = node.Back;
                    Tail!.Next = null;
                }
                else
                {
                    node.Back!.Next = node.Next;
                    node.Next!.Back = node.Back;
                }
            }
            
        }
        private LinkedListNode? Find(int data)
        {
            for (LinkedListIterator itr = Begin(); itr.Current() != null; itr = itr.Next())
                if (itr.Data() == data) return itr.Current();

            return null;
        } 
        private LinkedListIterator Begin()
        {
            LinkedListIterator itr = new LinkedListIterator(Head!);
            return itr;
        }
    }


}
