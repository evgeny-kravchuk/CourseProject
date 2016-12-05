using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class PrintBoss
    {
        public static void PrintInfo(EmployeeComponent emplComp)
        {
            Console.WriteLine(string.Format("Имя: {0}", emplComp.Name));
            emplComp.Lead();
            emplComp.Salary();
            emplComp.Rise();
        }
    }
}
