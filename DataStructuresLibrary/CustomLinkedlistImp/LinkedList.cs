using System.Text;

namespace DataStructuresLibrary.LinkedlistImp
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
                Tail!.Next = node;
                Tail = node;
            }
        }
        public void InserAfter(int specificNodeData, int newNodeData)
        {
            LinkedListNode? newNode = new(newNodeData);
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
            specificNode.Next = newNode;
            if (Tail == specificNode)
                Tail = newNode;
        }
        public void InsertBefore(int specificNodeData, int newNodeData)
        {
            LinkedListNode? newNode = new(newNodeData);
            LinkedListNode? specificNode = null;
            LinkedListNode? parentNode = null;
            if (Head is null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            } 
            specificNode = Find(specificNodeData);
            if (specificNode is null)
            {
                Console.WriteLine($"Node with {specificNodeData} data is not existe!!");
                return;
            }
            if (specificNode == Head)
            {
                newNode.Next = specificNode;
                Head = newNode;
                return;
            }
 
            parentNode = FindParent(specificNodeData);
            newNode.Next = parentNode!.Next;
            parentNode.Next = newNode;
        }
        public void DeleteNode(int data)
        {
            LinkedListNode? node=Find(data); 
            if (node is null) 
            {
                Console.WriteLine($"Node with {data} data is not existe!!");
                return;
            }
            if (node == Head && node == Tail)
                Head = Tail = null;
            else if (node == Head)
                Head = Head!.Next;
            else
            {
                LinkedListNode? parent = FindParent(data);
                if (node == Tail)
                {
                    parent!.Next = null;
                    Tail = parent;
                
                }
                else
                    parent!.Next = node!.Next;
            } 
        }
        private LinkedListNode? Find(int data)
        {
            for (LinkedListIterator itr = Begin(); itr.Current() != null; itr = itr.Next())
                if (itr.Data() == data) return itr.Current();

            return null;
        }
        private LinkedListNode? FindParent(int data)
        {
            for (LinkedListIterator itr = Begin(); itr.Current() != null; itr = itr.Next()) 
                if (itr.Current()!.Next!.Data == data)   
                    return itr.Current(); 
            
            return null; 
        }
        private LinkedListIterator Begin()
        {
            LinkedListIterator itr = new LinkedListIterator(Head!);
            return itr;
        }
    }


}
