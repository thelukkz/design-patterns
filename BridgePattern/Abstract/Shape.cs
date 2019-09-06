namespace BridgePattern.Abstract
{
    public abstract class Shape
    {
        protected DrawApi _implementor;

        public Shape(DrawApi implementor)
        {
            _implementor = implementor;
        }

        public abstract void Draw();
    }
}
