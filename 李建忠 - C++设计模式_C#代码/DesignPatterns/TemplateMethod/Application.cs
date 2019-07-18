using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class Application : Libarary
    {
        protected override void Step1()
        {
            Console.WriteLine("Step1");
        }

        protected override void Step3()
        {
            Console.WriteLine("Step3");
        }

        protected override void Step5()
        {
            Console.WriteLine("Step5");
        }
    }
}
