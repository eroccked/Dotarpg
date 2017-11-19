using System;


namespace Dotarpg
{
    class IntelligenceHero : Hero
    {
        public IntelligenceHero()
        {
            this.name = "intelligenceHero";
            this.strenght = strenght * 0.6;
            this.agility = agility * 0.3;
            this.intelligence = intelligence * 1.45;
            this.hp = hp + 19 * strenght;
            this.mana = mana + 13 * intelligence;
            armor = Convert.ToInt32(agility / 7);
            phisResist = 1 - 0.06 * armor / (1 + (0.06 * Math.Abs(armor)));
            magicResist = 1 - 0.05 * intelligence / (1 + (0.06 * Math.Abs(intelligence)));
            damage = intelligence;
        }
        public IntelligenceHero(int strenght, int agility, int intelligence)
        {
            this.name = "intelligenceHero";
            this.strenght = strenght * 0.6;
            this.agility = agility * 0.3;
            this.intelligence = intelligence * 1.45;
            this.hp = hp + 19 * strenght;
            this.mana = mana + 13 * intelligence;
            armor = Convert.ToInt32(agility / 7);
            phisResist = 1 - 0.06 * armor / (1 + (0.06 * Math.Abs(armor)));
            magicResist = 1 - 0.05 * intelligence / (1 + (0.06 * Math.Abs(intelligence)));
            damage = intelligence;
        }
    }
}
