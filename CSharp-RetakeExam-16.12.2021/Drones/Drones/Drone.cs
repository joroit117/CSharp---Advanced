using System;

namespace Drones
{
    public class Drone
    {
        private bool available = true;
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Range { get; set; }
        public bool Available 
        {
            get
            {
                return available;
            }
            set
            {
                available = value;
            } 
        }

        public Drone(string name, string brand, int range)
        {
            this.Name = name;
            this.Brand = brand;
            this.Range = range;
        }

        public override string ToString()
        {
            return $"Drone: {Name}{Environment.NewLine}Manufactured by: {Brand}{Environment.NewLine}Range: {Range} kilometers{Environment.NewLine}";
        }
    }
}
