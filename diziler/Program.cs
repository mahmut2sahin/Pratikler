﻿using System;

namespace diziler
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] renkler = new string[5];
      string[] hayvanlar = {"Kedi", "Kopek", "Kus", "Maymun"};

      int[] dizi;
      dizi = new int[5];

      renkler[0] = "Mavi";
      dizi[3] = 10;

      Console.WriteLine(hayvanlar[1]);
      Console.WriteLine(dizi[3]);
      Console.WriteLine(renkler[0]);

      Console.WriteLine("Dizi eleman sayisi: ");
      int diziUzunlugu = int.Parse(Console.ReadLine());
      int[] sayiDizisi = new int[diziUzunlugu];

      for (int i = 0; i < diziUzunlugu; i++)
      {
        Console.Write("Lutfen {0}. sayıyı giriniz", i + 1);
        sayiDizisi[i] = int.Parse(Console.ReadLine());
      }

        int toplam = 0;
      foreach (var item in sayiDizisi)
      {
        toplam += item;
      }
      Console.WriteLine("Ortalama: ", toplam / diziUzunlugu);
    }
  }
}
