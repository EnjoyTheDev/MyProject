using System;

namespace Task5._2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("You have one bacterium =)");
      Console.WriteLine("Enter the time to calculate bacterial reproduction in minutes:");

      var timeRep = Convert.ToInt32(Console.ReadLine());
      
      var bacteria = 1;
      for (int i = 0; i < timeRep; i++)
      {
        bacteria = bacteria * 2;
      }
      Console.WriteLine($"In {timeRep} minutes - {bacteria} bacterias");
    }
  } 
}
