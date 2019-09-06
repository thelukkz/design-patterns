using BridgePattern.Abstract;

namespace BridgePattern.Concrete.Shapes
{
    public class Square : Shape
    {
        public Square(DrawApi implementor) : base(implementor)
        {

        }

        public override void Draw()
        {
            _implementor.DrawLine(0, 0, 100, 0);
            _implementor.DrawLine(100, 0, 100, 100);
            _implementor.DrawLine(100, 100, 0, 100);
            _implementor.DrawLine(0, 100, 0, 0);
        }
    }
}
