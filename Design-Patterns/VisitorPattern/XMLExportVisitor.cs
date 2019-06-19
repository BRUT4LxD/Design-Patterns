using System;

namespace Visitor
{
    public class XMLExportVisitor : IVisitor
    {
        public void VisitDot(Dot dot)
        {
            Console.WriteLine("XML export for dot");
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine("XML export for rectangle");
        }

        public void VisitCircle(Circle circle)
        {
            Console.WriteLine("XML export for circle");
        }

        public void VisitCompoundShape(CompoundShape compoundShape)
        {
            Console.WriteLine("XML export for compoundShape");
        }
    }
}