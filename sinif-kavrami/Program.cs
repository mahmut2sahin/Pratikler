using System;

namespace sinif_kavrami
{
  class Program
  {
    static void Main(string[] args)
    {
      Calısan calısan1 = new Calısan();
      calısan1.Ad = "Mahmut";
      calısan1.Soyad = "Sahin";
      calısan1.No = 12136328;
      calısan1.Departman = "İnsan Kaynakları";

      Calısan calısan2 = new Calısan();
      calısan2.Ad = "Martin";
      calısan2.Soyad = "Eden";
      calısan2.No = 14913278;
      calısan2.Departman = "Satın Alma";

      calısan1.CalısanBilgileri();
      calısan2.CalısanBilgileri();
    }
  }

  class Calısan
  {
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public void CalısanBilgileri()
    {
      Console.WriteLine("Çalışan Adı:{0}", Ad);
      Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
      Console.WriteLine("Çalışan Numarası:{0}", No);
      Console.WriteLine("Çalışan Departmanı:{0}", Departman);
    }
  }
}