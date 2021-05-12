using System;

namespace console.programlama
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();
      Console.WriteLine("What is your surname?");
      string surname = Console.ReadLine();
      Console.WriteLine("Hello " + name + " " + surname);
    }
  }
}
