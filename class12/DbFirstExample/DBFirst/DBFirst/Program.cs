using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Entities()) {
                foreach (Student student in context.Students) {
                    Console.WriteLine("Student {0} : {1}", student.StudentID, student.StudentName);
                }
            }

            Console.WriteLine("Press Any Key to Continue");
            Console.Read();
        }
    }
}
