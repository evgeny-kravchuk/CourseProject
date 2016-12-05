using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class EmployeeComposite : EmployeeComponent
    {
        public IList<EmployeeComponent> employees;

        public override string Name { get; set; }

        public EmployeeComposite()
        {
            employees = new List<EmployeeComponent>();
        }

        public override void Salary()
        {
            int countRise = 1000;
            foreach (EmployeeComponent e in employees)
            {
                countRise = countRise + 100;
            }
            Console.WriteLine("Зарплата сотрудника: " + countRise);
        }

        public override double getSalary()
        {
            double countRise = 1000;
            foreach (EmployeeComponent e in employees)
            {
                countRise = countRise + 100;
            }
            return countRise;
        }

        public override void Rise()
        {
            int countRise = 0;
            foreach (EmployeeComponent e in employees)
            {
                countRise = countRise + 100;
            }
            Console.Write("Надбавка сотрудника: " + countRise + "\n");
        }

        public override void Lead()
        {
            Console.Write("Подчиненные сотрудника: ");
            foreach (EmployeeComponent e in employees)
            {
                Console.Write(e.Name + " ");
            }
            Console.WriteLine();
        }

        public void AddEmployee(EmployeeComponent e)
        {
            employees.Add(e);
        }

        public void RemoveEmployee(EmployeeComponent e)
        {
            employees.Remove(e);
        }

        public override void PrintSupervisorOf(int spacing)
        {
            base.PrintSupervisorOf(spacing);

            foreach (EmployeeComponent e in employees)
            {
                e.PrintSupervisorOf(spacing + 1);
            }
        }
    }
}
