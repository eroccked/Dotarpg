

namespace Dotarpg
{
    public class Hero
    {
        private string Name;
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        private double Strenght;
        public double strenght
        {
            get
            {
                return Strenght;
            }
            set
            {
                Strenght = value;
            }
        }

        private double Agility;
        public double agility
        {
            get
            {
                return Agility;
            }
            set
            {
                Agility = value;
            }
        }

        private double Intelligence;
        public double intelligence
        {
            get
            {
                return Intelligence;
            }
            set
            {
                Intelligence = value;
            }
        }

        private int Armor;
        public int armor
        {
            get
            {
                return Armor;
            }
            set
            {
                Armor = value;
            }
        }

        private double PhisResist;
        public double phisResist
        {
            get
            {
                return PhisResist;
            }
            set
            {
                PhisResist = value;
            }
        }

        private double MagicResist;
        public double magicResist
        {
            get
            {
                return MagicResist;
            }
            set
            {
                MagicResist = value;
            }
        }

        private double Damage;
        public double damage
        {
            get
            {
                return Damage;
            }
            set
            {
                Damage = value;
            }
        }

        private double Hp;
        public double hp
        {
            get
            {
                return Hp;
            }
            set
            {
                Hp = value;
            }
        }

        private double Mana;
        public double mana
        {
            get
            {
                return Mana;
            }
            set
            {
                Mana = value;
            }
        }

        public Hero()
        {
            name = "Name";
            Strenght = 20;
            Agility = 20;
            Intelligence = 20;
            Hp = 600;
            Mana = 500;

        }

        public Hero(string name, double strenght, double agility, double intelligence)
        {
            this.name = name;
            this.strenght = strenght;
            this.agility = agility;
            this.intelligence = intelligence;
            Hp = 600;
            Mana = 500;
        }
    }
}
        