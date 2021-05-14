using System;

namespace donguler_for_loop
{
  class Program
  {
    static void Main(string[] args)
    {
      int sayac = int.Parse(Console.ReadLine());
      for (int i = 0; i <= sayac; i++)
      {
        if (i%2 == 1)
        {
          Console.WriteLine(i);
        }
      }
      
      int tektoplam = 0;
      int cifttoplam = 0;
      for (int j = 1; j < 1000; j++)
      {
        if (j%2 == 1)
        {
          tektoplam += 1;
        }
        else
        {
          cifttoplam += 1;
        }
      }
      
      Console.WriteLine("Tek Toplam: " + tektoplam);
      Console.WriteLine("Cift Toplam: " + cifttoplam);

      for (int k = 0; k < 10; k++)
      {
        if (k == 4)
        {
          break;
        }
        Console.WriteLine(k);
      }

      for (int l = 0; l < 10; l++)
      {
        if (l == 4)
        {
          continue;
        }
        Console.WriteLine(l);
      }
    }
  }
}
