using CompositePattern.Concrete;
using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = new Html();
            var body = new Body();
            var p = new P();
            var text = new Text("Hello world!");

            p.AddChild(text);
            body.AddChild(p);
            html.AddChild(body);

            Console.WriteLine(html.Render());
            Console.ReadKey();
        }
    }
}
