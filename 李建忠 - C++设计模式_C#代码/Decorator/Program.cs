using System;

namespace GSL_Decorator_pattern
{
    /// <summary>
    ///此demo来自维基百科：https://zh.wikipedia.org/wiki/%E4%BF%AE%E9%A5%B0%E6%A8%A1%E5%BC%8F
    ///印象笔记镜像： https://app.yinxiang.com/fx/ed3cc767-1dc3-41e7-8734-55947833cc42
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ControlComponent c1 = new ControlComponent();
            DecorationA a = new DecorationA(c1);
            a.Draw();
            a.GetDescription();

            DecorationB b = new DecorationB(c1);
            b.Draw();
            b.GetDescription();

            DecorationC c = new DecorationC(c1);
            c.Draw();
            c.GetDescription();


            DecorationC c2 = new DecorationC(b);
            c2.Draw();
            c2.GetDescription();


            DecorationB b2 = new DecorationB(c);
            b2.Draw();
            b2.GetDescription();
        }

    }
    interface IWindowObject
    {
        void Draw(); // draws the object
        string GetDescription(); // returns a description of the object
    }

    class ControlComponent : IWindowObject
    {
        public ControlComponent()
        {
        }

        public void Draw() // draws the object
        {
            Console.WriteLine("ControlComponent::draw()");
        }

        public string GetDescription() // returns a description of the object
        {
            return "ControlComponent::getDescription()";
        }
    }

    abstract class Decorator : IWindowObject
    {
        protected IWindowObject _decoratedWindow = null; // the object being decorated

        public Decorator(IWindowObject decoratedWindow)
        {
            _decoratedWindow = decoratedWindow;
        }

        public virtual void Draw()
        {
            _decoratedWindow.Draw();
            Console.WriteLine("\tDecorator::draw() ");
        }

        public virtual string GetDescription() // returns a description of the object
        {
            return _decoratedWindow.GetDescription() + "\n\t" + "Decorator::getDescription() ";
        }
    }

    // the first decorator 
    class DecorationA : Decorator
    {
        public DecorationA(IWindowObject decoratedWindow) : base(decoratedWindow)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DecorationAStuff();
        }

        private void DecorationAStuff()
        {
            Console.WriteLine("\t\tdoing DecorationA things");
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\n\t\tincluding " + this.ToString();
        }

    }// end  class ConcreteDecoratorA : Decorator

    class DecorationB : Decorator
    {
        public DecorationB(IWindowObject decoratedWindow) : base(decoratedWindow)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DecorationBStuff();
        }

        private void DecorationBStuff()
        {
            Console.WriteLine("\t\tdoing DecorationB things");
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\n\t\tincluding " + this.ToString();
        }

    }// end  class DecorationB : Decorator

    class DecorationC : Decorator
    {
        public DecorationC(IWindowObject decoratedWindow) : base(decoratedWindow)
        {
        }

        public override void Draw()
        {
            base.Draw();
            DecorationCStuff();
        }

        private void DecorationCStuff()
        {
            Console.WriteLine("\t\tdoing DecorationC things");
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\n\t\tincluding " + this.ToString();
        }

    }// end  class DecorationC : Decorator

}// end of namespace GSL_Decorator_patternpublic class MyClass