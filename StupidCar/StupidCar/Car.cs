using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidCar
{
    public class Car
    {

        private string brand;
        private string model;
        private string color;
        private int miles;
        public string Brand {
            get { return brand; }
            set { brand = value; }
        }

        public string Model {
            get { return model; }
            set { model = value; }
        }

        public string Color {
            get { return color; }
            set { color = value; }
        }

        public int Miles {
            get { return miles; }
            set { miles = value; }
        }

        public Car(string brand, string model, string color, int miles) {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Miles = miles;
        }

        public void Menu(List<Car> carList) { 
            
            while (true) {

                Console.WriteLine("Your options are:");
                Console.WriteLine("Add");
                Console.WriteLine("Remove");
                Console.WriteLine("ChangeColor");
                Console.WriteLine("ChangeMiles");
                Console.WriteLine("DisplayGarage");
                Console.WriteLine("end");
                Console.Write("Chose and option >> ");
                string option = Console.ReadLine();
                string brand, model, color;
                int miles, index;

                if (option == "End")
                {
                    break;
                }

                switch (option)
                {
                    case "Add":
                        Console.Write("Enter your brand, model, color, miles");
                        brand = Console.ReadLine();
                        model = Console.ReadLine();
                        color = Console.ReadLine();
                        miles = int.Parse(Console.ReadLine());
                        Car newCar = new Car(brand, model, color, miles);
                        carList.Add(newCar);
                        Console.Clear();
                        break;

                    case "Remove":
                        Console.Write("Enter the number of the car you want to remove >>");
                        index = int.Parse(Console.ReadLine());
                        carList.RemoveAt(index - 1);
                        Console.Clear();
                        break;

                    case "ChangeColor":
                        Console.Write("Enter the number of the car you want to change color to >>");
                        index = int.Parse(Console.ReadLine());
                        Console.Write("what color do you want >>");
                        color = Console.ReadLine();
                        carList[index = 1].color = color;
                        Console.Clear();
                        break;

                    case "ChangeMiles":
                        Console.Write("Enter the number of the car you want to change the miles to >>");
                        index = int.Parse(Console.ReadLine());
                        Console.Write("enter the miles >>");
                        miles = int.Parse(Console.ReadLine());
                        carList[index = 1].miles = miles;
                        Console.Clear();
                        break;

                    case "DisplayGarage":
                        foreach (var item in carList) Console.WriteLine(item.ToString());
                        Console.WriteLine("###################################");
                        break;


                }
            }
        }

        public override string ToString()
        {
            
            string result = string.Empty;
            result = $"{this.Brand}, {this.Model}, {this.Color}, {this.Miles}";
            return result;
        }
    }
}