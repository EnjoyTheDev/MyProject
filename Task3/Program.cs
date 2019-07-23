using System;

namespace Task3
{
  class Program
  {
    // Task 1
    static void Sum()
    {
      Console.WriteLine("Task 1");
      Console.WriteLine("enter first number:");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter second number:");
      int b = Convert.ToInt32(Console.ReadLine());
      var result = a + b;
      Console.WriteLine(result);
      Console.WriteLine();
    }
    //Task 2
    static void Check()
    {
      Console.WriteLine("Task 2");
      Console.WriteLine("enter first number:");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter second number:");
      int b = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("enter your result:");
      var yourResult = Convert.ToInt32(Console.ReadLine());
      var myResult = a + b;

      if (yourResult == myResult)
      {
        Console.WriteLine("Correct");
      }
      else
      {
        Console.WriteLine("Incorrect ");
      }
      Console.WriteLine();
    }
    // Task 3
    static void Comparison()
    {
      Console.WriteLine("Task 3");
      Console.WriteLine("enter first number:");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter second number:");
      int b = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("enter your result:");
      var yourResult = Convert.ToInt32(Console.ReadLine());
      var myResult = a + b;

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
      Console.WriteLine();
    }
    // Task 4
    static void Choice()
    {
      Console.WriteLine("Task 4");
      Console.WriteLine("enter first number:");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter second number:");
      int b = Convert.ToInt32(Console.ReadLine());

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
      Check();
      Comparison();
      Choice();
    }
  }
}
