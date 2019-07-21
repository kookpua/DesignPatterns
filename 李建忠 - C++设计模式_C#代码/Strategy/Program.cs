using System;

namespace Strategy
{
    /// <summary>
    /// 此demo来自维基百科：https://zh.wikipedia.org/wiki/%E7%AD%96%E7%95%A5%E6%A8%A1%E5%BC%8F#C#
    /// 印象笔记镜像：https://app.yinxiang.com/fx/34e4ab9e-4036-448b-996c-67dd9246a395
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            // Three contexts following different strategies
            context = new Context(new ConcreteStrategyA());
            context.Execute();

            context = new Context(new ConcreteStrategyB());
            context.Execute();

            context = new Context(new ConcreteStrategyC());
            context.Execute();
        }

    }

    // The classes that implement a concrete strategy should implement this
    // The context class uses this to call the concrete strategy
    interface IStrategy
    {
        void Execute();
    }

    // Implements the algorithm using the strategy interface
    class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStrategyA.Execute()");
        }
    }

    class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStrategyB.Execute()");
        }
    }

    class ConcreteStrategyC : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStrategyC.Execute()");
        }
    }

    // Configured with a ConcreteStrategy object and maintains a reference to a Strategy object
    class Context
    {
        IStrategy strategy;

        // Constructor
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Execute()
        {
            strategy.Execute();
        }
    }
}
