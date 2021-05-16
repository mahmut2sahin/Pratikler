using System;

namespace enums
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Gunler.Pazar);
      Console.WriteLine((int)Gunler.Pazar);

      int sıcaklık = 32;

      if (sıcaklık <= (int)HavaDurumu.Normal)
      {
        Console.WriteLine("Dışarısı soğuk");
      }
      else if (sıcaklık >= (int)HavaDurumu.Sıcak)
      {
        Console.WriteLine("Dışarısı sıcak");
      }
      else if (sıcaklık >= (int)HavaDurumu.CokSıcak)
      {
        Console.WriteLine("Dışarısı çok sıcak");
      }
    }
  }

  enum Gunler
  {
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
  }
  enum HavaDurumu
  {
    Soguk = 5,
    Normal = 20,
    Sıcak = 25,
    CokSıcak = 32
  }
}
