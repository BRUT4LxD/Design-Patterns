namespace VisitorPattern
{
    public interface IVisitor
    {
        void VisitDot(Dot dot);

        void VisitRectangle(Rectangle rectangle);

        void VisitCircle(Circle circle);

        void VisitCompoundShape(CompoundShape compoundShape);
    }
}