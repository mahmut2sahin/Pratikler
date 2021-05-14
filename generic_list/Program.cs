using System;
using System.Collections.Generic;

namespace generic_list
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> sayıListesi = new List<int>();

      sayıListesi.Add(123);
      sayıListesi.Add(87);
      sayıListesi.Add(53);

      List<string> renkListesi = new List<string>();

      renkListesi.Add("Kırmızı");
      renkListesi.Add("Yeşil");
      renkListesi.Add("Turuncu");
      // Count
      Console.WriteLine(renkListesi.Count);
      Console.WriteLine(sayıListesi.Count);
      // Foreach
      foreach (var sayı in sayıListesi)
      {
        Console.WriteLine(sayı);
      }
      foreach (var renk in renkListesi)
      {
        Console.WriteLine(renk);
      }
      // List foreach
      sayıListesi.ForEach(sayı => Console.WriteLine(sayı));
      renkListesi.ForEach(renk => Console.WriteLine(renk));

      // Remove item
      sayıListesi.Remove(5);
      sayıListesi.RemoveAt(2);

      sayıListesi.Contains(5);

      Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));


      string[] hayvanlar = { "Kedi", "Kuş", "İnek" };
      List<string> hayvanListesi = new List<string>(hayvanlar);

      hayvanListesi.Clear();

      List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

      Kullanıcılar kullanıcı1 = new Kullanıcılar();
      kullanıcı1.Isim = "Mahmut";
      kullanıcı1.Soyisim = "Sahin";
      kullanıcı1.Yas = 24;

      Kullanıcılar kullanıcı2 = new Kullanıcılar();
      kullanıcı2.Isim = "Martin";
      kullanıcı2.Soyisim = "Eden";
      kullanıcı2.Yas = 2;

      kullanıcıListesi.Add(kullanıcı1);
      kullanıcıListesi.Add(kullanıcı2);

      List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
      yeniListe.Add(new Kullanıcılar()
      {
        Isim = "Aasda",
        Soyisim = "qweqwe",
        Yas = 244

      });

      foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
      {
        Console.WriteLine("Kullanici Adi:" + kullanıcı.Isim);
        Console.WriteLine("Kullanici Soyadi:" + kullanıcı.Soyisim);
        Console.WriteLine("Kullanici Yasi:" + kullanıcı.Yas);
      }

      yeniListe.Clear();
    }
  }

  public class Kullanıcılar
  {
    private string isim;
    private string soyisim;
    private int yas;
    public string Isim {get => isim; set => isim = value;}
    public string Soyisim {get => soyisim; set => soyisim = value;}
    public int Yas {get => yas; set => yas = value;}
  }
}
