using System;

namespace Task5
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter your date of birth in the format (MM.YYYY):");
      string inputBirthDate = Console.ReadLine();
      string[] birthDate = inputBirthDate.Split('.');
      int birthMonth = Convert.ToInt32(birthDate[0]);
      int birthYear = Convert.ToInt32(birthDate[1]);

      Console.WriteLine("Enter the current date in the format (MM.YYYY):");
      string inputCurrentDate = Console.ReadLine();
      string[] currentDate = inputCurrentDate.Split('.');
      int currentMonth = Convert.ToInt32(currentDate[0]);
      int currentYear = Convert.ToInt32(currentDate[1]);

      if(birthMonth >= currentMonth)
      {
        Console.WriteLine($"Completed years: {currentYear - birthYear + 1}");
      }
      else
      {
        Console.WriteLine($"Completed years: {currentYear - birthYear}");
      }
    }
  }
}
