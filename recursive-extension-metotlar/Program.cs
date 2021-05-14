using System;

namespace recursive_extension_metotlar
{
  class Program
  {
    static void Main(string[] args)
    {
      int result = 1;
      for (int i = 0; i < 5; i++)
        result = result * 3;
      Console.WriteLine(result);
      Islemler instance = new();
      Console.WriteLine(instance.Expo(3, 4));

      // Extensions
      string ifade = "Mahmut Sahin";
      bool sonuc = ifade.CheckSpaces();
      if (sonuc)
      {
        Console.WriteLine(ifade.RemoveWhiteSpaces());
      }

    }
  }

  class Islemler
  {
    public int Expo(int sayi, int us)
    {
      if (us < 2)
        return sayi;
      return Expo(sayi, us - 1) * sayi;
    }

  }

  public static class Extensions
  {
    public static bool CheckSpaces(this string param)
    {
      return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param)
    {
      string[] dizi = param.Split(" ");
      return string.Join("", dizi);
    }
  }
}
