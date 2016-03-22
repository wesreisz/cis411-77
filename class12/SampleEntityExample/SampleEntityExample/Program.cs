using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            initiateData();
            getSomeEmployee();
            Console.WriteLine("Press Any Key to Continue");
            Console.Read();
        }

        private static void initiateData()
        {
            using (var repo = new EmployeeRespository()) {
                Employee em = new Employee() { FullName = "Wesley Reisz"};
                repo.InsertOrUpdates(em);
                repo.Save();         
            }
        }

        public static void getSomeEmployee() {
            using (var repo = new EmployeeRespository())
            {
                foreach (var emp in repo.All)
                {
                    Console.WriteLine("{0} - {1}", emp.Id, emp.FullName);
                }
            }
        }
    }
}
