using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Abstract
{
    public abstract class HtmlTag : HtmlNode
    {
        protected string _tagName = null;

        protected List<HtmlNode> _elements = new List<HtmlNode>();

        protected HtmlTag(string tagName)
        {
            _tagName = tagName;
        }

        public void AddChild(HtmlNode component)
        {
            _elements.Add(component);
        }

        public override string Render()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("<{0}>", _tagName);
            foreach (HtmlNode child in _elements)
            {
                sb.Append(child.Render());
            }
            sb.AppendFormat("</{0}>", _tagName);

            return sb.ToString();
        }
    }
}
