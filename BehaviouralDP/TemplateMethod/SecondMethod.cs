using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.TemplateMethod
{
    public class SecondMethod : Template
    {
        protected override void Step1()
        {
            Console.WriteLine("step 1 with second method");
        }

        protected override void Step2()
        {
            Console.WriteLine("step 2 with second method");
        }

        protected override void Step3()
        {
            Console.WriteLine("step 3 with second method");
        }
    }

}
