using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary.LogicalDataStructure
{
    public class Stack
    {
        private LinkedlistImp.LinkedList dataList;
        public Stack(bool uniqe)
        {
            this.dataList = new(uniqe);

        }
        public void Push(int data)
        {
            this.dataList.InsertFirst(data);
        }
        public int Pop()
        {
            if(dataList.length == 0) return -1;
            var headData =this.dataList.Head!.Data;
            this.dataList.DeleteHead();
            return headData;
        }
        public int Peek()
        {
            if (dataList.length == 0) return -1;
            var headData = this.dataList.Head!.Data;
            return headData;
        }
        public bool IsEmpty() => this.dataList.length == 0;
         
        public void Print() =>
            this.dataList.PrintLinkedListData();
        public int Size() => dataList.length;
    }
}
