using System;

namespace kurucu_metotlar
{
  class Program
  {
    static void Main(string[] args)
    {
      Calısan calısan1 = new Calısan("Mahmut", "Sahin", 12136328, "İnsan Kaynakları");

      Calısan calısan2 = new Calısan("Martin", "Eden", 14913278, "Satın Alma");

      Calısan calısan3 = new Calısan("İsmail", "YK");

      calısan1.CalısanBilgileri();
      calısan2.CalısanBilgileri();
      calısan3.CalısanBilgileri();
    }
  }

  class Calısan
  {
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public Calısan(string ad, string soyad, int no, string departman)
    {
      this.Ad = ad;
      this.Soyad = soyad;
      this.No = no;
      this.Departman = departman;

    }
    public Calısan(string ad, string soyad)
    {
      this.Ad = ad;
      this.Soyad = soyad;
    }
    public void CalısanBilgileri()
    {
      Console.WriteLine("Çalışan Adı:{0}", Ad);
      Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
      Console.WriteLine("Çalışan Numarası:{0}", No);
      Console.WriteLine("Çalışan Departmanı:{0}", Departman);
    }
  }
}
