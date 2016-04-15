using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Atanas", "Bogoe", "1234asd"),
                new Student("Bobo", "Ivanov", "9900023"),
                new Student("Gosho", "AAsds", "1234087asd"),
                new Student("Ancho", "dddsss", "1234asd"),
                new Student("Gancho", "Esswwov", "123487asd"),
                new Student("Mancho", "Adddss", "1234a55sd"),
                new Student("Vancho", "Aaawdww", "162346asd"),
                new Student("Ivancho", "Errad", "1234asd"),
                new Student("Rado", "Asdsdd", "1234a09sd")
            };

            List<Worker> workers = new List<Worker>
            {
                new Worker("Ivan", "Canova", 300M, 12),
                new Worker("Ivana", "Canovx", 340M, 12),
                new Worker("Ivanb", "Canovz", 3400M, 12),
                new Worker("Ivans", "Canovm", 350M, 12),
                new Worker("Ivand", "Canovn", 310M, 12),
                new Worker("Ivane", "Canovb", 320M, 12),
                new Worker("Ivang", "Canove", 300M, 12),
                new Worker("Ivanw", "Canovf", 330M, 12),
                new Worker("Ivanh", "Canovd", 390M, 12),
                new Worker("Ivanq", "Canova", 400M, 12)
            };

            var sortedStudents = students.OrderBy(student => student.FacultyNumber);
            var sortedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            var sortedHumans = humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);
            PrintList(sortedStudents);
            PrintList(sortedWorkers);
            PrintList(sortedHumans);
            
        }
        public static void PrintList<T>(IOrderedEnumerable<T> list)
        {
            foreach (var person  in list)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }
    } 
}
