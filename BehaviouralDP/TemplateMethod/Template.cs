using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.TemplateMethod
{
    public abstract class Template
    {
        public void Do()
        {
            Step1();
            Step2();
            Step3();
        }

        protected abstract void Step1();
        protected abstract void Step2();

        protected virtual void Step3()
        {
            Console.WriteLine("Default implementation for step 3");
        }
    }
}
