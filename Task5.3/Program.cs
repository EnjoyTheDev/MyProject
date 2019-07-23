using System;

namespace Task5._3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("\n Amount of deposit: 1000 ");
      decimal startDeposit = 1000;
      Console.Write("\n Interest rate: 2%");
      decimal rate = 2;
      Console.Write("\n Term of deposit: 10 months \n");
      int period = 12;
      decimal increaseDeposit = 0;

      for (int months = 1; months <= period; months++)
      {
        startDeposit += (startDeposit * rate) / 100;
        Console.WriteLine($"Total amount:{Decimal.Round(startDeposit, 2)}");
        increaseDeposit = (startDeposit * rate) / 100;
        Console.WriteLine($"Total increase: {Decimal.Round(increaseDeposit, 2)}");
      }
    }
  }
}




