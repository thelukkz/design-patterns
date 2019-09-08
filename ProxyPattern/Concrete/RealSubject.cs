using ProxyPattern.Abstract;
using System;

namespace ProxyPattern.Concrete
{
    class RealSubject : Subject
    {
        public RealSubject()
        {
            Console.WriteLine("RealSubject.ctor()");
        }

        public override void Request()
        {
            Console.WriteLine("RealSubject.Request()");
        }
    }
}
