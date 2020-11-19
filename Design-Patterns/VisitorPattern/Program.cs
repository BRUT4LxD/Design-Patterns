using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var shapes = new List<IShape>
            {
                new Dot(),
                new Rectangle(),
                new Circle(),
                new CompoundShape()
            };

            XMLExportVisitor visitor = new XMLExportVisitor();

            foreach (IShape shape in shapes)
            {
                shape.Accept(visitor);
            }
            Console.ReadKey();
        }
    }
}