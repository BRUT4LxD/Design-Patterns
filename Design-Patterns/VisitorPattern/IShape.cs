namespace VisitorPattern
{
    public interface IShape
    {
        void Draw();

        void Move(int x, int y);

        void Accept(IVisitor visitor);
    }
}