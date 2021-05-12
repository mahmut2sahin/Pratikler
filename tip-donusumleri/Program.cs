using System;

namespace tip_donusumleri
{
  class Program
  {
    static void Main(string[] args)
    {
      byte a = 5;
      sbyte b = 30;
      short c = 10;

      int d = a + b + c;

      long h = d;

      float i = h;

      string e = "mahmut";
      char f = 'm';
      object g = e + f + d;

      int x = 4;
      byte y = (byte)x;

      int z = 100;
      byte t = (byte)z;

      float w = 10.3f;
      byte v = (byte)w;

      int xx = 6;
      string yy = xx.ToString();
      string zz = 12.5f.ToString();

      string s1 = "10", s2 = "20";
      int sayi1, sayi2;
      int toplam;

      sayi1 = Convert.ToInt32(s1);
      sayi2 = Convert.ToInt32(s2);

      toplam = sayi1 + sayi2;

      parseMethod();
    }

    public static void parseMethod()
    {
      string metin1 = "10";
      string metin2 = "10.25";
      int rakam1;
      double double1;

      rakam1 = Int32.Parse(metin1);
      double1 = Double.Parse(metin2);

      Console.WriteLine("rakam1 :" + rakam1);
      Console.WriteLine("double1 :" + double1);

    }
  }
}
