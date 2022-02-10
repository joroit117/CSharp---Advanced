using System;
using System.Collections.Generic;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> drones = new List<Drone>();
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }

        public Airfield(string name, int capacity, double lanidingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = lanidingStrip;
        }

        public int Count()
        {
            return drones.Count;
        }
        public string AddDrone(Drone drone)
        {
            if (drone.Name == null || drone.Name == string.Empty || drone.Brand == null
                || drone.Brand == string.Empty ||
                drone.Range <= 5 || drone.Range >= 15)
                return "Invalid drone.";
            else if (Capacity <= drones.Count)
                return "Airfield is full.";
            else
            {
                drones.Add(drone);
                return $"Successfully added {drone.Name} to the airfield.";
            }
        }
        public bool RemoveDrone(string Name)
        {
            bool exists = false;
            foreach (var drone in drones)
            {
                if (drone.Name == Name)
                {
                    exists = true;
                    drones.Remove(drone);
                    break;
                }
            }
            if (!exists)
                return false;
            else
                return true;
        }
        public int RemoveDroneByBrand(string Brand)
        {
            int count = 0;
            for (int i = 0; i < drones.Count; i++)
            {
                if (drones[i].Brand == Brand)
                {
                    count++;
                    drones.Remove(drones[i]);
                    i--;
                }
            }
            return count;
        }
        public Drone FlyDrone(string Name)
        {
            bool exists = false;
            Drone drone1 = null;
            foreach (var drone in drones)
            {
                if (drone.Name == Name)
                {
                    drone.Available = false;
                    exists = true;
                    drone1 = drone;
                    break;
                }
            }
            if (exists)
                return drone1;
            else
                return null;
        }
        public List<Drone> FlyDronesByRange(int Range)
        {
            List<Drone> tempDrones = new List<Drone>();
            foreach (var drone in drones)
            {
                if (drone.Range >= Range)
                {
                    drone.Available = false;
                    tempDrones.Add(drone);
                }
            }
            return tempDrones;
        }
        public string Report()
        {
            string text = $"Drones Available at {Name}: {Environment.NewLine}";
            foreach (var drone in drones)
            {
                if (drone.Available == true)
                {
                    text += drone.ToString();
                }
            }
            return text;
            Stack<string> stack = new Stack<string>();
            stack.
        }
    }
}
