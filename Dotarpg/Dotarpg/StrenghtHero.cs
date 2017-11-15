
namespace Dotarpg
{
    public class StrenghtHero : Hero
    {
        public StrenghtHero()
        {
            this.name = "StrenghtName";
            this.strenght = strenght * 1.2;
            this.agility = agility * 0.7;
            this.intelligence = intelligence * 0.3;
        }

        public StrenghtHero(int strenght, int agility, int intelligence)
        {
            this.name = "StrenghtName";
            this.strenght = strenght * 1.2;
            this.agility = agility * 0.7;
            this.intelligence = intelligence * 0.3;
        }
    }
}
