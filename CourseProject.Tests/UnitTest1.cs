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
        public void Check_adding_personComposite_and_person()
        {
            PersonComposite first_person = new PersonComposite();
            PersonComposite second_person = new PersonComposite();
            Person third_person = new Person();
            Person fourth_person = new Person();

            first_person.AddChild(second_person);
            first_person.AddChild(fourth_person);
            second_person.AddChild(third_person);

            Assert.IsTrue((first_person.people).Contains(second_person));
            Assert.IsTrue((first_person.people).Contains(fourth_person));
            Assert.IsTrue((second_person.people).Contains(third_person));
        }
        [TestMethod]
        public void Check_observer_employeeComposite_and_employee()
        {
            EmployeeComposite first_person = new EmployeeComposite();
            EmployeeComposite second_person = new EmployeeComposite();
            Employee third_person = new Employee();
            Employee fourth_person = new Employee();

            first_person.AddEmployee(second_person);
            first_person.AddEmployee(fourth_person);
            second_person.AddEmployee(third_person);

            first_person.Subscribe(second_person);
            first_person.Subscribe(fourth_person);
            second_person.Subscribe(third_person);

            first_person.Unsubscribe(fourth_person);

            Assert.IsTrue((first_person.observers).Contains(second_person));
            Assert.IsFalse((first_person.observers).Contains(fourth_person));
            Assert.IsTrue((second_person.observers).Contains(third_person));
        }
        [TestMethod]
        public void Check_observer_personComposite_and_person()
        {
            PersonComposite first_person = new PersonComposite();
            PersonComposite second_person = new PersonComposite();
            Person third_person = new Person();
            Person fourth_person = new Person();

            first_person.AddChild(second_person);
            first_person.AddChild(fourth_person);
            second_person.AddChild(third_person);

            first_person.Subscribe(second_person);
            first_person.Subscribe(fourth_person);
            second_person.Subscribe(third_person);

            first_person.Unsubscribe(fourth_person);

            Assert.IsTrue((first_person.observers).Contains(second_person));
            Assert.IsFalse((first_person.observers).Contains(fourth_person));
            Assert.IsTrue((second_person.observers).Contains(third_person));
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
        [TestMethod]
        public void getHeirs_for_child_and_parent()
        {
            PersonComposite first_person = new PersonComposite();
            Person second_person = new Person();
            Person third_person = new Person();

            first_person.AddChild(second_person);
            first_person.AddChild(third_person);

            double justSal = second_person.getHeirs();
            double riseSal = first_person.getHeirs();

            Assert.AreEqual(0, justSal);
            Assert.AreEqual(2, riseSal);
        }
    }
}
