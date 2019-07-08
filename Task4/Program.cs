using System;

namespace Task4
{
  class Program
  {
    static void Main(string[] args)
    {
      GetReverseLetter();
    }
    static void GetReverseLetter()
    {
      for (int item = 90; item >= 65; item--)
      {
        Console.WriteLine(Convert.ToChar(item));
      }
    }
  }
}
