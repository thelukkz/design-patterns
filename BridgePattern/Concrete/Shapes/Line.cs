using BridgePattern.Abstract;

namespace BridgePattern.Concrete.Shapes
{
    public class Line : Shape
    {
        public Line(DrawApi implementor) : base(implementor)
        {

        }

        public override void Draw()
        {
            _implementor.DrawLine(0, 0, 100, 100);
        }
    }
}
