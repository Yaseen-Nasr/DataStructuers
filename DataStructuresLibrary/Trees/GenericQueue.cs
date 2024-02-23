
namespace DataStructuresLibrary.Trees
{
    internal class GenericQueue<Tdata>
    {
        LinkedList<Tdata> data_list;
        public GenericQueue()
        {
            this.data_list = new LinkedList<Tdata>();
        }
        public void Enqueue(Tdata _data) { this.data_list.AddLast(_data); }
        public Tdata Dequeue()
        {
            Tdata node_data = this.data_list.First.Value;
            this.data_list.RemoveFirst();
            return node_data;
        }
        public Tdata peek()
        {
            if (this.data_list.First is null)
                return default!;

            return this.data_list.First.Value;
        }
        public bool hasData()
        {
            if (this.data_list.Count > 0)
                return true;
            else return false;
        }
        public int size() { return this.data_list.Count; } 

    }
}

 