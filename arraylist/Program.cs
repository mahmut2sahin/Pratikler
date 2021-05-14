using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList liste = new ArrayList();
      liste.Add("Mahmut");
      liste.Add(24);
      liste.Add(true);
      liste.Add('M');

      Console.WriteLine(liste[1]);

      foreach (var item in liste)
      {
        Console.WriteLine(item);
      }

      string[] renkler = { "kırmızı", "sarı", "yeşil" };
      List<int> sayılar = new List<int>(){1, 8, 23, 9, 92, 3};
      liste.AddRange(renkler);
      liste.AddRange(sayılar);

      foreach (var item in liste)
      {
        Console.WriteLine(item);
      }

      liste.Sort();

      liste.BinarySearch(9);

      liste.Reverse();
      foreach (var item in liste)
      {
        Console.WriteLine(item);
      }

      liste.Clear();
    }
  }
}

