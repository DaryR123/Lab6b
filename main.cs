using System;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
  
int i;
int even = 0;
int odd = 0;
int[] arr = new int [10];

for ( i=0; i <10; i++)
{
Console.WriteLine("Enter a number");
arr[i]= Convert.ToInt32(Console.ReadLine());

if (arr[i] % 2 ==0)
{ 
  even = even + arr[i];
}
else
{
  odd = odd + arr[i];
}
}
Console.WriteLine("Sum of even list is: "+ even);

Console.WriteLine("Sum of odd list is: "+ odd);

  }
}