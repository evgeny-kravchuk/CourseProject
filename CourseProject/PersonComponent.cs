using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public abstract class PersonComponent : IObserver
    {
        public virtual string Name { set; get; }

        public virtual void PrintRelativesOf(int spacing)
        {
            for (int counter = 0; counter < spacing; counter++)
            {
                Console.Write("-");
            }
            Console.WriteLine(Name);
        }

        public virtual void Heirs()
        {
            int heirs = 0;
            Console.WriteLine("Наследники: " + heirs);
        }

        public virtual double getHeirs()
        {
            return 0;
        }

        public virtual void Children()
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
