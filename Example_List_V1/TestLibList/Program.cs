using System;
using LibList;
using System.Collections.Generic;
using System.Linq;

namespace TestLibList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassList obj = new ClassList();
            //obj.numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            obj.Initi();
            obj.TestCommandsList();

            ClassList.f1(obj);
        }
    }
}