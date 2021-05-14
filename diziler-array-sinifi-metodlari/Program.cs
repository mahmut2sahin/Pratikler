using System;

namespace diziler_array_sinifi_metodlari
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};
      foreach (var item in sayiDizisi)
      {
        Console.WriteLine(item);
      }

      Array.Sort(sayiDizisi);
      foreach (var item in sayiDizisi)
      {
        Console.WriteLine(item);
      }

      Array.Clear(sayiDizisi, 2, 2);
      foreach (var item in sayiDizisi)
      {
        Console.WriteLine(item);
      }

      Array.Reverse(sayiDizisi);
      foreach (var item in sayiDizisi)
      {
        Console.WriteLine(item);
      }

      Array.IndexOf(Array.IndexOf(sayiDizisi, 23));
      
      Array.Resize<int>(ref sayiDizisi, 9);
      sayiDizisi[8] = 99;
      foreach (var item in sayiDizisi)
      {
        Console.WriteLine(item);
      }
    }
  }
}