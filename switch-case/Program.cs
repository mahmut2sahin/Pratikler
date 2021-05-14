using System;

namespace switch_case
{
  class Program
  {
    static void Main(string[] args)
    {
      int month = DateTime.Now.Month;

      switch (month)
      {
        case 1:
          Console.WriteLine("Ocak ayindasiniz");
          break;
        case 2:
          Console.WriteLine("Subat ayindasiniz");
          break;
        case 4:
          Console.WriteLine("Nisan ayindasiniz");
          break;
        case 3:
          Console.WriteLine("Mart ayindasiniz");
          break;
        default:
          Console.WriteLine("Yanlis veri girdiniz!");
          break;
      }

      switch (month)
      {
        case 12:
        case 1:
        case 2:
          Console.WriteLine("Kis mevsimindesiniz");
          break;
        case 3:
        case 4:
        case 5:
          Console.WriteLine("İlkbahar mevsimindesiniz");
          break;
        case 6:
        case 7:
        case 8:
          Console.WriteLine("Yaz mevsimindesiniz");
          break;
        default:
          break;
      }
    }
  }
}
