namespace Visitor
{
    public class Circle : IShape
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
            visitor.VisitCircle(this);
        }
    }
}