namespace interfaces
{
  public class Civic:IOtomobil
  {
    public Marka HangiMarka()
    {
      return Marka.Honda;
    }

    public int KacTekerlek()
    {
      return 4;
    }

    public Renk StandartRenk()
    {
      return Renk.Gri;
    }
  }
}