using ProxyPattern.Abstract;

namespace ProxyPattern.Concrete
{
    class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            // this is a virtual proxy - we use lazy instantiation
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }
}
