namespace Projeto.src.Entities
{
    public class Archer : Hero
    {
        public Archer(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
    }
}