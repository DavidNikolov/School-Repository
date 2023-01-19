using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo 
{
    public class Zoo 
    {
        private string zooName;
        private int capacity;
        private List<Animals> animals;

        public Zoo(string name, int capacity)
        {
            this.ZooName = name;
            this.Capacity= capacity;
            this.animals = new List<Animals>();
        }

        public string ZooName 
        {
            get { return zooName; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Name!");
                }
                this.zooName = value;
            }
        }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if(value < 1 || value > 30)
                {
                    throw new ArgumentException("Invalid capacity!");
                }
                this.capacity = value;
            }
        }

        public List<Animals> Animals
        {
            get { return animals; }
        }

        public override string ToString()
        {
            string result = string.Empty;

            result = $"{this.ZooName} zoo with {this.Capacity} has {this.Animals.Count}";
            
            return result;
        }

    }   
}
