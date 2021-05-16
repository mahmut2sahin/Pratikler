using System;

namespace static_sinif_ve_uyeler
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Çalışan sayısı: " + Calisan.CalisanSayisi);

      Calisan calisan0 = new Calisan("Mahmut", "Sahin", "CE");
      Console.WriteLine("Çalışan sayısı: " + Calisan.CalisanSayisi);
      Calisan calisan1 = new Calisan("Marin", "Eden", "CAT");
      Calisan calisan2 = new Calisan("Çaçaleyte", "Ims", "POMP");

      Console.WriteLine("Çalışan sayısı: " + Calisan.CalisanSayisi);

      Console.WriteLine(Islemler.Cikar(100, 200));
      Console.WriteLine(Islemler.Topla(100, 200));
    }
  }

  class Calisan
  {
    private static int calisanSayisi;
    public static int CalisanSayisi { get => calisanSayisi;}
    private string Isim;
    private string Soyisim;
    private string Departman;
    static Calisan()
    {
      calisanSayisi = 0;
    }

    public Calisan(string isim, string soyisim, string departman)
    {
      Isim = isim;
      Soyisim = soyisim;
      Departman = departman;
      calisanSayisi++;
    }
  }

  static class Islemler
  {
    public static long Topla (int sayi1, int sayi2)
    {
      return sayi1 + sayi2;
    }
    public static long Cikar (int sayi1, int sayi2)
    {
      return sayi1 - sayi2;
    }
  }
}
