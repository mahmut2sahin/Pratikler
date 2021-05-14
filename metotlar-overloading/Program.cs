using System;

namespace metotlar_overloading
{
  class Program
  {
    static void Main(string[] args)
    {
      string sayi1 = "999";

      bool sonuc = int.TryParse(sayi1, out int outSayi1);

      if (sonuc)
      {
        Console.WriteLine("Basarili");
        Console.WriteLine(outSayi1);
      } 
      else
      {
        Console.WriteLine("Basarisiz");
      }

      Metotlar instance = new Metotlar();
      instance.Topla(4, 5, out int toplamSonucu);
      Console.WriteLine(toplamSonucu);

      int ifade = 999;
      instance.EkranaYazdir(Convert.ToString(ifade));
      instance.EkranaYazdir(ifade);
      instance.EkranaYazdir("Mahmut", "Sahin");

      // İmza: metotadi + parametre sayisi + parametre
    }
  }

  class Metotlar
  {
    public void Topla (int a, int b, out int toplam)
    {
      toplam = a + b;
    }
    public void EkranaYazdir (string veri)
    {
      Console.WriteLine(veri);
    }
    public void EkranaYazdir (int veri)
    {
      Console.WriteLine(veri);
    }
    public void EkranaYazdir (string veri1, string veri2)
    {
      Console.WriteLine(veri1 + veri2);
    }
  }
}
