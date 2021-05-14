using System;

namespace odev_1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("1. SORU");
      Soru1();
      Console.WriteLine("2. SORU");
      Soru2();
      Console.WriteLine("3. SORU");
      Soru3();
      Console.WriteLine("4. SORU");
      Soru4();
    }

    static void Soru1()
    {
      /*
      !SORU - 1
      Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
      */

      Console.WriteLine("Pozitif bir sayi girin: ");
      int n = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine($"Bir sonraki adımda {n} adet pozitif sayı gireceksiniz...");
      int[] numbers = new int[n];

      for (int i = 0; i < n; i++)
      {
        Console.Write($"{i + 1}. sayı: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
      }

      Console.WriteLine("Çift sayılar: ");
      foreach (var item in numbers)
      {
        if (item.CheckEven())
        {
          Console.WriteLine(item);
        }
      }
    }
    static void Soru2()
    {
      /*
      Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
      */

      Console.WriteLine("Ikı sayi girin:");
      Console.Write("1. sayi: ");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.Write("2. sayi: ");
      int m = Convert.ToInt32(Console.ReadLine());

      int[] numbers = new int[n];
      Console.WriteLine($"{n} adet pozitif sayi girin.");
      for (int i = 0; i < n; i++)
      {
        Console.Write((i + 1) + ". sayi: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
      }

      foreach (var item in numbers)
      {
        if (item == m || item % m == 0)
        {
          Console.WriteLine(item);
        }
      }

    }
    static void Soru3()
    {
      /*
      Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
      */

      Console.Write("Pozitif bir sayı girin:");
      int n = Convert.ToInt32(Console.ReadLine());

      string[] words = new string[n];
      Console.WriteLine($"{n} adet kelime girin:");
      for (int i = 0; i < n; i++)
      {
        Console.Write((i + 1) + ". kelime: ");
        words[i] = Console.ReadLine();
      }

      Array.Reverse(words);
      foreach (var item in words)
      {
        Console.WriteLine(item);
      }
    }
    static void Soru4()
    {
      /*
      Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
      */

      Console.Write("Bir cumle yazin:");
      string stc = Console.ReadLine();

      Console.Write("Toplam harf sayısı: ");
      int letterCount = 0;
      int wordCount = 0;
      foreach (var item in stc)
      {
        if (item == ' ' || item == ',' || item == '.' || item == '!' || item == '?')
        {
          wordCount++;
          continue;
        }
        letterCount++;
      }
      Console.WriteLine("Harf sayisi: " + letterCount);
      Console.WriteLine("Kelime sayisi: " + wordCount);
    }
  }

  public static class Operations
  {
    public static bool CheckEven(this int i)
    {
      if (i % 2 == 0)
        return true;
      else
        return false;
    }
  }
}
