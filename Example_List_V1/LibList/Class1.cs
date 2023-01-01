using System;
using System.Collections.Generic;
using System.Linq;

namespace LibList {
    public class ClassList {
        
        private List<int> numbers;
        int n;
        public ClassList() {
           
        }


        public void Initi() {
            numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        }
           
        static public void f1(ClassList obj)
        {
            obj.n = 20;
        }

        public void TestCommandsList()
        {
     
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];

                if (command == "End")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }

                switch (command)
                {
                    case "Add":
                        {
                            int number = int.Parse(input[1]);
                            numbers.Add(number);
                            break;
                        }
                    case "Remove":
                        {
                            int number = int.Parse(input[1]);
                            numbers.Remove(number);
                            break;
                        }
                    case "RemoveAt":
                        {
                            int index = int.Parse(input[1]);
                            numbers.RemoveAt(index);
                            break;
                        }
                    case "Insert":
                        {
                            int number = int.Parse(input[1]);
                            int index = int.Parse(input[2]);
                            numbers.Insert(index, number);
                            break;
                        }
                    case "Contains":
                        {
                            int number = int.Parse(input[1]);
                            if (numbers.Contains(number))
                            {
                                Console.WriteLine("Yes");
                            }
                            else
                            {
                                Console.WriteLine("No such number");
                            }
                            break;
                        }
                    case "PrintEven":
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                            break;
                        }
                    case "PrintOdd":
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                            break;
                        }
                    case "GetSum":
                        {
                            Console.WriteLine(numbers.Sum());
                            break;
                        }
                    case "EqualTo":
                        {

                            int number = int.Parse(input[1]);
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x == number)));
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
