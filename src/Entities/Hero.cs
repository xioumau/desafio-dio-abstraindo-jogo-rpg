namespace Projeto.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
           this.Name = name;
           this.Level = level;
           this.HeroType = heroType;
        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return $"{this.Name} {this.Level} {this.HeroType}";
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com seu arco e flecha";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
                return $"{this.Name} usou ataque fulminante de {bonus} bonus!";
            
            return $"{this.Name} atacou com força fraca de {bonus} bonus.";
        }
    }
}