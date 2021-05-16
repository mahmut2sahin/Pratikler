using System;

namespace interfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      // Focus focus = new Focus();
      // Console.WriteLine(focus.HangiMarka());
      // Console.WriteLine(focus.KacTekerlek());
      // Console.WriteLine(focus.StandartRenk());

      Civic civic = new Civic();
      Console.WriteLine(civic.HangiMarka());
      Console.WriteLine(civic.KacTekerlek());
      Console.WriteLine(civic.StandartRenk());
    }
  }
}