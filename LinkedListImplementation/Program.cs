// See https://aka.ms/new-console-template for more information 


#region SingleLinkedlist

//DataStructuresLibrary.LinkedlistImp.LinkedList list = new DataStructuresLibrary.LinkedlistImp.LinkedList(isLinkedListUnique: true);
//DataStructuresLibrary.LinkedlistImp.LinkedList list = new DataStructuresLibrary.LinkedlistImp.LinkedList(true);
//list.InsertLast(0);
//list.InsertLast(1);
//list.InsertLast(2);
//list.InsertLast(3);
//list.PrintLinkedListData();
//list.InsertLast(3);
#region InserAfter 
//list.InserAfter(3, 23); 
//list.InserAfter(7, 5);
//list.PrintLinkedListData();
#endregion
#region InsertBefore
//list.InsertBefore(5, 88);
//list.PrintLinkedListData();
#endregion
#region DeleteNode
//list.DeleteNode(23);
//list.PrintLinkedListData();
//#endregion

#endregion
#endregion

//Console.WriteLine("-----------------------------------");
#region DoubleLinkedlist 
//DataStructuresLibrary.DoubleLinkedList.LinkedList<int> doubleLinkedList = new DataStructuresLibrary.DoubleLinkedList.LinkedList<int>();
//doubleLinkedList.InsertLast(0);
//doubleLinkedList.InsertLast(1);
//doubleLinkedList.InsertLast(2);
//doubleLinkedList.InsertLast(3);

//doubleLinkedList.PrintLinkedListData();
//Console.WriteLine($"Length: {doubleLinkedList.Length}");

//doubleLinkedList.DeleteNode(0);
//doubleLinkedList.PrintLinkedListData();
//Console.WriteLine($"Length: {doubleLinkedList.Length}");

//doubleLinkedList.InsertBefore(3, 88);
//doubleLinkedList.PrintLinkedListData();
//Console.WriteLine($"Length: {doubleLinkedList.Length}");


////Make Hard copy from Linked List 
//DataStructuresLibrary.DoubleLinkedList.LinkedList<int> doubleLinkedListCopy = new DataStructuresLibrary.DoubleLinkedList.LinkedList<int>();
//var currentNode = doubleLinkedList.Head; 
//do
//{
//    doubleLinkedListCopy.InsertLast(currentNode!.Data);
//    currentNode = currentNode.Next; 
//} while (currentNode != null);
//doubleLinkedListCopy.PrintLinkedListData();

#endregion
#region stack
//DataStructuresLibrary.LogicalDataStructure.Stack stack = new DataStructuresLibrary.LogicalDataStructure.Stack(true);
//Console.WriteLine($"isEmpty : {stack.IsEmpty()}");
//stack.Push(1);
//stack.Push(2);
//stack.Push(3);
//stack.Push(4);
//stack.Print();
//while (!stack.IsEmpty())
//{

//    Console.WriteLine($"Peek: {stack.Peek()}");
//    Console.WriteLine($"Pop : {stack.Pop()}");
//    Console.WriteLine($"Size : {stack.Size()}");
//    stack.Print();
//}


#endregion
#region Queue
//DataStructuresLibrary.LogicalDataStructure.Queue queue = new DataStructuresLibrary.LogicalDataStructure.Queue(true);
//Console.WriteLine($"has Data : {queue.HasData()}");
//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(4);
//queue.Print();
//while (queue.HasData())
//{

//    Console.WriteLine($"Peek: {queue.Peek()}");
//    Console.WriteLine($"Dequeue : { queue.Dequeue()}");
//    Console.WriteLine($"Size : {queue.Size()}");
//    queue.Print();
//} 
#endregion
#region Dictionary
DataStructuresLibrary.Hashs.Dictionary<string, string> dic = new DataStructuresLibrary.Hashs.Dictionary<string, string>();
dic.Print();

dic.Set("Sinar", "sinar@gmail.com");
dic.Set("Elvis", "elvis@gmail.com");
dic.Print();

dic.Set("Tane", "tane@gmail.com");
dic.Set("Gerti", "gerti@gmail.com");
dic.Set("Arist", "arist@gmail.com");

//dic.Set("rArist", "rarist@gmail.com");
//dic.Set("tArist", "tarist@gmail.com");
//dic.Set("yArist", "yarist@gmail.com");
dic.Print();

Console.WriteLine(dic.Get("Tane"));
Console.WriteLine(dic.Get("Sinar"));
Console.WriteLine(dic.Get("Elviaaa"));

dic.Remove("Sinar");
dic.Remove("Elvis");
dic.Remove("Tane");
dic.Remove("Gerti");
dic.Remove("Arist");
dic.Print();
dic.Set("Sinar", "sinar@gmail.com");
dic.Print();

#endregion


Console.ReadKey();