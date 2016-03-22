using System;

namespace MinusRepositorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext()) {
                Student stu = new Student() { StudentName = "Wesley Reisz"};
                context.Students.Add(stu);
                context.SaveChanges();

                foreach (Student student in context.Students) {
                    Console.WriteLine("Student {0} :: {1}", student.StudentID, student.StudentName);
                }        
            }

            Console.Out.WriteLine("Press Any Key To Return");
            Console.Read();
        }
    }
}
