using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourses {   
    class Program {
        static void Main(string[] args) {

            if(David.IsTogetherWith("Eli")) {
                David.mood = "happy";
            }
            else{
                // nahh fuck that shit
            }



            if(Eli.IsTogetherWith("David")) {
                Eli.mood = "happy";
            }
            else{
                // nahh fuck that shit
            }
        }
    }
}