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
        public List<IObserver> observers;

        public override string Name { set; get; }

        public PersonComposite()
        {
            people = new List<PersonComponent>();
            observers = new List<IObserver>();
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
            NotifyObservers();
        }

        public void RemoveChild(PersonComponent p)
        {
            people.Remove(p);
            NotifyObservers();
        }

        public override void PrintRelativesOf(int spacing)
        {
            base.PrintRelativesOf(spacing);

            foreach (PersonComponent e in people)
            {
                e.PrintRelativesOf(spacing + 1);
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
            Console.WriteLine("{0} получил(a) уведомление об изменении в родовом древе. Подробнее? (y/n)", Name);
            switch (Console.ReadLine())
            {
                case "y":
                    PrintRelativesOf(1);
                    break;
            }
        }
    }
}
