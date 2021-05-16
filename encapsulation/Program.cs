using System;

namespace encapsulation
{
  class Program
  {
    static void Main(string[] args)
    {
      Ogrenci ogrenci = new Ogrenci();
      ogrenci.Isim = "Martin";
      ogrenci.Soyisim = "Eden";
      ogrenci.Numara = 2162766;
      ogrenci.Sınıf = 2;

      ogrenci.OgrenciBilgileriniGetir();
      ogrenci.SınıfDusur();
      ogrenci.OgrenciBilgileriniGetir();
      ogrenci.SınıfDusur();
      ogrenci.OgrenciBilgileriniGetir();

      Ogrenci ogrenci2 = new Ogrenci("Mahmut", "Sahin", 1234567, 4);

      ogrenci2.OgrenciBilgileriniGetir();
      ogrenci2.SınıfAtlat();
      ogrenci2.OgrenciBilgileriniGetir();
    }
  }

  class Ogrenci
  {
    private string isim;
    private string soyisim;
    private int numara;
    private int sınıf;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Numara { get => numara; set => numara = value; }
    public int Sınıf
    {
      get => sınıf;
      set
      {
        if (value < 1)
        {
          Console.WriteLine("Sınıf en az 1 olabilir!");
          sınıf = 1;
        }
        else
        {
          sınıf = value;
        }
      }
    }


    public Ogrenci(string isim, string soyisim, int numara, int sınıf)
    {
      Isim = isim;
      Soyisim = soyisim;
      Numara = numara;
      Sınıf = sınıf;
    }
    public Ogrenci() { }

    public void OgrenciBilgileriniGetir()
    {
      Console.WriteLine("Öğrenci Adı:{0}", this.Isim);
      Console.WriteLine("Öğrenci Soyadı:{0}", this.Soyisim);
      Console.WriteLine("Öğrenci Numarası:{0}", this.Numara);
      Console.WriteLine("Öğrenci Sınıfı:{0}", this.Sınıf);
    }

    public void SınıfAtlat()
    {
      this.Sınıf++;
    }
    public void SınıfDusur()
    {
      this.Sınıf--;
    }
  }
}
