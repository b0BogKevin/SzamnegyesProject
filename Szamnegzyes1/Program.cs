using Shared;
using System.Runtime.Intrinsics.X86;



int[][] arr = [
  [1,2,1],
  [2,4,2],
  [1,2,1]
];
int[] valid = ArrHelper.isValid(arr);

foreach (var i in valid)
{
    Console.Write(i);
    
}

Console.WriteLine();

arr = [
  [3,7,4],
  [5,16,11],
  [2,9,7]
];

valid = ArrHelper.isValid(arr);

foreach (var i in valid)
{
    Console.Write(i);

}