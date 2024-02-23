
using System.Xml.Linq;

namespace DataStructuresLibrary.Trees
{
    public class BinaryTree<TData> where TData : IComparable<TData>
    {
        private TreeNode<TData> RootNode { get; set; }
        public void Insert(TData data)
        {
            TreeNode<TData> newNode = new(data);

            if (RootNode is null)
            {
                RootNode = newNode;
                return;
            }
            GenericQueue<TreeNode<TData>> queue = new();
            queue.Enqueue(RootNode);
            while (queue.hasData())
            {
                var currenNode = queue.Dequeue();
                if (currenNode.LeftNode is null)
                {
                    currenNode.AddToLeft(newNode);
                    break;
                }
                else
                    queue.Enqueue(currenNode.LeftNode);


                if (currenNode.RightNode is null)
                {
                    currenNode.AddToRight(newNode);
                    break;
                }
                else
                    queue.Enqueue(currenNode.RightNode);

            }


        }
        public int Height()
        {
            return InternalHeight(this.RootNode);
        }
        public void PreOrderDepthTraversal()
        {
            PreOrderTraversal(this.RootNode);
            Console.WriteLine();
        }
        public void InOrderDepthTraversal()
        {
            InOrderTraversal(this.RootNode);
            Console.WriteLine();
        }
        public void PostOrderDepthTraversal()
        {
            PreOrderTraversal(this.RootNode);
            Console.WriteLine();
        }
         

        public void Print(int topMargin = 2, int LeftMargin = 2)
        {
            if (this.RootNode == null) return;
            int rootTop = Console.CursorTop + topMargin;
            var last = new List<NodeInfo>();
            var next = this.RootNode;
            for (int level = 0; next != null; level++)
            {
                var item = new NodeInfo { Node = next, Text = next.Data.ToString() };
                if (level < last.Count)
                {
                    item.StartPos = last[level].EndPos + 1;
                    last[level] = item;
                }
                else
                {
                    item.StartPos = LeftMargin;
                    last.Add(item);
                }
                if (level > 0)
                {
                    item.Parent = last[level - 1];
                    if (next == item.Parent.Node.LeftNode)
                    {
                        item.Parent.Left = item;
                        item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos);
                    }
                    else
                    {
                        item.Parent.Right = item;
                        item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos);
                    }
                }
                next = next.LeftNode ?? next.RightNode;
                for (; next == null; item = item.Parent)
                {
                    Print(item, rootTop + 2 * level);
                    if (--level < 0) break;
                    if (item == item.Parent.Left)
                    {
                        item.Parent.StartPos = item.EndPos;
                        next = item.Parent.Node.RightNode;
                    }
                    else
                    {
                        if (item.Parent.Left == null)
                            item.Parent.EndPos = item.StartPos;
                        else
                            item.Parent.StartPos += (item.StartPos - item.Parent.EndPos) / 2;
                    }
                }
            }
            Console.SetCursorPosition(0, rootTop + 2 * last.Count - 1);
        }




        //Note:: the Print Function Just for visualization the tree structure rpresentaion
        //so it excepect that the Data Can be Converted To string :)


        private void Print(NodeInfo item, int top)
        {
            SwapColors();
            Print(item.Text, top, item.StartPos);
            SwapColors();
            if (item.Left != null)
                PrintLink(top + 1, "┌", "┘", item.Left.StartPos + item.Left.Size / 2, item.StartPos);
            if (item.Right != null)
                PrintLink(top + 1, "└", "┐", item.EndPos - 1, item.Right.StartPos + item.Right.Size / 2);
        }
        private void PrintLink(int top, string start, string end, int startPos, int endPos)
        {
            Print(start, top, startPos);
            Print("─", top, startPos + 1, endPos);
            Print(end, top, endPos);
        }

        private void Print(string s, int top, int Left, int Right = -1)
        {
            Console.SetCursorPosition(Left, top);
            if (Right < 0) Right = Left + s.Length;
            while (Console.CursorLeft < Right) Console.Write(s);
        }

        private void SwapColors()
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
        }
        private int InternalHeight(TreeNode<TData> node)
        {
            if (node is null)
                return 0;

            return 1 + Math.Max(InternalHeight(node.LeftNode), InternalHeight(node.RightNode));
        }
        private void PreOrderTraversal(TreeNode<TData> node)
        {
            if (node is null)
                return ;
              Console.Write($"{node.Data} => ");
            PreOrderTraversal(node.LeftNode);
            PreOrderTraversal(node.RightNode);
        }
        private void InOrderTraversal(TreeNode<TData> node)
        {
            if (node is null)
                return;
            InOrderTraversal(node.LeftNode);
            Console.Write($"{node.Data} => ");
            InOrderTraversal(node.RightNode);
        }
        private void PostOrderTraversal(TreeNode<TData> node)
        {
            if (node is null)
                return;
            PostOrderTraversal(node.LeftNode);
            PostOrderTraversal(node.RightNode);
            Console.Write($"{node.Data} => ");
        }
        class NodeInfo
        {
            public TreeNode<TData> Node;
            public string Text;
            public int StartPos;
            public int Size { get { return Text.Length; } }
            public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
            public NodeInfo Parent, Left, Right;
        }
    }
}



internal class TreeNode<TData> where TData : IComparable<TData>
{
    internal TData Data { get; }
    internal TreeNode<TData>? LeftNode { get; private set; }
    internal TreeNode<TData>? RightNode { get; private set; }
    internal TreeNode(TData data) => Data = data;

    internal void AddToLeft(TreeNode<TData> node) => LeftNode = node;
    internal void AddToRight(TreeNode<TData> node) => RightNode = node;
}

