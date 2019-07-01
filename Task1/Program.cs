using System;

namespace Task1

{
  class Program
  {
    static void Main(string[] args)
    {
      // Explicit conversions

      var numb6 = 8195.5; // automatically assigns a double type 
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
      short numb2 = numb1; // byte -> short
      int numb3 = numb2;  //  short -> int
      long numb4 = numb3; //  int -> long
      float numb5 = numb4; // long -> float

      // Boxing
      int i = 57;
      object g = i;

      // Unboxing
      i = (int)g; // 57
    }
  }
}
