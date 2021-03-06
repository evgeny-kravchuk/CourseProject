﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public abstract class EmployeeComponent : IObserver
    {
        public virtual string Name { set; get; }

        public virtual void PrintSupervisorOf(int spacing)
        {
            for (int counter = 0; counter < spacing; counter++)
            {
                Console.Write("-");
            }
            Console.WriteLine(Name);
        }

        public virtual void Salary()
        {
            int sal = 1000;
            Console.WriteLine("Зарплата сотрудника: " + sal);
        }

        public virtual double getSalary()
        {
            return 1000;
        }

        public virtual void Rise()
        {
        }

        public virtual void Lead()
        {
        }

        public virtual void NotifyObservers()
        {
        }

        public virtual void Subscribe(IObserver observer)
        {
        }

        public virtual void Unsubscribe(IObserver observer)
        {
        }

        public virtual void Update()
        {
        }
    }
}
