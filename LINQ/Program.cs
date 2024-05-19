using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));


           
        }
        static string[] GetAllStudents(Classroom[] classes)
        {
            var sel = from cs in classes
                      from st in cs.Students
                      select st;


            return sel.ToArray();



        }
    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}
