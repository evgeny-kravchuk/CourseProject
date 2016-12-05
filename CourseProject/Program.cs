using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("===== Co-workers =====\n");

            EmployeeComposite lori = new EmployeeComposite();
            lori.Name = "Лора";

            EmployeeComposite mark = new EmployeeComposite();
            mark.Name = "Марк";
            EmployeeComposite kathy = new EmployeeComposite();
            kathy.Name = "Катя";

            Employee liza = new Employee();
            liza.Name = "Лиза";
            Employee david = new Employee();
            david.Name = "Девид";

            EmployeeComposite mike = new EmployeeComposite();
            mike.Name = "Майк";

            Employee igorr = new Employee();
            igorr.Name = "Игорь";
            Employee zhenya = new Employee();
            zhenya.Name = "Женя";

            lori.AddEmployee(mark);
            lori.Subscribe(mark);
            lori.AddEmployee(kathy);
            lori.Subscribe(kathy);

            mark.AddEmployee(liza);
            mark.Subscribe(liza);
            mark.AddEmployee(david);
            mark.Subscribe(david);

            kathy.AddEmployee(mike);
            kathy.Subscribe(mike);

            mike.AddEmployee(igorr);
            mike.Subscribe(igorr);
            mike.AddEmployee(zhenya);
            mike.Subscribe(zhenya);

            Console.WriteLine();
            lori.PrintSupervisorOf(5);

            Console.WriteLine("\n--- Info about co-workers ---\n");

            PrintBoss.PrintInfo(lori);

            Console.WriteLine("\n--- Co-workers (using observer) ---\n");
            kathy.RemoveEmployee(mike);
            mike.RemoveEmployee(igorr);
            mark.RemoveEmployee(david);

            Console.WriteLine("\n===== Relatives =====\n");

            PersonComposite volodymyr = new PersonComposite();
            volodymyr.Name = "Владимир";

            PersonComposite anatolii = new PersonComposite();
            anatolii.Name = "Толя";
            PersonComposite igor = new PersonComposite();
            igor.Name = "Игорь";

            Person artyom = new Person();
            artyom.Name = "Артём";
            Person olya = new Person();
            olya.Name = "Оля";

            Person evhenii = new Person();
            evhenii.Name = "Евгений";
            Person alyona = new Person();
            alyona.Name = "Альона";

            volodymyr.AddChild(anatolii);
            volodymyr.Subscribe(anatolii);
            volodymyr.AddChild(igor);
            volodymyr.Subscribe(igor);

            anatolii.AddChild(artyom);
            anatolii.Subscribe(artyom);
            anatolii.AddChild(olya);
            anatolii.Subscribe(olya);

            igor.AddChild(evhenii);
            igor.Subscribe(evhenii);
            igor.AddChild(alyona);
            igor.Subscribe(alyona);

            Console.WriteLine();
            volodymyr.PrintRelativesOf(5);

            Console.WriteLine("\n--- Info about relatives (using adapter) ---\n");

            PrintBossAdapterForRelatives adapterVolodymyr = new PrintBossAdapterForRelatives(volodymyr);
            PrintBoss.PrintInfo(adapterVolodymyr);

            Console.WriteLine("\n--- Relatives (using observer) ---\n");
            volodymyr.RemoveChild(anatolii);
            anatolii.RemoveChild(artyom);
            anatolii.RemoveChild(olya);

            Console.ReadKey();
        }
    }
}
