using System;

namespace Task2
{
  class Program
  {
    static void Main(string[] args)
    {
      object something = "some string";
      String s = "hello";
      Double dNumb = 23.15;
      byte bNumb = 255;
      Int32 iNumb32 = 58;
      int iNumb = 670;

      Console.WriteLine($"something -> {something.GetType()}, s -> {s.GetType()}, dNumb -> {dNumb.GetType()}");
      Console.WriteLine($"bNumb -> {bNumb.GetType()}, iNumb32 -> {iNumb32.GetType()}, iNumb -> {iNumb.GetType()}");

      Console.ReadLine();
    }
  }
}
