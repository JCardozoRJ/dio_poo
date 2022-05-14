namespace poo.src.Entities
{
  public class Wizard : Hero
  {
    public Wizard(string Name, int Level, string HeroType, int HealthPower, int MagicPower) : base(Name, Level, HeroType, HealthPower, MagicPower)
    {

    }
    public override string Attack(string Opponent)
    {
      return $"{this.Name} atacou {Opponent} com um feitiço.";
    }
  }
}