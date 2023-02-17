// See https://aka.ms/new-console-template for more information
using Contains_Duplicate;

int[] intListFalse = new int[10] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
int[] intListTrue = new int[4] { 1, 2, 4, 5};


Boolean result1 = ContainsDuplicated.ContainsDuplicate(intListFalse);
Boolean result2 = ContainsDuplicated.ContainsDuplicate(intListTrue);

Console.Write("First contains duplicate: ");
Console.Write(result1);
Console.WriteLine("");
Console.Write("Second contains duplicate: ");
Console.Write(result2);