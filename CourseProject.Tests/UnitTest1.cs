using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourseProject.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_adding_employeeComposite_and_employee()
        {
            EmployeeComposite first_person = new EmployeeComposite();
            EmployeeComposite second_person = new EmployeeComposite();
            Employee third_person = new Employee();
            Employee fourth_person = new Employee();

            first_person.AddEmployee(second_person);
            first_person.AddEmployee(fourth_person);
            second_person.AddEmployee(third_person);

            Assert.IsTrue((first_person.employees).Contains(second_person));
            Assert.IsTrue((first_person.employees).Contains(fourth_person));
            Assert.IsTrue((second_person.employees).Contains(third_person));
        }
        [TestMethod]
        public void getSalary_for_employee_and_boss()
        {
            EmployeeComposite first_person = new EmployeeComposite();
            Employee second_person = new Employee();
            Employee third_person = new Employee();

            first_person.AddEmployee(second_person);
            first_person.AddEmployee(third_person);

            double justSal = second_person.getSalary();
            double riseSal = first_person.getSalary();

            Assert.AreEqual(1000, justSal);
            Assert.AreEqual(1200, riseSal);
        }
    }
}
