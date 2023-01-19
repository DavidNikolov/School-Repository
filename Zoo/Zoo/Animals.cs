using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animals
    {
        private string type;
        private int age;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Animals(string type, int age)
        {
            this.Type = type;
            this.Age = age;
        }
    }
}
