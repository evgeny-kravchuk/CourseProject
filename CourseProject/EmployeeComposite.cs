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
        public List<IObserver> observers;

        public override string Name { get; set; }

        public EmployeeComposite()
        {
            employees = new List<EmployeeComponent>();
            observers = new List<IObserver>();
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
            NotifyObservers();
        }

        public void RemoveEmployee(EmployeeComponent e)
        {
            employees.Remove(e);
            NotifyObservers();
        }

        public override void PrintSupervisorOf(int spacing)
        {
            base.PrintSupervisorOf(spacing);

            foreach (EmployeeComponent e in employees)
            {
                e.PrintSupervisorOf(spacing + 1);
            }
        }

        public override void NotifyObservers()
        {
            Update();
        }

        public override void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public override void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public override void Update()
        {
            Console.WriteLine("{0} получил(a) уведомление об изменении среди подчиненных. Подробнее? (y/n)", Name);
            switch (Console.ReadLine())
            {
                case "y":
                    PrintSupervisorOf(1);
                    break;
            }
        }
    }
}
