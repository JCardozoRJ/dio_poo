namespace poo.src.Entities
{
  public abstract class Hero
  {
    public Hero(string Name, int Level, string HeroType, int HealthPower, int MagicPower)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
      this.HealthPower = HealthPower;
      this.MagicPower = MagicPower;
    }
    public string Name { get; set; }
    public int Level { get; set; }
    public string HeroType { get; set; }
    public int HealthPower { get; set; }
    public int MagicPower { get; set; }



    public override string ToString()
    {
      return $"{this.Name} [Lv. {this.Level} - {this.HeroType} / HP {this.HealthPower} / MP {this.MagicPower}";
    }

    public virtual string Attack(string Opponent)
    {
      return $"{this.Name} atacou {Opponent}.";
    }
    public string Attack(int Bonus)
    {
      if (Bonus > 6)
      {
        return $"{this.Name} atacou com uma Super força.";

      }
      else
      {
        return $"{this.Name} atacou com uma força fraca.";

      }
    }
  }
}