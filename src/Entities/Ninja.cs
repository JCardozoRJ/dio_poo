namespace poo.src.Entities
{
  public class Ninja : Hero
  {
    public Ninja(string Name, int Level, string HeroType, int HealthPower, int MagicPower) : base(Name, Level, HeroType, HealthPower, MagicPower)
    {
    }
    public override string Attack(string Opponent)
    {
      return $"{this.Name} atacou {Opponent} com uma adaga.";
    }
  }
}