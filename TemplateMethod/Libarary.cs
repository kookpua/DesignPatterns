using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class Libarary
    {
        /// <summary>
        /// 流程定义在父类中
        /// </summary>
        public void Run()
        {
            Step1();
            Step2();
            Step3();
            Step4();
            Step5();
        }
        protected abstract void Step1();
        protected void Step2()
        {
            Console.WriteLine("Step2");
        }
        protected abstract void Step3();
        protected void Step4()
        {
            Console.WriteLine("Step4");
        }
        protected abstract void Step5();
    }
}
