using System;
using System.Drawing;
using System.Reflection;


namespace StupidCar {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter your brand, model, color, miles ");
            string brand = Console.ReadLine();
            string model = Console.ReadLine();
            string color = Console.ReadLine();
            int miles = int.Parse(Console.ReadLine());
            
            List<Car> carList = new List<Car>();
            Car car = new Car(brand, model, color, miles);
            carList.Add(car);
            car.Menu(carList);
        }
    }
}