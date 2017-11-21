using System;


namespace Dotarpg
{
    class AgilityHero : Hero
    {
        public AgilityHero()
        {
            this.name = "agilityName";
            this.strenght = strenght * 0.5;
            this.agility = agility * 1.35;
            this.intelligence = intelligence * 0.7;
            this.hp = hp + 19 * strenght;
            this.mana = mana + 13 * intelligence;
            armor = Convert.ToInt32(agility / 7);
            phisResist = 1 - 0.06 * armor / (1 + (0.06 * Math.Abs(armor)));
            magicResist = 1 - 0.05 * intelligence / (1 + (0.06 * Math.Abs(intelligence)));
            damage = agility;
        }
        public AgilityHero(string name, int strenght, int agility, int intelligence)
        {
            this.name = name;
            this.strenght = strenght * 0.5;
            this.agility = agility * 1.35;
            this.intelligence = intelligence * 0.7;
            this.hp = hp + 19 * strenght;
            this.mana = mana + 13 * intelligence;
            armor = Convert.ToInt32(agility / 7);
            phisResist = 1 - 0.06 * armor / (1 + (0.06 * Math.Abs(armor)));
            magicResist = 1 - 0.05 * intelligence / (1 + (0.06 * Math.Abs(intelligence)));
            damage = agility;
        }
    }
}
