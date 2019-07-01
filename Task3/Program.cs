using System;

namespace Task3
{
  class Program
  {
    static void Sum()
    {

      Console.WriteLine("enter first number:");
      int a = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("enter second number:");
      int b = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("enter second number:");


      Console.WriteLine("enter + or -");
      var select = Console.ReadLine();
      var myResult = select == "+" ? (a + b) : (a - b);


      Console.WriteLine("enter your result:");
      var yourResult = Convert.ToInt32(Console.ReadLine());


      if (yourResult == myResult)
      {
        Console.WriteLine("Correct");
      }
      else if (yourResult > myResult)
      {
        Console.WriteLine("Incorrect - should be less");

      }
      else if (yourResult < myResult)
      {
        Console.WriteLine("Incorrect - should be more");
      }
    }
    static void Main(string[] args)
    {
      Sum();
    }
  }
}
