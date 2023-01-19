using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace List_librarry_own {
    public class ListingCLass {
        private List<int> numbers;

        public void Initialize() {
            Console.Write("Enter your nummbers here >> ");
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        }

        public void TestCommandsList()
        {

            while (true) {
                Console.WriteLine("The possable inputs are:");
                Console.WriteLine("Add + element");
                Console.WriteLine("Remove + element");
                Console.WriteLine("RemoveAt + possition");
                Console.WriteLine("Insert + element + possition");
                Console.WriteLine("Constains + element");
                Console.WriteLine("PrintEven");
                Console.WriteLine("PrintOdd");
                Console.WriteLine("GetSum");
                Console.WriteLine("EqualTo");
                Console.WriteLine("PrintList");
                Console.WriteLine("End");
                Console.Write("Enter your input here >> ");

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
                        int num = int.Parse(input[1]);
                        numbers.Add(num);
                        Console.Clear();
                        break;

                    case "Remove":
                        int num1 = int.Parse(input[1]);
                        numbers.Remove(num1);
                        Console.Clear();
                        break;

                    case "RemoveAt":
                        int index = int.Parse(input[1]);
                        numbers.RemoveAt(index);
                        Console.Clear();
                        break;

                    case "Insert":
                        int num2 = int.Parse(input[1]);
                        int index1 = int.Parse(input[2]);
                        numbers.Insert(index1 - 1, num2);
                        Console.Clear();
                        break;

                    case "Contains":
                        int num3 = int.Parse(input[1]);
                        if (numbers.Contains(num3)) Console.WriteLine("Yes");
                        else Console.WriteLine("Such number doesnt exist");
                        Console.Clear();
                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                        Console.Clear();
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                        Console.Clear();
                        break;

                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        Console.Clear();
                        break;

                    case "EqualTo":
                        int number = int.Parse(input[1]);
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x == number)));
                        Console.Clear();
                        break;

                    case "PrintList":
                        Console.WriteLine(string.Join(" ", numbers));
                        Console.WriteLine("######################################");
                        break;

                    default:
                        break;
                }
            }
        }
    }
}