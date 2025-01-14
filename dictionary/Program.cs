﻿using System;
using System.Collections.Generic;

namespace dictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      // system.collection.generic
      Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

      kullanıcılar.Add(10, "Ayse Yilmaz");
      kullanıcılar.Add(12, "Ahmet Yilmaz");
      kullanıcılar.Add(18, "Deniz Arda");
      kullanıcılar.Add(20, "Ozcan Cosar");

      Console.WriteLine(kullanıcılar[12]);
      foreach (var item in kullanıcılar)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine(kullanıcılar.Count);

      Console.WriteLine(kullanıcılar.ContainsValue("Deniz Arda"));
      Console.WriteLine(kullanıcılar.ContainsKey(12));

      kullanıcılar.Remove(12);
    }
  }
}
