using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Person : PersonComponent
    {
        public override string Name { set; get; }

        public override void PrintRelativesOf(int spacing)
        {
            base.PrintRelativesOf(spacing);
        }

        public override void Heirs()
        {
            base.Heirs();
        }
        public override double getHeirs()
        {
            return base.getHeirs();
        }
    }
}
