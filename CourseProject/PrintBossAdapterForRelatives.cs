using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class PrintBossAdapterForRelatives : EmployeeComponent
    {
        private PersonComponent _personComponent;

        public PrintBossAdapterForRelatives(PersonComponent personComponent)
        {
            _personComponent = personComponent;
        }

        public override string Name
        {
            get
            {
                return _personComponent.Name;
            }
            set { }
        }

        public override void Lead()
        {
            _personComponent.Children();
        }

        public override void Salary()
        {
            _personComponent.Heirs();
        }

        public override void Rise()
        {
        }
    }
}
