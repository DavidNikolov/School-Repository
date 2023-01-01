using System;
using Lib1;

namespace ConsoleApp1 {
    
    internal class Program {
        
        static void Main(string[] args) {
            
            Console.Write("Enter values for the array separated by spaces\n\n>> ");

            string[] temp = Console.ReadLine().Split(' ');
            int[] arr = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                arr[i] = int.Parse(temp[i]);
            }
            while (true) {

                Console.WriteLine("Choose a function: \n1.Sort\n2.Find an element\n");
                Console.Write(">>  ");
                int p = int.Parse(Console.ReadLine());
                switch (p) {

                    case 1:
                        Console.WriteLine("Choose a sorting method: \n1.Bubble Sort\n2.Selection Sort\n3.Merge Sort\n");
                        Console.Write(">> ");
                        int j = int.Parse(Console.ReadLine());
                        switch (j) {
                            case 1:
                                Sort.bubbleSort(arr);
                                Sort.printArray(arr);
                                break;
                            
                            case 2:
                                Sort.SelectionSort(arr);
                                Sort.printArray(arr);
                                break;
                            
                            case 3:
                                Sort.MergesSort(arr,0,arr.Length);
                                Sort.printArray(arr);
                                break;
                        }
                        break;
                    
                    case 2:
                        Console.WriteLine("What are you looking for?\n");
                        Console.Write(">> ");
                        
                        int x = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Choose a finding method: \n1. Linear Search\n2. Binary Search\n");
                        Console.Write(">> ");
                       
                        int j1 = int.Parse(Console.ReadLine());
                        
                        switch (j1) {
                            case 1:
                                int fin = Search.LinearSearch(arr, x);

                                if (fin == -1) {
                                    Console.WriteLine("The value does not exist");
                                    break;
                                }

                                Console.WriteLine($"It is at position #{fin + 1}");
                                break;
                            
                            case 2:
                                fin = Search.BinarySearch(arr, x);
                                if (fin == -1) {
                                    Console.WriteLine("The value does not exist");
                                    break;
                                }
                                Console.WriteLine($"It is at position #{fin + 1}");
                                break;
                        }
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
