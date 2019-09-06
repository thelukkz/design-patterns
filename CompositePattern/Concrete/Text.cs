using CompositePattern.Abstract;

namespace CompositePattern.Concrete
{
    public class Text : LeafNode
    {
        protected string _text = null;
        public Text(string text)
        {
            _text = text;
        }

        public override string Render()
        {
            return _text;
        }
    }
}
