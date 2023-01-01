using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourses {   
    enum Courses {
        CSharp = 0,
        CPlusPlus,
        C,
        Python,
        JavaScript,
        HTML,
        Haskell,
        Prolog
    }
    enum Prices {
        CSharpPrice = 100,
        CPlusPlusPrice = 200 ,
        CPrice = 250,
        PythonPrice = 60,
        JavaScriptPrice = 60,
        HTMLPrice = 70,
        HaskellPrice = 100,
        PrologPrice = 100
    }

    class Person
    {
        static private int[] NumberPersonToCourse;
        static private double GlobalPrice;
        private string firstName;
        private string lastName;
        private int age;
        private double totalCostCourses;
        private Courses[] courses;
        private Prices[] prices;

        static public void SetListCourses(int num) {
            NumberPersonToCourse = new int[num];
        }

        public Person(string firstName, string lastName, int age, Courses[] c) {
            
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.courses = c;
            int i = 0;
            this.prices = new Prices[c.Length];
            

            foreach (var course in courses) { //За всеки избран курс инкрементираме брояча
                NumberPersonToCourse[(int)course]++;//NumberPersonToCourse[0]=CSharp брой записани, NumberPersonToCourse[1]=CPlusPlus брой записани, ...
                switch(course) {
                    case Courses.CSharp:
                        this.TotalCostCourses += Convert.ToDouble(Prices.CSharpPrice);   
                    break;
                    
                    case Courses.CPlusPlus:
                        this.TotalCostCourses += Convert.ToDouble(Prices.CPlusPlusPrice);
                    break;
                    
                    case Courses.C:
                        this.TotalCostCourses += Convert.ToDouble(Prices.CPrice);
                    break;
                    
                    case Courses.Python:
                        this.TotalCostCourses += Convert.ToDouble(Prices.PythonPrice);
                    break;
                    
                    case Courses.JavaScript:
                        this.TotalCostCourses += Convert.ToDouble(Prices.JavaScriptPrice);
                    break;
                    
                    case Courses.HTML:
                        this.TotalCostCourses += Convert.ToDouble(Prices.HTMLPrice);
                    break;
                    
                    case Courses.Haskell:
                        this.TotalCostCourses += Convert.ToDouble(Prices.HaskellPrice);
                    break;
                    
                    case Courses.Prolog:
                        this.TotalCostCourses += Convert.ToDouble(Prices.PrologPrice);
                    break;
                    
                    default:
                        throw new ArgumentException("And error occured in the courses!!");
                }
                     
                switch(course) {
                    case Courses.CSharp:
                        prices[i] = Prices.CSharpPrice;
                        i += 1;
                    break;
                    
                    case Courses.CPlusPlus:
                        prices[i] = Prices.CPlusPlusPrice;
                        i += 1;
                    break;
                    
                    case Courses.C:
                        prices[i] = Prices.CPrice;
                        i += 1;
                    break;
                    
                    case Courses.Python:
                        prices[i] = Prices.PythonPrice;
                        i += 1;
                    break;
                    
                    case Courses.JavaScript:
                        prices[i] = Prices.JavaScriptPrice;
                        i += 1;
                    break;
                    
                    case Courses.HTML:
                        prices[i] = Prices.HTMLPrice;
                        i += 1;
                    break;
                    
                    case Courses.Haskell:
                        prices[i] = Prices.HaskellPrice;
                        i += 1;
                    break;
                    
                    case Courses.Prolog:
                        prices[i] = Prices.PrologPrice;
                        i += 1;
                    break;
                    
                    default:
                        throw new ArgumentException("And error occured in the prices!!");
                }
            }
        }
        
        static public void printNumberPersonInCource() {
            Console.WriteLine("");
            Console.WriteLine("Commont Persons in course:");

            for (int i = 0; i < NumberPersonToCourse.Length; i++) {
                Console.Write(NumberPersonToCourse[i] + ". ");
                Console.WriteLine((Courses)i);
            }

            Console.WriteLine("Global Price paid for all courses: " + GlobalPrice);
        }

        public string FirstName {
            get { return firstName; }
            set {
                if (value.Length < 3) throw new ArgumentException("Invalid firstName!");               
                firstName = value;
            }
        }

        public string LastName {
            get { return lastName; }
            set {
                if (value.Length < 3) throw new ArgumentException("Invalid lastName!");
                lastName = value;
            }
        }

        public int Age {
            get { return age; }
            set {
                if (value < 16) throw new ArgumentException("The course is not suitable for persons under the age of 16.");
                age = value;
            }
        }

        public double TotalCostCourses {
            get { return totalCostCourses; }
            set {
                if (value < 0 || value > 2000) throw new ArgumentException("Invalid cost of course. Mast be > 0 and < 2000");
                totalCostCourses = value;
            }
        }

        public override string ToString() {
            string s = this.firstName + " " + this.lastName + " is " + this.age + " years old." + "Total Cost Courses = " + this.TotalCostCourses;
            GlobalPrice += TotalCostCourses;
            int index = 0;
            s += "\nCourses:\n";
            Console.WriteLine("");

            foreach(var course in courses){
                s += course + " - " + Convert.ToDouble(prices[index]) + "; ";
                index ++;
            }
            return s;
        }
        public void IncreaseTotalCostCourses(double percent) {

            if (this.age < 18) this.TotalCostCourses += this.TotalCostCourses * percent / 100 / 2;

            else this.TotalCostCourses += this.TotalCostCourses * percent / 100;     
        }
    }
}