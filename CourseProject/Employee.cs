using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Employee : EmployeeComponent
    {
        public override string Name { get; set; }

        public override void PrintSupervisorOf(int spacing)
        {
            base.PrintSupervisorOf(spacing);
        }

        public override void Salary()
        {
            base.Salary();
        }

        public override double getSalary()
        {
            return base.getSalary();
        }

        public override void Rise()
        {
            Console.Write("Надбавка сотрудника: Отсутствует\n");
        }

        public override void Lead()
        {
            Console.Write("Подчиненные сотрудника: Отсутствуют\n");
        }
    }
}
