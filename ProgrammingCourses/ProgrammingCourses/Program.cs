using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourses {   
    class Program {
        static void Main(string[] args) {
            int enumlen = Enum.GetNames(typeof(Courses)).Length;//Извлича имената от изброяването в масив и след това взема размера на масива
            Person.SetListCourses(enumlen); //Извиква статична функция, която създава списък с курсовете. Този списък съдържа броя на курсистите записали се за съответния курс.

            List<Person> persons = new List<Person>();

            try {
                Person person1 = new Person("Ivan", "Ivanov", 16, new Courses[] { Courses.Python, Courses.CSharp});
                persons.Add(person1);
                
                Person person2 = new Person("Jordan", "Jordanov", 20, new Courses[] { Courses.HTML, Courses.JavaScript});
                persons.Add(person2);
                
                Person person3 = new Person("Dimitar", "Dimitrov", 24, new Courses[] { Courses.C, Courses.CPlusPlus, Courses.CSharp, Courses.Python});
                persons.Add(person3);

                persons.OrderByDescending(p => p.TotalCostCourses).ToList().ForEach(p => Console.WriteLine(p));
                Person.printNumberPersonInCource();

                Console.WriteLine("\n*****************************************");
                Console.WriteLine("\nIntroduce an increase in the price of courses: ");
                int percent = int.Parse(Console.ReadLine());//Процент увеличаване на цената на курсовете
                persons.ForEach(p => p.IncreaseTotalCostCourses(percent));//Увеличаваме общата цена на курсовете
                persons.OrderByDescending(p => p.TotalCostCourses).ToList().ForEach(p => Console.WriteLine(p));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}