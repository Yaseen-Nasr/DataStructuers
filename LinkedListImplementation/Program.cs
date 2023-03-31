// See https://aka.ms/new-console-template for more information 


#region SingleLinkedlist

//DataStructuresLibrary.LinkedlistImp.LinkedList list = new DataStructuresLibrary.LinkedlistImp.LinkedList();
//list.InsertLast(0);
//list.InsertLast(1);
//list.InsertLast(2);
//list.InsertLast(3);
//list.PrintLinkedListData();
//#region InserAfter
////Check insert after Specific Node
//list.InserAfter(3, 23);
////Check Validation
////list.InserAfter(7, 5);
//list.PrintLinkedListData();
//#endregion
//#region InsertBefore
////list.InsertBefore(5, 88);
////list.PrintLinkedListData();
//#endregion
//#region DeleteNode
//list.DeleteNode(23);
//list.PrintLinkedListData();
//#endregion

#endregion

Console.WriteLine("-----------------------------------");
#region DoubleLinkedlist 
DataStructuresLibrary.DoubleLinkedList.LinkedList<int> doubleLinkedList = new DataStructuresLibrary.DoubleLinkedList.LinkedList<int>();
doubleLinkedList.InsertLast(0);
doubleLinkedList.InsertLast(1);
doubleLinkedList.InsertLast(2);
doubleLinkedList.InsertLast(3);
//doubleLinkedList.PrintLinkedListData();
//Console.WriteLine($"Length: {doubleLinkedList.Length}");

//doubleLinkedList.DeleteNode(0);
//doubleLinkedList.PrintLinkedListData();
//Console.WriteLine($"Length: {doubleLinkedList.Length}");

//doubleLinkedList.InsertBefore(3,88);
//doubleLinkedList.PrintLinkedListData();
//Console.WriteLine($"Length: {doubleLinkedList.Length}");
//Make Hard Acopy from Linked List 
DataStructuresLibrary.DoubleLinkedList.LinkedList<int> doubleLinkedListCopy = new DataStructuresLibrary.DoubleLinkedList.LinkedList<int>();
var currentNode = doubleLinkedList.Head; 
do
{
    doubleLinkedListCopy.InsertLast(currentNode!.Data);
    currentNode = currentNode.Next; 
} while (currentNode != null);
doubleLinkedListCopy.PrintLinkedListData();

#endregion

Console.ReadKey();