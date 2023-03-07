// See https://aka.ms/new-console-template for more information 
using DataStructuresLibrary.LinkedlistImp;

 LinkedList list = new LinkedList();
list.InsertLast(0);
list.InsertLast(1);
list.InsertLast(2);
list.InsertLast(3);
list.PrintLinkedListData();
#region InserAfter
//Check insert after Specific Node
list.InserAfter(3, 23);
//Check Validation
//list.InserAfter(7, 5);
list.PrintLinkedListData();
#endregion
#region InsertBefore
//list.InsertBefore(5, 88);
//list.PrintLinkedListData();
#endregion
#region DeleteNode
list.DeleteNode(23);
list.PrintLinkedListData();
#endregion
Console.ReadKey();