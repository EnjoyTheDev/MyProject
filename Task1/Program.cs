using System;

namespace Task1
{
  class Program
  {
    static void Main(string[] args)
    {
      // Explicit conversions

      double numb6 = 8195.5;
      long a;
      int b;
      short c;
      byte d;

      a = (long)numb6;
      b = (int)numb6;
      c = (short)numb6;
      d = (byte)numb6;

      // Implicit conversions

      byte numb1 = 255;
      short numb2 = numb1;
      int numb3 = numb2;
      long numb4 = numb3;
      float numb5 = numb4;

      // Boxing

      // Unboxing
    }
  }
}
