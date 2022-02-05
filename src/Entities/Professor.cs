namespace Projeto.src.Entities
{
    public class Professor : Hero
    {
        public Professor(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }        

        public override string Attack()
        {
            return $"{this.Name} atacou com todo seu conhecimento";
        }
    }
}