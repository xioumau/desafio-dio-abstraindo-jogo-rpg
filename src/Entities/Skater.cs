namespace Projeto.src.Entities
{
    public class Skater : Hero
    {
        public Skater(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return $"{this.Name} atacou com uma super manobra!";
        }
    }
}