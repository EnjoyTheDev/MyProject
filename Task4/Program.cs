using System;

namespace Task4
{
  class Program
  {
    // Task 1
    static void GetReverseLetter()
    {
      var firstLetter = 'A';
      for (var lastLetter = 'Z'; firstLetter <= lastLetter; lastLetter--)
      {
        Console.WriteLine(lastLetter);
      }
    }
    // Task 2
    static void LetsPlay()
    {
      ConsoleKeyInfo keypress;
      Console.WriteLine("Moving the character. W - forward, S - backward, A - left, D - right");
      do
      {
        keypress = Console.ReadKey(true);
        if (keypress.KeyChar == 'W' || keypress.KeyChar == 'w')
        {
          Console.WriteLine("Forward");
        }
        if (keypress.KeyChar == 'S' || keypress.KeyChar == 's')
        {
          Console.WriteLine("Back");
        }
        if (keypress.KeyChar == 'A' || keypress.KeyChar == 'a')
        {
          Console.WriteLine("Left");
        }
        if (keypress.KeyChar == 'D' || keypress.KeyChar == 'd')
        {
          Console.WriteLine("Rigth");
        }
      }
      while (keypress.KeyChar == 'A' || keypress.KeyChar == 'W' || keypress.KeyChar == 'S' || keypress.KeyChar == 'D' || keypress.KeyChar == 'a' || keypress.KeyChar == 'w' || keypress.KeyChar == 's' || keypress.KeyChar == 'd');

      Console.WriteLine("You were lost, you can only move left, right, back, forward.");
      Console.WriteLine("Play again? Y/N");
      var confirm = Console.ReadKey(true);

      if (confirm.KeyChar == 'Y' || confirm.KeyChar == 'y')
      {
        LetsPlay();
      }
      else if (confirm.KeyChar == 'N' || confirm.KeyChar == 'n')
      {
        return;
      }
      Console.Read();
    }

    static void Main(string[] args)
    {
      GetReverseLetter();
      LetsPlay();
    }
  }
}
