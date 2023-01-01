using System;
using List_librarry_own;
using System.Collections.Generic;
using System.Linq;

namespace Test_Of_Own_Library {
    internal class Program {
        static void Main(string[] args) {
            
            ListingCLass list = new ListingCLass();
            list.Initialize();
            list.TestCommandsList();
        }
    }
}