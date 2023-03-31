 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructuresLibrary.DoubleLinkedList
{
    public class LinkedList<T>  
    {
        public LinkedListNode<T>? Head = null;
        public LinkedListNode<T>? Tail = null;
        public int Length { get; private set; }
        public void PrintLinkedListData()
        {
            StringBuilder sb = new StringBuilder();
            if (Head is null)
            {
                Console.WriteLine("Empty List!!");
                return;
            }
            for (LinkedListIterator<T> itr = Begin(); itr.Current() != null; itr = itr.Next())
            {
                sb.Append(itr.Data());
                sb.Append(",");
            }

            Console.WriteLine(sb.ToString().Trim(','));
        }
        public void InsertLast(T data)
        {
            LinkedListNode<T>? node = new(data);
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
            Length++;
        }
        public void InserAfter(T specificNodeData, T newNodeData)
        {
            LinkedListNode<T> newNode =new LinkedListNode<T>(newNodeData);
            LinkedListNode<T>? specificNode = null;
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
            Length++;
        }
        public void InsertBefore(T specificNodeData, T newNodeData)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(newNodeData);
            LinkedListNode<T>? node = Find(specificNodeData); 
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
            Length++;
        }
        public void DeleteNode(T data)
        {
            LinkedListNode<T>? node = Find(data);
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
            Length--;
        }
        private LinkedListNode<T>? Find(T data)
        {
            for (LinkedListIterator<T> itr = Begin(); itr.Current() != null; itr = itr.Next())
                if (itr.Data()!.Equals(data)) return itr.Current();

            return null;
        } 
        private LinkedListIterator<T> Begin()
        {
            LinkedListIterator<T> itr = new LinkedListIterator<T>(Head!);
            return itr;
        }
    }


}
