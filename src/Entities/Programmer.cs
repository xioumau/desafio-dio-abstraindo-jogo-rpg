namespace Projeto.src.Entities
{
    public class Programmer : Hero
    {
        public Programmer(string name, int level, string heroType) : base(name, level, heroType)
        {
           this.Name = name;
           this.Level = level;
           this.HeroType = heroType;
        }
        
        public override string Attack()
        {
            return $"{this.Name} programou com furia!";
        }
    }
}