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
            lori.AddEmployee(kathy);

            mark.AddEmployee(liza);
            mark.AddEmployee(david);

            kathy.AddEmployee(mike);

            mike.AddEmployee(igorr);
            mike.AddEmployee(zhenya);

            Console.WriteLine();
            lori.PrintSupervisorOf(5);

            Console.WriteLine("\n--- Info about co-workers ---\n");

            PrintBoss.PrintInfo(lori);

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
            volodymyr.AddChild(igor);

            anatolii.AddChild(artyom);
            anatolii.AddChild(olya);

            igor.AddChild(evhenii);
            igor.AddChild(alyona);

            Console.WriteLine();
            volodymyr.PrintRelativesOf(5);

            Console.WriteLine("\n--- Info about relatives (using adapter) ---\n");

            PrintBossAdapterForRelatives adapterVolodymyr = new PrintBossAdapterForRelatives(volodymyr);
            PrintBoss.PrintInfo(adapterVolodymyr);
            
            Console.ReadKey();
        }
    }
}
