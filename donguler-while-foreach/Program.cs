using System;

namespace donguler_while_foreach
{
  class Program
  {
    static void Main(string[] args)
    {
      int sayi = int.Parse(Console.ReadLine());
      int sayac = 1;
      int toplam = 0;
      while (sayac < sayi)
      {
        toplam += sayac;
        sayac++;
      }
      Console.WriteLine(toplam / sayi);
      char character = 'a';
      while (character < 'z')
      {
        Console.WriteLine(character);
        character++;
      }

      string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};
      foreach (var araba in arabalar)
      {
        Console.WriteLine(araba);
      }
    }
  }
}
