using System;

namespace if_else_if
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = DateTime.Now.Hour;

      if (time >= 6 && time < 11)
        Console.WriteLine("Gunaydin!");
      else if (time <= 18)
        Console.WriteLine("Iyı gunler!");
      else
        Console.WriteLine("Iyı geceler!");

      string sonuc = time <= 18 ? "Iyı gunler!" : "Iyı geceler!";
      sonuc = time >= 6 && time <= 11 ? "Gunaydin" : time <= 18 ? "Iyı gunler" : "Iyı geceler";
    }
  }
}
