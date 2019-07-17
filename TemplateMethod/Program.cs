using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Libarary libarary = new Application();
            libarary.Run();
            Console.ReadKey();
        }
    }
}
