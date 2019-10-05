using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate = new DateTime(2000, 05, 24);
            Employee employee = new Employee("Jack", birthDate, Gender.FEMALE, 5000, "Engineer");
            Console.WriteLine(employee);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
