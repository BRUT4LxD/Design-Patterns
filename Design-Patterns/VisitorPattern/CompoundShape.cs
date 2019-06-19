namespace Visitor
{
    public class CompoundShape : IShape
    {
        public void Draw()
        {
            throw new System.NotImplementedException();
        }

        public void Move(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompoundShape(this);
        }
    }
}