using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class PersonComposite : PersonComponent
    {
        public IList<PersonComponent> people;

        public override string Name { set; get; }

        public PersonComposite()
        {
            people = new List<PersonComponent>();
        }

        public override void Heirs()
        {
            int heirs = 0;
            foreach (PersonComponent e in people)
            {
                heirs++;
            }
            Console.WriteLine("Наследники: " + heirs);
        }

        public override double getHeirs()
        {
            int heirs = 0;
            foreach (PersonComponent e in people)
            {
                heirs++;
            }
            return heirs;
        }

        public override void Children()
        {
            Console.Write("Дети: ");
            foreach (PersonComponent e in people)
            {
                Console.Write(e.Name + " ");
            }
            Console.WriteLine();
        }

        public void AddChild(PersonComponent p)
        {
            people.Add(p);
        }

        public void RemoveChild(PersonComponent p)
        {
            people.Remove(p);
        }

        public override void PrintRelativesOf(int spacing)
        {
            base.PrintRelativesOf(spacing);

            foreach (PersonComponent e in people)
            {
                e.PrintRelativesOf(spacing + 1);
            }
        }
    }
}
