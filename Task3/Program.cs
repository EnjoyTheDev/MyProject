using System;

namespace Task3
{
  class Program
  {
    static void Sum()
    {

      Console.WriteLine($"enter first number:");
      int a = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine($"enter second number:");
      int b = Convert.ToInt32(Console.ReadLine());

      var result = a + b; 
      Console.WriteLine($"result = {result}");
    }
    static void Main(string[] args)
    {
      Sum();
    }
  }
}
