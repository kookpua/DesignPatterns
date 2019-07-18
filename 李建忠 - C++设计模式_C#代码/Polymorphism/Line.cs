using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Line:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Line");
        }
    }
}
