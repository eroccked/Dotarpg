
using System;

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
            this.hp = hp + 19 * strenght;
            this.mana = mana + 13 * intelligence;
            armor = Convert.ToInt32(agility / 7);
            phisResist = 1 - 0.06 * armor / (1 + (0.06 * Math.Abs(armor)));
            magicResist = 1 - 0.05 * intelligence / (1 + (0.06 * Math.Abs(intelligence)));
            damage = strenght;
        }

        public StrenghtHero(string name, int strenght, int agility, int intelligence)
        {
            this.name = name;
            this.strenght = strenght * 1.2;
            this.agility = agility * 0.7;
            this.intelligence = intelligence * 0.3;
            this.hp = hp + 19 * strenght;
            this.mana = mana + 13 * intelligence;
            armor = Convert.ToInt32(agility / 7);
            phisResist = 1 - 0.06 * armor / (1 + (0.06 * Math.Abs(armor)));
            magicResist = 1 - 0.05 * intelligence / (1 + (0.06 * Math.Abs(intelligence)));
            damage = strenght;
        }
    }
}
