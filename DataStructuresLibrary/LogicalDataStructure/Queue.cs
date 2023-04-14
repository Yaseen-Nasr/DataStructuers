using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary.LogicalDataStructure
{
    public class Queue
    {
        private LinkedlistImp.LinkedList dataList;
        public Queue(bool uniqe)
        {
            dataList= new LinkedlistImp.LinkedList(uniqe);
        }
        public  void Enqueue(int data)
        {
            this.dataList.InsertLast(data);
        }
        public int? Dequeue( )
        {
            if(dataList.Head is null)
                return null;
            int data = this.dataList.Head!.Data;
            dataList.DeleteHead();
            return data;
        }
        public int? Peek()
        {
            if (dataList.Head is null)
                return null; 
            return this.dataList.Head!.Data;
        }

        public bool HasData()
        {
            return dataList.length > 0 ? true:false;
        }
        public int Size()
        {
            return dataList.length;
        }
        public void Print()
        {
            dataList.PrintLinkedListData();
        }
    }
}
