

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

        public Hero()
        {
            name = "Name";
            Strenght = 20;
            Agility = 20;
            Intelligence = 20;
        }

        public Hero(string name, double strenght, double agility, double intelligence)
        {
            this.name = name;
            this.strenght = strenght;
            this.agility = agility;
            this.intelligence = intelligence;
        }
    }
}
