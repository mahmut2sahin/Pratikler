namespace interfaces
{
  public class Corolla : IOtomobil
  {
    public Marka HangiMarka()
    {
      return Marka.Toyota;
    }

    public int KacTekerlek()
    {
      return 4;
    }

    public Renk StandartRenk()
    {
      return Renk.Beyaz;
    }
  }
}