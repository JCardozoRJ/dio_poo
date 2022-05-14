namespace poo.src.Entities
{
  public class Knight : Hero
  {
    public Knight(string Name, int Level, string HeroType, int HealthPower, int MagicPower) : base(Name, Level, HeroType, HealthPower, MagicPower)
    {

    }
    public override string Attack(string Opponent)
    {
      return $"{this.Name} atacou {Opponent} com uma espada.";
    }
  }
}